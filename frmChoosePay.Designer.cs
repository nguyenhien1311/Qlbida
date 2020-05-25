namespace QlBida
{
    partial class frmChoosePay
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
            this.btnCustomerPayment = new System.Windows.Forms.Button();
            this.btnDefaultPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerPayment
            // 
            this.btnCustomerPayment.Location = new System.Drawing.Point(30, 38);
            this.btnCustomerPayment.Name = "btnCustomerPayment";
            this.btnCustomerPayment.Size = new System.Drawing.Size(116, 23);
            this.btnCustomerPayment.TabIndex = 0;
            this.btnCustomerPayment.Text = "Thanh toán hội viên";
            this.btnCustomerPayment.UseVisualStyleBackColor = true;
            this.btnCustomerPayment.Click += new System.EventHandler(this.btnCustomerPayment_Click);
            // 
            // btnDefaultPayment
            // 
            this.btnDefaultPayment.Location = new System.Drawing.Point(166, 38);
            this.btnDefaultPayment.Name = "btnDefaultPayment";
            this.btnDefaultPayment.Size = new System.Drawing.Size(116, 23);
            this.btnDefaultPayment.TabIndex = 1;
            this.btnDefaultPayment.Text = "Thanh toán thường";
            this.btnDefaultPayment.UseVisualStyleBackColor = true;
            this.btnDefaultPayment.Click += new System.EventHandler(this.btnDefaultPayment_Click);
            // 
            // frmChoosePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 95);
            this.Controls.Add(this.btnDefaultPayment);
            this.Controls.Add(this.btnCustomerPayment);
            this.Name = "frmChoosePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phương thức thanh toán";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerPayment;
        private System.Windows.Forms.Button btnDefaultPayment;
    }
}