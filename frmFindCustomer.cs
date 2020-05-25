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

        Customer cus;

        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            frmShowBill frm = new frmShowBill(cus);
            frm.Show();
            this.Close();
        }

        private void dgvCusList_Click(object sender, EventArgs e)
        {
        }
    }
}
