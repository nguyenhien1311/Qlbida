using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlBida
{
    public partial class frmCustomer : Form
    {
        private bool edit = true;
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
                txtId.Text = row.Cells[0].Value.ToString();
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtCusAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtLevel.Text = row.Cells[4].Value.ToString();
                edit = true;
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            CustomerDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            txtId.Text = txtCusName.Text = txtCusAddress.Text = txtPhone.Text = txtLevel.Text = "";
            txtLevel.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var cus = db.Customers.SingleOrDefault(x => x.CusId == Convert.ToInt32(txtId.Text));
                cus.CusName = txtCusName.Text;
                cus.CusAddress = txtCusAddress.Text;
                cus.CusPhone = txtPhone.Text;
                db.SubmitChanges();
                LoadCustomer();
            }
            else
            {
                Customer cus = new Customer();
                cus.CusName = txtCusName.Text;
                cus.CusAddress = txtCusAddress.Text;
                cus.CusPhone = txtPhone.Text;
                cus.CusLevel = 0;
                db.Customers.InsertOnSubmit(cus);
                db.SubmitChanges();
                LoadCustomer();
            }
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            var cus = db.Customers.SingleOrDefault(x => x.CusId == Convert.ToInt32(txtId.Text));
            cus.CusLevel += 1;
            db.SubmitChanges();
            LoadCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cus = db.Customers.SingleOrDefault(x => x.CusId == Convert.ToInt32(txtId.Text));
            db.Customers.DeleteOnSubmit(cus);
            db.SubmitChanges();
            LoadCustomer();
        }
    }
}
