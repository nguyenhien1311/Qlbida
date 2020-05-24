﻿namespace QlBida
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
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 16);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.Size = new System.Drawing.Size(793, 375);
            this.dgvOrderList.TabIndex = 0;
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
            this.dtpDateToFill.CustomFormat = "dd/mm/yyyy";
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
    }
}