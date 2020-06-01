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
    public partial class frmAddService : Form
    {
        private BidaDataContext db;
        public List<TableService> services { get; set; }


        public frmAddService()
        {
            InitializeComponent();
            db = new BidaDataContext();
            services = new List<TableService>();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            LoadService();
            LoadSVAdded();
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvService.CurrentRow != null)
            {
                var row = dgvService.CurrentRow;
                int id = (int)row.Cells[0].Value;
                var sv = db.TableServices.SingleOrDefault(x => x.SvId == id);
                sv.Quantity = (int)mnrQuantity.Value;
                if (!services.Any(x => x.SvId == id))
                {
                    services.Add(sv);
                }
                else
                {
                    services.SingleOrDefault(x => x.SvId == id).Quantity += sv.Quantity;
                }
                var serv = db.TableServices.SingleOrDefault(x => x.SvId == id);
                serv.Quantity -= (int)mnrQuantity.Value;
                db.SubmitChanges();
                LoadService();
                LoadSVAdded();
            }
        }

        void LoadSVAdded()
        {
            dgvServiceAdded.Rows.Clear();
            foreach (var item in services)
            {
                dgvServiceAdded.Rows.Add(new object[] { item.SvId, item.SvName, item.Quantity });
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServiceAdded.CurrentRow != null)
            {
                var row = dgvServiceAdded.CurrentRow;
                int id = (int)row.Cells[0].Value;
                var sv = db.TableServices.SingleOrDefault(x => x.SvId == id);
                var svAdded = services.SingleOrDefault(x => x.SvId == id);
                sv.Quantity += svAdded.Quantity;
                services.RemoveAll(x => x.SvId == id);
                LoadService();
                LoadSVAdded();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
