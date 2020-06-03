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
    public partial class frmHome : Form
    {
        public Account accInfo { get; set; }
        public frmHome(Account account)
        {
            InitializeComponent();
            accInfo = account;
            lblName.Text = account.Name;
        }

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát ?","Thoát ứng dụng",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                this.Hide();
                frm.Show();
            }
        }

        private void btnOrderTable_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            LoadMdiForm(frm);
        }

        private void btnOrderService_Click(object sender, EventArgs e)
        {
            frmService frm = new frmService();
            LoadMdiForm(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            LoadMdiForm(frm);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            LoadMdiForm(frm);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.Acc = accInfo;
            LoadMdiForm(frm);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            LoadMdiForm(frm);
        }

        private void LoadMdiForm(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.ActiveMdiChild != null)
            {
                var frmcurrent = this.ActiveMdiChild;
                if (frm.Name != frmcurrent.Name)
                {
                    frmcurrent.Close();
                    frm.Show();
                }
            }
            frm.Show();
        }

    }
}
