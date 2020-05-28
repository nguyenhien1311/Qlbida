namespace QlBida
{
    partial class frmChangeTable
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
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTable
            // 
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Location = new System.Drawing.Point(122, 43);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(121, 21);
            this.cbxTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(72, 93);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Chuyển";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChangeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 146);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTable);
            this.Name = "frmChangeTable";
            this.Text = "Chuyển bàn";
            this.Load += new System.EventHandler(this.frmChangeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExit;
    }
}