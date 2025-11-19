using System;
using System.Windows.Forms;

namespace OrderPipeline
{
    public partial class Form1 : Form
    {
        // ========= EVENTS =========
        public event EventHandler? OrderCreated;
        public event EventHandler? OrderRejected;
        public event EventHandler? OrderConfirmed;

        // Task 2 Event
        public event EventHandler<ShipEventArgs>? OrderShipped;

        bool orderValid = false;  // to prevent shipping without confirmation

        public Form1()
        {
            InitializeComponent();

            // ========= EVENT SUBSCRIPTIONS FOR TASK 1 =========
            OrderCreated += ValidateOrder;
            OrderCreated += DisplayOrderInfo;

            OrderRejected += ShowRejection;
            OrderConfirmed += ShowConfirmation;

            // ========= DYNAMIC SUBSCRIPTION FOR TASK 2 =========
            chkExpress.CheckedChanged += chkExpress_CheckedChanged;

            // Always add ShowDispatch
            OrderShipped += ShowDispatch;

            // NotifyCourier ONLY added when express shipping is checked
            if (chkExpress.Checked)
                OrderShipped += NotifyCourier;
        }

        // ========= PROCESS ORDER BUTTON (Task 1) =========
        private void btnProcessOrder_Click_1(object? sender, EventArgs e)
        {
            OrderCreated?.Invoke(this, EventArgs.Empty);
        }

        // ========= SHIP ORDER BUTTON (Task 2) =========
        private void btnShipOrder_Click(object? sender, EventArgs e)
        {
            if (!orderValid)
            {
                MessageBox.Show("Order must be confirmed before shipping.");
                return;
            }

            // Create EventArgs
            ShipEventArgs args = new ShipEventArgs(cmbProducts.Text, chkExpress.Checked);

            OrderShipped?.Invoke(this, args);
        }

        // ========= EVENT HANDLERS (Task 1) =========

        private void ValidateOrder(object? sender, EventArgs e)
        {
            if (numQuantity.Value > 0)
            {
                lblStatus.Text = "Validated";
                orderValid = true;
                OrderConfirmed?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                orderValid = false;
                OrderRejected?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DisplayOrderInfo(object? sender, EventArgs e)
        {
            MessageBox.Show(
                $"Customer: {txtCustomerName.Text}\nProduct: {cmbProducts.Text}\nQuantity: {numQuantity.Value}",
                "Order Info"
            );
        }

        private void ShowRejection(object? sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry";
        }

        private void ShowConfirmation(object? sender, EventArgs e)
        {
            lblStatus.Text = $"Order Processed Successfully for {txtCustomerName.Text}";
        }

        // ========= EVENT HANDLERS (Task 2: Shipping) =========

        private void ShowDispatch(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
        }

        private void NotifyCourier(object? sender, ShipEventArgs e)
        {
            if (e.Express)
            {
                MessageBox.Show("Express delivery initiated!");
            }
        }

        // ========= CHECKBOX EVENT (Dynamic Subscription) =========
        private void chkExpress_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkExpress.Checked)
            {
                OrderShipped += NotifyCourier;  // add subscriber
            }
            else
            {
                OrderShipped -= NotifyCourier;  // remove subscriber
            }
        }

        // ========= AUTO-GENERATED FORM EVENTS =========
        private void Form1_Load(object? sender, EventArgs e) { }
        private void cmbProducts_SelectedIndexChanged(object? sender, EventArgs e) { }
        private void label1_Click(object? sender, EventArgs e) { }
        private void numQuantity_ValueChanged(object? sender, EventArgs e) { }
    }
}
