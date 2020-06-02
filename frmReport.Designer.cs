namespace QlBida
{
    partial class frmReport
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.OrdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateToFill = new System.Windows.Forms.DateTimePicker();
            this.btnFillByDate = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderList);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdId,
            this.CusId,
            this.CusName,
            this.TableId,
            this.TableName,
            this.StartTime,
            this.EndTime,
            this.Surcharge,
            this.PlayTime,
            this.Price,
            this.Status});
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 16);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(793, 375);
            this.dgvOrderList.TabIndex = 0;
            this.dgvOrderList.VisibleChanged += new System.EventHandler(this.dgvOrderList_VisibleChanged);
            // 
            // OrdId
            // 
            this.OrdId.DataPropertyName = "OrderId";
            this.OrdId.HeaderText = "Mã hóa đơn";
            this.OrdId.Name = "OrdId";
            this.OrdId.ReadOnly = true;
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
            this.CusName.HeaderText = "HV";
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // TableId
            // 
            this.TableId.DataPropertyName = "TableId";
            this.TableId.HeaderText = "Mã bàn";
            this.TableId.Name = "TableId";
            this.TableId.ReadOnly = true;
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            this.TableName.HeaderText = "Tên bàn";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Bắt đầu";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "Kết thúc";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // Surcharge
            // 
            this.Surcharge.DataPropertyName = "Surcharge";
            this.Surcharge.HeaderText = "Phụ phí";
            this.Surcharge.Name = "Surcharge";
            this.Surcharge.ReadOnly = true;
            // 
            // PlayTime
            // 
            this.PlayTime.DataPropertyName = "PlayTime";
            this.PlayTime.HeaderText = "Thời gian chơi";
            this.PlayTime.Name = "PlayTime";
            this.PlayTime.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Tổng tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "OrdStatus";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lọc theo ngày";
            // 
            // dtpDateToFill
            // 
            this.dtpDateToFill.CustomFormat = "dd/MM/yyyy";
            this.dtpDateToFill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateToFill.Location = new System.Drawing.Point(534, 17);
            this.dtpDateToFill.Name = "dtpDateToFill";
            this.dtpDateToFill.Size = new System.Drawing.Size(143, 20);
            this.dtpDateToFill.TabIndex = 2;
            // 
            // btnFillByDate
            // 
            this.btnFillByDate.Location = new System.Drawing.Point(694, 9);
            this.btnFillByDate.Name = "btnFillByDate";
            this.btnFillByDate.Size = new System.Drawing.Size(99, 31);
            this.btnFillByDate.TabIndex = 3;
            this.btnFillByDate.Text = "Tìm kiếm";
            this.btnFillByDate.UseVisualStyleBackColor = true;
            this.btnFillByDate.Click += new System.EventHandler(this.btnFillByDate_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(578, 443);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(99, 31);
            this.btnOrderDetails.TabIndex = 4;
            this.btnOrderDetails.Text = "Chi tiết hóa đơn";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(694, 443);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(99, 31);
            this.btnExportReport.TabIndex = 5;
            this.btnExportReport.Text = "Xuất báo cáo";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnFillByDate);
            this.Controls.Add(this.dtpDateToFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateToFill;
        private System.Windows.Forms.Button btnFillByDate;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}