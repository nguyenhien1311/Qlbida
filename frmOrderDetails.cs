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
    public partial class frmOrderDetails : Form
    {

        private BidaDataContext db;
        private OrderTable ord;
        public frmOrderDetails(OrderTable order)
        {
            InitializeComponent();
            db = new BidaDataContext();
            ord = order;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadDetails();
        }
        void LoadDetails()
        {
            var details = from dt in db.OrdDetails
                          join sv in db.TableServices on dt.SvId equals sv.SvId
                          where dt.OrderId == ord.OrderId
                          select new
                          {
                              SvId = dt.SvId,
                              SvName = sv.SvName,
                              Quantity = dt.Quantity,
                              Price = dt.Price
                          };
            dgvDetails.DataSource = details;
        }

        void LoadInfo()
        {
            var data = from o in db.OrderTables
                       join c in db.Customers on o.CusId equals c.CusId
                       join tb in db.BidaTables on o.TableId equals tb.TableId
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
            var thisOrd = data.SingleOrDefault(x => x.OrderId == ord.OrderId);
            if (thisOrd.CusName != null)
            {
                txtCusName.Text = thisOrd.CusName;
            }
            else
            {
                txtCusName.Text = "";
            }
            txtTableName.Text = thisOrd.TableName;
            txtTotalPrice.Text = thisOrd.Price.ToString();
            txtSurcharge.Text = thisOrd.Surcharge.ToString();
            txtPlayingTime.Text = thisOrd.PlayTime.ToString();
        }

    }
}
