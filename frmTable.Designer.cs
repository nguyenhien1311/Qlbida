namespace QlBida
{
    partial class frmTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTablePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.btnEndTime = new System.Windows.Forms.Button();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbxServiceCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSerive = new System.Windows.Forms.DataGridView();
            this.txtTiming = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flpTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerive)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpTableList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bàn";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(654, 21);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(119, 20);
            this.txtTableName.TabIndex = 2;
            // 
            // txtTablePrice
            // 
            this.txtTablePrice.Location = new System.Drawing.Point(654, 61);
            this.txtTablePrice.Name = "txtTablePrice";
            this.txtTablePrice.ReadOnly = true;
            this.txtTablePrice.Size = new System.Drawing.Size(119, 20);
            this.txtTablePrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá tiền";
            // 
            // btnStartTime
            // 
            this.btnStartTime.Location = new System.Drawing.Point(554, 170);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(90, 29);
            this.btnStartTime.TabIndex = 5;
            this.btnStartTime.Text = "Tính giờ";
            this.btnStartTime.UseVisualStyleBackColor = true;
            // 
            // btnEndTime
            // 
            this.btnEndTime.Location = new System.Drawing.Point(684, 170);
            this.btnEndTime.Name = "btnEndTime";
            this.btnEndTime.Size = new System.Drawing.Size(89, 29);
            this.btnEndTime.TabIndex = 6;
            this.btnEndTime.Text = "Kết thúc";
            this.btnEndTime.UseVisualStyleBackColor = true;
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(654, 100);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(119, 20);
            this.txtSurcharge.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phụ phí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(531, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 269);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.cbxServiceCategory);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 45);
            this.panel2.TabIndex = 19;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(190, 14);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 20;
            this.btnAddService.Text = "Thêm DV";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // cbxServiceCategory
            // 
            this.cbxServiceCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServiceCategory.FormattingEnabled = true;
            this.cbxServiceCategory.Location = new System.Drawing.Point(78, 16);
            this.cbxServiceCategory.Name = "cbxServiceCategory";
            this.cbxServiceCategory.Size = new System.Drawing.Size(98, 21);
            this.cbxServiceCategory.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSerive);
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 199);
            this.panel1.TabIndex = 18;
            // 
            // dgvSerive
            // 
            this.dgvSerive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSerive.Location = new System.Drawing.Point(0, 0);
            this.dgvSerive.Name = "dgvSerive";
            this.dgvSerive.Size = new System.Drawing.Size(274, 199);
            this.dgvSerive.TabIndex = 15;
            // 
            // txtTiming
            // 
            this.txtTiming.Location = new System.Drawing.Point(654, 135);
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.ReadOnly = true;
            this.txtTiming.Size = new System.Drawing.Size(119, 20);
            this.txtTiming.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thời gian chơi";
            // 
            // flpTableList
            // 
            this.flpTableList.AutoScroll = true;
            this.flpTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTableList.Location = new System.Drawing.Point(3, 16);
            this.flpTableList.Name = "flpTableList";
            this.flpTableList.Size = new System.Drawing.Size(507, 443);
            this.flpTableList.TabIndex = 0;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.txtTiming);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSurcharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEndTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.txtTablePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTablePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Button btnEndTime;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTiming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cbxServiceCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSerive;
        private System.Windows.Forms.FlowLayoutPanel flpTableList;
    }
}