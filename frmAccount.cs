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
    public partial class frmAccount : Form
    {
        private BidaDataContext db;
        public frmAccount()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void LoadAccount() {
            var data = from a in db.Accounts
                       select a;
            dgvAccount.DataSource = data;
            AccountDetails();
        }
        private void AccountDetails(){
            if (dgvAccount.CurrentRow != null)
            {
                var row = dgvAccount.CurrentRow;
                txtAccName.Text = row.Cells[0].Value.ToString();
                txtAccEmail.Text = row.Cells[1].Value.ToString();
                txtAccPhone.Text = row.Cells[2].Value.ToString();
                txtUserName.Text = row.Cells[3].Value.ToString();
                txtPassword.Text = row.Cells[4].Value.ToString();
                txtAccLevel.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            AccountDetails();
        }
    }
}
