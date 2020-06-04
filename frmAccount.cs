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
        public Account Acc { get; set; }
        private bool edit = true;
        private BidaDataContext db;
        public frmAccount()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
            if (Acc.AccLevel< 2)
            {
                btnLevelUp.Enabled = false;
            }
        }

        private void LoadAccount()
        {
            var data = db.Accounts.Where(x => x.AccLevel > 0);
            dgvAccount.DataSource = data;
            AccountDetails();
        }


        private void AccountDetails()
        {
            if (dgvAccount.CurrentRow != null)
            {
                var row = dgvAccount.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtAccName.Text = row.Cells[1].Value.ToString();
                txtAccEmail.Text = row.Cells[2].Value.ToString();
                txtAccPhone.Text = row.Cells[3].Value.ToString();
                txtUserName.Text = row.Cells[4].Value.ToString();
                txtPassword.Text = row.Cells[5].Value.ToString();
                txtAccLevel.Text = row.Cells[6].Value.ToString();
                edit = true;
            }
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            AccountDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            txtAccName.Text = txtAccEmail.Text = txtAccPhone.Text = txtUserName.Text = txtPassword.Text = "";
            txtAccLevel.Text = "1";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var acc = db.Accounts.SingleOrDefault(x => x.Id == Convert.ToInt32(txtId.Text));
                acc.Name = txtAccName.Text;
                acc.Email = txtAccEmail.Text;
                acc.Phone = txtAccPhone.Text;
                acc.UserName = txtUserName.Text;
                acc.Password = txtPassword.Text;
                db.SubmitChanges();
                LoadAccount();
            }
            else
            {
                var accChk = db.Accounts.SingleOrDefault(x =>x.AccLevel != 0 && x.Email.ToLower().Equals(txtAccEmail.Text.ToLower()) );
                if (accChk==null)
                {
                    Account acc = new Account();
                    acc.Name = txtAccName.Text;
                    acc.Email = txtAccEmail.Text;
                    acc.Phone = txtAccPhone.Text;
                    acc.UserName = txtUserName.Text;
                    acc.Password = txtPassword.Text;
                    acc.AccLevel = 1;
                    db.Accounts.InsertOnSubmit(acc);
                    db.SubmitChanges();
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Email này đã tồn tại", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccEmail.Clear(); txtAccEmail.Focus();
                }

            }
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            var acc = db.Accounts.SingleOrDefault(x => x.Id == Convert.ToInt32(txtId.Text));
            if (acc.AccLevel <2)
            {
                acc.AccLevel += 1;
                db.SubmitChanges();
                LoadAccount();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var acc = db.Accounts.SingleOrDefault(x => x.Id == Convert.ToInt32(txtId.Text));
            acc.AccLevel = 0;
            db.SubmitChanges();
            LoadAccount();
        }
    }
}
