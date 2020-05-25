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
    public partial class frmShowBill : Form
    {
        Customer cus;
        public frmShowBill(Customer customer)
        {
            cus = customer;
            InitializeComponent();
        }

        public frmShowBill()
        {
            InitializeComponent();
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            lblTableName.Text = cus.CusName;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
