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
        private BidaDataContext db;

        public frmReport()
        {
            InitializeComponent();
            db = new BidaDataContext();
            btnOrderDetails.Enabled = false;
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            var row = dgvOrderList.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var order = db.OrderTables.SingleOrDefault(x => x.OrderId == id);
            frmOrderDetails frm = new frmOrderDetails(order);
            frm.Show();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            var data = from o in db.OrderTables
                       join c in db.Customers on o.CusId equals c.CusId
                       join tb in db.BidaTables on o.TableId equals tb.TableId
                       where o.OrdStatus == 0
                       select new
                       {
                           OrderId = o.OrderId,
                           CusId = o.CusId,
                           CusName = c.CusName,
                           TableId = o.TableId,
                           TableName = tb.TableName,
                           StartTime = o.StartTime,
                           EndTime = o.EndTime,
                           PlayTime = o.PlayTime,
                           Surcharge = o.Surcharge,
                           Price = o.Price,
                           OrdStatus = o.OrdStatus
                       };
            dgvOrderList.DataSource = data;
        }
    }
}
