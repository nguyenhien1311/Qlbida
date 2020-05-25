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
    public partial class frmFindCustomer : Form
    {
        private BidaDataContext db;
        public frmFindCustomer()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            frmShowBill frm = new frmShowBill();
            frm.Show();
            this.Close();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer() {
            var data = from c in db.Customers
                       select c;
            dgvCusList.DataSource = data;
        }
    }
}
