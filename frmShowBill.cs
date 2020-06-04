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
    public partial class frmShowBill : Form
    {
        BidaDataContext db;
        OrderTable ord;
        Customer cus;
        double totalSvPrice = 0;
        double afterDiscount = 0;
        int discount = 0;
        double total = 0;
        double time = 0;
        double price;
        BidaTable tb;
        public frmShowBill(Customer customer, OrderTable order)
        {
            InitializeComponent();
            db = new BidaDataContext();
            ord = order;
            cus = customer;
        }

        public frmShowBill(OrderTable order)
        {
            InitializeComponent();
            db = new BidaDataContext();
            ord = order;
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            var o = db.OrderTables.SingleOrDefault(x => x.OrderId == ord.OrderId);
            if (cus != null)
            {
                o.CusId = cus.CusId;
            }
            o.Price = afterDiscount;
            db.SubmitChanges();
            MessageBox.Show("Thanh toán thành công","Thanh toán",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void frmShowBill_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadDetails();
        }

        void LoadDetails()
        {
            var order = db.OrderTables.SingleOrDefault(x=>x.OrderId == ord.OrderId);
            tb = db.BidaTables.SingleOrDefault(x => x.TableId == ord.TableId);
            if (tb.PlayTime  == null)
            {
                time = 1;
            }
            else
            {
                time = (double)(order.PlayTime / 60);
            }
            
            price = time * (double)tb.Price;
            if (cus != null)
            {
                if (cus.CusLevel == 3)
                {
                    lblDiscount.Text = "20%";
                    discount = 20;
                }
                if (cus.CusLevel == 2)
                {
                    lblDiscount.Text = "15%";
                    discount = 15;
                }
                if (cus.CusLevel == 1)
                {
                    lblDiscount.Text = "10%";
                    discount = 10;
                }
                if (cus.CusLevel == 0)
                {
                    lblDiscount.Text = "5%";
                    discount = 5;
                }
            }
            else
            {
                lblDiscount.Text = discount.ToString();
            }
            total = (double)(price + order.Surcharge + totalSvPrice);
            afterDiscount = total - (total * discount / 100);
            lblTableName.Text = tb.TableName;
            lblEndTime.Text = order.EndTime.ToString();
            lblStartTime.Text = order.StartTime.ToString();
            lblTotalTime.Text = time.ToString();
            lblSurchagre.Text = order.Surcharge.ToString();
            lblCaculatePrice.Text = time + " X " + tb.Price + " = " + price;
            lblPricePlay.Text = price.ToString();
            lblTotalPrice.Text = afterDiscount.ToString();
        }

        void LoadServices()
        {
            var data = from dt in db.OrdDetails
                       join sv in db.TableServices on dt.SvId equals sv.SvId
                       where dt.OrderId == ord.OrderId
                       select new
                       {
                           SvId = dt.SvId,
                           SvName = sv.SvName,
                           Quantity = dt.Quantity,
                           Price = dt.Price
                       };
            foreach (var item in data)
            {
                totalSvPrice += (double)item.Price;
            }
            lblServicePrice.Text = totalSvPrice.ToString();
            dgvService.DataSource = data;
        }
    }
}
