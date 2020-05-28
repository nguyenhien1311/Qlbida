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
    public partial class frmService : Form
    {
        private bool edit = true;
        private BidaDataContext db;

        public frmService()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            LoadSvCat();
            LoadService();
        }

        private void LoadSvCat()
        {
            var data = from c in db.ServiceCategories
                       select c;
            cbxServiceCategory.DataSource = data;
            cbxServiceCategory.DisplayMember = "SvCatName";
            cbxServiceCategory.ValueMember = "SvCatId";
        }

        private void LoadService()
        {
            var data = from s in db.TableServices
                       join c in db.ServiceCategories on s.SvCatId equals c.SvCatId
                       select new
                       {
                           Id = s.SvId,
                           Name = s.SvName,
                           CatId = s.SvCatId,
                           CatName = c.SvCatName,
                           Quantity = s.Quantity,
                           Price = s.Price
                       };
            dgvService.DataSource = data;
            DetailsService();
        }

        private void DetailsService()
        {
            if (dgvService.CurrentRow != null)
            {
                var row = dgvService.CurrentRow;
                txtSvId.Text = row.Cells[0].Value.ToString();
                txtServiceName.Text = row.Cells[1].Value.ToString();
                nmrQuantity.Value = (int)row.Cells[4].Value;
                txtServicePrice.Text = row.Cells[5].Value.ToString();
                cbxServiceCategory.SelectedValue = row.Cells["CatId"].Value;
                edit = true;
            }
        }

        private void dgvService_SelectionChanged(object sender, EventArgs e)
        {
            DetailsService();
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            edit = false;
            txtServiceName.Text = txtServicePrice.Text = "";
            nmrQuantity.Value = 0;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var svUdt = db.TableServices.SingleOrDefault(x=>x.SvId ==  Convert.ToInt32(txtSvId.Text));
                svUdt.SvName = txtServiceName.Text;
                svUdt.SvCatId = (cbxServiceCategory.SelectedItem as ServiceCategory).SvCatId;
                svUdt.Quantity = (int)nmrQuantity.Value;
                svUdt.Price = Convert.ToDouble(txtServicePrice.Text);
                db.SubmitChanges();
                LoadService();
            }
            else
            {
                TableService sv = new TableService();
                sv.SvName = txtServiceName.Text;
                sv.Price = Convert.ToDouble(txtServicePrice.Text);
                sv.Quantity = (int)nmrQuantity.Value;
                sv.SvCatId = (cbxServiceCategory.SelectedItem as ServiceCategory).SvCatId;
                db.TableServices.InsertOnSubmit(sv);
                db.SubmitChanges();
                LoadService();
            }

        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            frmNewSvCat frm = new frmNewSvCat();
            frm.Show();
        }
    }
}
