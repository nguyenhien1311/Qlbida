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
    public partial class frmCustomer : Form
    {
        private BidaDataContext db;
        public frmCustomer()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer() {
            var data = from c in db.Customers
                       select c;
            dgvCustomer.DataSource = data;
            CustomerDetails();
        }
        private void CustomerDetails() {
            if (dgvCustomer.CurrentRow != null)
            {
                var row = dgvCustomer.CurrentRow;
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtCusAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtLevel.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            CustomerDetails();
        }
    }
}
