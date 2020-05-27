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

        public frmAddService()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            LoadService();
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
    }
}
