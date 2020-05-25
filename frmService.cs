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

        private void LoadSvCat() {
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
                txtServiceName.Text = row.Cells[1].Value.ToString();
                txtServicePrice.Text = row.Cells[5].Value.ToString();
                nmrQuantity.Value = (int) row.Cells[4].Value;
                cbxServiceCategory.SelectedValue = row.Cells[2].Value.ToString();
            }
        }

        private void dgvService_SelectionChanged(object sender, EventArgs e)
        {
            DetailsService();
        }
    }
}
