using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        public delegate void ColorChangedHandler();
        public delegate void TextChangedHandler();

        public event ColorChangedHandler ColorChangedEvent;
        public event TextChangedHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Event Playground - Task 1";
            this.Size = new Size(400, 300);

            Label lblDisplay = new Label()
            {
                Text = "Welcome to Events Lab",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(60, 40),
                AutoSize = true
            };

            Button btnChangeColor = new Button()
            {
                Text = "Change Color",
                Location = new Point(60, 100),
                Width = 120
            };

            Button btnChangeText = new Button()
            {
                Text = "Change Text",
                Location = new Point(200, 100),
                Width = 120
            };

            ComboBox cmbColors = new ComboBox()
            {
                Location = new Point(60, 160),
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbColors.Items.AddRange(new string[] { "Red", "Green", "Blue" });

            this.Controls.Add(lblDisplay);
            this.Controls.Add(btnChangeColor);
            this.Controls.Add(btnChangeText);
            this.Controls.Add(cmbColors);

            ColorChangedEvent += () =>
            {
                if (cmbColors.SelectedItem != null)
                    lblDisplay.ForeColor = Color.FromName(cmbColors.SelectedItem.ToString());
                else
                    MessageBox.Show("Please select a color first!");
            };

            TextChangedEvent += () =>
            {
                lblDisplay.Text = "Updated on: " + DateTime.Now.ToString();
            };

            btnChangeColor.Click += (s, e) => ColorChangedEvent?.Invoke();
            btnChangeText.Click += (s, e) => TextChangedEvent?.Invoke();
        }
    }
}
