namespace EventPlayground1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeColor.Location = new System.Drawing.Point(136, 135);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeColor.Size = new System.Drawing.Size(173, 45);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(475, 135);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(204, 45);
            this.btnChangeText.TabIndex = 1;
            this.btnChangeText.Text = "Change Text";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(280, 58);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(239, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Welcome to Events Lab";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.cmbColors.Location = new System.Drawing.Point(330, 243);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(163, 33);
            this.cmbColors.TabIndex = 3;
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.cmbColors_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbColors;
    }
}

