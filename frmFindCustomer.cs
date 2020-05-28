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
        Customer cus;
        OrderTable ord;
        public frmFindCustomer(OrderTable order)
        {
            InitializeComponent();
            db = new BidaDataContext();
            ord = order;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var row = dgvCusList.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var result = db.Customers.SingleOrDefault(x => x.CusId == id);
            cus = result;
            frmShowBill frm = new frmShowBill(cus,ord);
            frm.Show();
            this.Close();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            var data = from c in db.Customers
                       select c;
            dgvCusList.DataSource = data;
        }
    }
}
