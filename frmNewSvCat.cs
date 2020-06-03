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
    public partial class frmNewSvCat : Form
    {
        private BidaDataContext db;

        public frmNewSvCat()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            string name = txtCatName.Text;
            var cat = db.ServiceCategories.SingleOrDefault(x => x.SvCatName.ToLower().Equals(name.ToLower()));
            if (cat != null)
            {
                MessageBox.Show("Loại DV đã tồn tại");
                txtCatName.Clear();
                txtCatName.Focus();
            }
            else
            {
                ServiceCategory svCat = new ServiceCategory();
                svCat.SvCatName = name;
                db.ServiceCategories.InsertOnSubmit(svCat);
                db.SubmitChanges();
            }
        }
    }
}
