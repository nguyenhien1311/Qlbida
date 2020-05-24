namespace QlBida
{
    partial class frmService
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbxServiceCategory = new System.Windows.Forms.ComboBox();
            this.btnNewService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng dịch vụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(614, 44);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(120, 20);
            this.txtServiceName.TabIndex = 5;
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(614, 189);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(120, 20);
            this.txtServicePrice.TabIndex = 6;
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Location = new System.Drawing.Point(614, 138);
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nmrQuantity.TabIndex = 7;
            // 
            // cbxServiceCategory
            // 
            this.cbxServiceCategory.FormattingEnabled = true;
            this.cbxServiceCategory.Location = new System.Drawing.Point(613, 88);
            this.cbxServiceCategory.Name = "cbxServiceCategory";
            this.cbxServiceCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxServiceCategory.TabIndex = 8;
            // 
            // btnNewService
            // 
            this.btnNewService.Location = new System.Drawing.Point(511, 283);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(83, 23);
            this.btnNewService.TabIndex = 9;
            this.btnNewService.Text = "Thêm DV";
            this.btnNewService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(718, 283);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(83, 23);
            this.btnUpdateService.TabIndex = 10;
            this.btnUpdateService.Text = " Sửa thông tin";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(614, 283);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(83, 23);
            this.btnSaveChange.TabIndex = 11;
            this.btnSaveChange.Text = "Lưu";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnNewService);
            this.Controls.Add(this.cbxServiceCategory);
            this.Controls.Add(this.nmrQuantity);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmService";
            this.Text = "frmService";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.ComboBox cbxServiceCategory;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}