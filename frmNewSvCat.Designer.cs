namespace QlBida
{
    partial class frmNewSvCat
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
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(99, 68);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 0;
            this.btnAddCat.Text = "Thêm";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(99, 37);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(137, 20);
            this.txtCatName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên loại DV";
            // 
            // frmNewSvCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.btnAddCat);
            this.Name = "frmNewSvCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label1;
    }
}