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
    public partial class frmNewTable : Form
    {
        private BidaDataContext db;
        public frmNewTable()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTableName.Text = txtPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BidaTable tb = new BidaTable();
            tb.TableName = txtTableName.Text;
            tb.TableCatID = (cbxTableCat.SelectedItem as TableCategory).TableCatId;
            tb.Price = Convert.ToDouble(txtPrice.Text);
            tb.PlayTime = 0;
            tb.TableStatus = 1;
            db.BidaTables.InsertOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("Them ban thanh cong", "Them ban", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void frmNewTable_Load(object sender, EventArgs e)
        {
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
    }
}
