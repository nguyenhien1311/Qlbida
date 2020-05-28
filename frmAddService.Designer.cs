namespace QlBida
{
    partial class frmAddService
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.SvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvServiceAdded = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnrQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.SvIdAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvNameAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvService);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SvId,
            this.SvName,
            this.SvCatName,
            this.Price,
            this.Quantity});
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(3, 16);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(373, 425);
            this.dgvService.TabIndex = 0;
            // 
            // SvId
            // 
            this.SvId.DataPropertyName = "Id";
            this.SvId.HeaderText = "Mã";
            this.SvId.Name = "SvId";
            this.SvId.ReadOnly = true;
            this.SvId.Width = 50;
            // 
            // SvName
            // 
            this.SvName.DataPropertyName = "Name";
            this.SvName.HeaderText = "DV";
            this.SvName.Name = "SvName";
            this.SvName.ReadOnly = true;
            // 
            // SvCatName
            // 
            this.SvCatName.DataPropertyName = "CatName";
            this.SvCatName.HeaderText = "Loại DV";
            this.SvCatName.Name = "SvCatName";
            this.SvCatName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvServiceAdded);
            this.groupBox2.Location = new System.Drawing.Point(515, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 444);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ đã thêm";
            // 
            // dgvServiceAdded
            // 
            this.dgvServiceAdded.AllowUserToAddRows = false;
            this.dgvServiceAdded.AllowUserToDeleteRows = false;
            this.dgvServiceAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SvIdAdd,
            this.SvNameAdd,
            this.SvQuantity});
            this.dgvServiceAdded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceAdded.Location = new System.Drawing.Point(3, 16);
            this.dgvServiceAdded.Name = "dgvServiceAdded";
            this.dgvServiceAdded.ReadOnly = true;
            this.dgvServiceAdded.Size = new System.Drawing.Size(362, 425);
            this.dgvServiceAdded.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mnrQuantity
            // 
            this.mnrQuantity.Location = new System.Drawing.Point(397, 92);
            this.mnrQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mnrQuantity.Name = "mnrQuantity";
            this.mnrQuantity.Size = new System.Drawing.Size(112, 20);
            this.mnrQuantity.TabIndex = 3;
            this.mnrQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(397, 177);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 29);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Xong";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // SvIdAdd
            // 
            this.SvIdAdd.HeaderText = "Mã";
            this.SvIdAdd.Name = "SvIdAdd";
            this.SvIdAdd.ReadOnly = true;
            // 
            // SvNameAdd
            // 
            this.SvNameAdd.HeaderText = "DV";
            this.SvNameAdd.Name = "SvNameAdd";
            this.SvNameAdd.ReadOnly = true;
            this.SvNameAdd.Width = 120;
            // 
            // SvQuantity
            // 
            this.SvQuantity.HeaderText = "Số lượng";
            this.SvQuantity.Name = "SvQuantity";
            this.SvQuantity.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 468);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mnrQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddService";
            this.Text = "Dịch vụ bàn";
            this.Load += new System.EventHandler(this.frmAddService_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnrQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvServiceAdded;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown mnrQuantity;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvIdAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SvQuantity;
        private System.Windows.Forms.Button btnDelete;
    }
}