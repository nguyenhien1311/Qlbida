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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblUserError.Text = "";
            lblPassEreor.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            BidaDataContext bida = new BidaDataContext();
                var account = bida.Accounts.SingleOrDefault(x=>x.UserName.Equals(user));
                if (account!=null)
                {
                    lblUserError.Text = "";
                    if (account.Password.Equals(pass))
                    {
                        lblPassEreor.Text = "";
                        frmHome frm = new frmHome(account);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblPassEreor.Text = "Mật khẩu không đúng";
                        txtPassword.Focus();
                    }
                }
                else
                {
                    lblUserError.Text = "Tên tài khoản không đúng";
                    txtUsername.Focus();
                }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
