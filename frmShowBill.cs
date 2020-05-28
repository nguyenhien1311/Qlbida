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
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBill_Load(object sender, EventArgs e)
        {
            LoadDetails();
            LoadServices();
        }

        void LoadDetails()
        {
            int discount = 0;
            var tb = db.BidaTables.SingleOrDefault(x => x.TableId == ord.TableId);
            lblTableName.Text = tb.TableName;
            lblEndTime.Text = ord.EndTime.ToString();
            lblStartTime.Text = ord.StartTime.ToString();
            double time = (double)(ord.PlayTime / 60);
            lblTotalTime.Text = time.ToString();
            lblSurchagre.Text = ord.Surcharge.ToString();
            double price = time * (double)tb.Price;
            lblCaculatePrice.Text = time + " X " + tb.Price + " = " + price;
            lblPricePlay.Text = price.ToString();
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
            double total = (double)((price + ord.Surcharge) * discount / 100);
            lblTotalPrice.Text = total.ToString();
        }

        void LoadServices() {
            var data = from dt in db.OrdDetails
                       where dt.OrderId == ord.OrderId
                       select dt;
            dgvService.DataSource = data;
        }
    }
}
