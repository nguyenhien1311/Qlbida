
using QlBida.Model;
using QlBida.ReportTemplate;
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
    public partial class frmViewer : Form
    {
        BidaDataContext db;
        public frmViewer()
        {
            InitializeComponent();
            db = new BidaDataContext();
        }

        private void frmViewer_Load(object sender, EventArgs e)
        {
            rptOrderReport rpt = new rptOrderReport();
            var data = from o in db.OrderTables
                       join tb in db.BidaTables on o.TableId equals tb.TableId
                       where o.OrdStatus == 1
                       select new BillModel
                       {
                           Id = o.OrderId,
                           TableName = tb.TableName,
                           StartTime =(DateTime) o.StartTime,
                           EndTime = (DateTime)o.EndTime,
                           PlayTime =(int) o.PlayTime,
                           SurCharge =(double) o.Surcharge,
                           TotalPrice = (double) o.Price
                       };
            rpt.SetDataSource(data);
            crptViewer.ReportSource = rpt;
            crptViewer.Show();
        }
    }
}
