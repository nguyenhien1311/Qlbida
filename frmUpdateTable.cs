using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlBida
{
    public partial class frmUpdateTable : Form
    {
        private BidaDataContext db;
        private BidaTable tb;

        public frmUpdateTable(BidaTable table)
        {
            InitializeComponent();
            tb = table;
            db = new BidaDataContext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTable_Load(object sender, EventArgs e)
        {
            LoadTableDetails();
            LoadTbCat();
        }

        private void LoadTbCat()
        {
            var cats = from c in db.TableCategories
                       select c;
            cbxTableCat.DataSource = cats;
            cbxTableCat.DisplayMember = "TableCatName";
            cbxTableCat.ValueMember = "TableCatId";
        }

        private void LoadTableDetails()
        {
            txtNewTableName.Text = tb.TableName;
            cbxTableCat.SelectedItem = tb.TableCatID;
            txtPrice.Text = tb.Price.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewTableName.Text = txtPrice.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updateTb = db.BidaTables.SingleOrDefault(x=>x.TableId == tb.TableId);
            updateTb.TableName = txtNewTableName.Text;
            updateTb.TableCatID = (cbxTableCat.SelectedItem as TableCategory).TableCatId;
            updateTb.Price = Convert.ToDouble(txtPrice.Text);
            updateTb.TableStatus = 1;
            db.SubmitChanges();
            if (MessageBox.Show("Sua thanh cong", "Sua thong tin ban", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
