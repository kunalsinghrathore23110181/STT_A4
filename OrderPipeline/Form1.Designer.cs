namespace OrderPipeline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            cmbProducts = new ComboBox();
            numQuantity = new NumericUpDown();
            btnProcessOrder = new Button();
            lblStatus = new Label();
            chkExpress = new CheckBox();
            btnShipOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(247, 69);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 39);
            txtCustomerName.TabIndex = 0;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Items.AddRange(new object[] { "Laptop", "Mouse", "Keyboard" });
            cmbProducts.Location = new Point(220, 138);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(242, 40);
            cmbProducts.TabIndex = 1;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(220, 233);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(240, 39);
            numQuantity.TabIndex = 2;
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Location = new Point(119, 368);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(258, 46);
            btnProcessOrder.TabIndex = 3;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = true;
            btnProcessOrder.Click += btnProcessOrder_Click_1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(585, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 32);
            lblStatus.TabIndex = 4;
            // 
            // chkExpress
            // 
            chkExpress.AutoSize = true;
            chkExpress.Location = new Point(531, 306);
            chkExpress.Name = "chkExpress";
            chkExpress.Size = new Size(229, 36);
            chkExpress.TabIndex = 5;
            chkExpress.Text = "Express Delivery?";
            chkExpress.UseVisualStyleBackColor = true;
            chkExpress.CheckedChanged += chkExpress_CheckedChanged;
            // 
            // btnShipOrder
            // 
            btnShipOrder.Location = new Point(519, 368);
            btnShipOrder.Name = "btnShipOrder";
            btnShipOrder.Size = new Size(204, 46);
            btnShipOrder.TabIndex = 6;
            btnShipOrder.Text = "Ship Order";
            btnShipOrder.UseVisualStyleBackColor = true;
            btnShipOrder.Click += btnShipOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShipOrder);
            Controls.Add(chkExpress);
            Controls.Add(lblStatus);
            Controls.Add(btnProcessOrder);
            Controls.Add(numQuantity);
            Controls.Add(cmbProducts);
            Controls.Add(txtCustomerName);
            Name = "Form1";
            Text = "Order Pipeline";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private ComboBox cmbProducts;
        private NumericUpDown numQuantity;
        private Button btnProcessOrder;
        private Label lblStatus;
        private CheckBox chkExpress;
        private Button btnShipOrder;
    }
}
