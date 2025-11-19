using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground1
{
    public partial class Form1 : Form
    {
        // Color change uses the event pattern with custom EventArgs
        public event EventHandler<ColorEventArgs> ColorChangedEvent;

        // Text change event (no extra data required) using EventHandler
        public event EventHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            // Subscribe methods to events (multicast for color)
            ColorChangedEvent += UpdateLabelColor;    // subscriber 1
            ColorChangedEvent += ShowNotification;    // subscriber 2 (multicast)
            TextChangedEvent += UpdateLabelText;

            // Populate combo box items (in case not set via designer)
            if (cmbColors.Items.Count == 0)
            {
                cmbColors.Items.AddRange(new object[] { "Red", "Green", "Blue" });
                cmbColors.SelectedIndex = 0;
            }
        }

        // Button Clicks: raise the custom events
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string selected = cmbColors.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            // Fire the custom ColorChangedEvent and pass ColorEventArgs
            ColorChangedEvent?.Invoke(this, new ColorEventArgs(selected));
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            // Fire text changed event (no payload)
            TextChangedEvent?.Invoke(this, EventArgs.Empty);
        }

        // ---------- Event handlers (subscribers) ----------

        // Subscriber 1: change the label colour based on EventArgs
        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            if (e == null || string.IsNullOrEmpty(e.SelectedColor))
                return;

            switch (e.SelectedColor)
            {
                case "Red":
                    lblMessage.ForeColor = Color.Red;
                    break;
                case "Green":
                    lblMessage.ForeColor = Color.Green;
                    break;
                case "Blue":
                    lblMessage.ForeColor = Color.Blue;
                    break;
                default:
                    lblMessage.ForeColor = SystemColors.ControlText;
                    break;
            }
        }

        // Subscriber 2: show a notification (demonstrates multicast)
        private void ShowNotification(object sender, ColorEventArgs e)
        {
            if (e == null) return;
            // MessageBox is also a UI output as required by the lab
            MessageBox.Show($"Selected colour: {e.SelectedColor}", "Color Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Text update handler (shows date & time)
        private void UpdateLabelText(object sender, EventArgs e)
        {
            lblMessage.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        // Optional: designer-created empty handlers (safe to leave)
        private void Form1_Load(object sender, EventArgs e) { }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lblMessage_Click(object sender, EventArgs e) { }
    }
}
