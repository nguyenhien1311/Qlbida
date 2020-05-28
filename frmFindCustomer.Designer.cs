namespace QlBida
{
    partial class frmFindCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCusList = new System.Windows.Forms.DataGridView();
            this.CusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCusList);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hội viên";
            // 
            // dgvCusList
            // 
            this.dgvCusList.AllowUserToAddRows = false;
            this.dgvCusList.AllowUserToDeleteRows = false;
            this.dgvCusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusId,
            this.CusName,
            this.CusAddress,
            this.CusPhone,
            this.CusLevel});
            this.dgvCusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCusList.Location = new System.Drawing.Point(3, 16);
            this.dgvCusList.MultiSelect = false;
            this.dgvCusList.Name = "dgvCusList";
            this.dgvCusList.ReadOnly = true;
            this.dgvCusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCusList.Size = new System.Drawing.Size(587, 269);
            this.dgvCusList.TabIndex = 0;
            // 
            // CusId
            // 
            this.CusId.DataPropertyName = "CusId";
            this.CusId.HeaderText = "Mã HV";
            this.CusId.Name = "CusId";
            this.CusId.ReadOnly = true;
            // 
            // CusName
            // 
            this.CusName.DataPropertyName = "CusName";
            this.CusName.HeaderText = "Họ tên";
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            this.CusName.Width = 150;
            // 
            // CusAddress
            // 
            this.CusAddress.DataPropertyName = "CusAddress";
            this.CusAddress.HeaderText = "Địa chỉ";
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.ReadOnly = true;
            // 
            // CusPhone
            // 
            this.CusPhone.DataPropertyName = "CusPhone";
            this.CusPhone.HeaderText = "SĐT";
            this.CusPhone.Name = "CusPhone";
            this.CusPhone.ReadOnly = true;
            this.CusPhone.Width = 104;
            // 
            // CusLevel
            // 
            this.CusLevel.DataPropertyName = "CusLevel";
            this.CusLevel.HeaderText = "Cấp độ";
            this.CusLevel.Name = "CusLevel";
            this.CusLevel.ReadOnly = true;
            this.CusLevel.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hội viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(457, 347);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(145, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Tiến hành thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // frmFindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 382);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFindCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm hội viên";
            this.Load += new System.EventHandler(this.frmFindCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCusList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusLevel;
    }
}