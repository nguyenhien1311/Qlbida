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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails();
            frm.Show();
        }
    }
}
