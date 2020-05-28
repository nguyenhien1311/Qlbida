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
    public partial class frmChoosePay : Form
    {

        OrderTable ord;
        public frmChoosePay(OrderTable order)
        {
            InitializeComponent();
            ord = order;
        }

        private void btnCustomerPayment_Click(object sender, EventArgs e)
        {
            frmFindCustomer frm = new frmFindCustomer(ord);
            frm.Show();
            this.Close();
        }

        private void btnDefaultPayment_Click(object sender, EventArgs e)
        {
            frmShowBill frm = new frmShowBill(ord);
            frm.Show();
            this.Close();
        }
    }
}
