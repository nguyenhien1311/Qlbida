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
    public partial class frmTable : Form
    {
        private int id;
        BidaDataContext bida;
        BidaTable tb;
        Timer timer;
        Color c;
        OrderTable order;
        public List<TableService> lstSv;

        public frmTable()
        {
            InitializeComponent();
            bida = new BidaDataContext();
            lstSv = new List<TableService>();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            btnUpdateTable.Enabled = false;
            btnStartTime.Enabled = false;
            btnEndTime.Enabled = false;
            btnAddService.Enabled = false;
            btnEndTime.Enabled = false;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {

            bida = new BidaDataContext();
            flpTableList.Controls.Clear();
            var lstTable = from t in bida.BidaTables
                           join c in bida.TableCategories
                           on t.TableCatID equals c.TableCatId
                           select new
                           {
                               Id = t.TableId,
                               Name = t.TableName,
                               CatName = c.TableCatName,
                               Status = t.TableStatus
                           };
            //tạo button as bàn
            foreach (var table in lstTable)
            {
                BidaTable bidaTable = bida.BidaTables.SingleOrDefault(x => x.TableId == table.Id);
                string status;
                Button btn = new Button() { Width = 120, Height = 120 };
                btn.Click += btn_Click;
                btn.Leave += btn_Leave;
                btn.Tag = bidaTable;
                if (table.Status == 1)
                {
                    status = "Trống";
                }
                else
                {
                    status = "Đang chơi";
                }
                switch (status)
                {
                    case "Trống":
                        c = btn.BackColor = Color.LimeGreen;
                        break;
                    default:
                        c = btn.BackColor = Color.OrangeRed;
                        break;
                }
                btn.Text = table.Name + Environment.NewLine + Environment.NewLine + table.CatName + Environment.NewLine + Environment.NewLine + status;
                //thêm btn vào flpanel
                flpTableList.Controls.Add(btn);
            }
        }

        void TableDetails(int id)
        {
            tb = bida.BidaTables.SingleOrDefault(x => x.TableId == id);
            txtTableName.Text = tb.TableName;
            txtTablePrice.Text = tb.Price.ToString();
            txtTiming.Text = TimeSpan.FromMinutes(Convert.ToDouble(tb.PlayTime)).ToString();
            if (tb.StartTime != null)
            {
                timer.Start();
                btnEndTime.Enabled = true;
            }

        }

        void LoadOrderOfTb(int id)
        {
            var thisTbOrd = bida.OrderTables.SingleOrDefault(x => x.TableId == id && x.OrdStatus == 0);
            if (thisTbOrd != null)
            {
                order = thisTbOrd;
                txtSurcharge.Text = thisTbOrd.Surcharge.ToString();
                var lstDetails = bida.OrdDetails.Where(x => x.OrderId == thisTbOrd.OrderId).ToList();
                if (lstDetails != null)
                {
                    dgvSerive.Rows.Clear();
                    foreach (var svitem in lstSv)
                    {
                        dgvSerive.Rows.Add(new object[] { svitem.SvId, svitem.SvName, svitem.Quantity });
                    }
                }
            }
        }


        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            c = btn.BackColor;
            btn.BackColor = Color.RoyalBlue;
            var table = btn.Tag as BidaTable;
            id = table.TableId;
            btnUpdateTable.Enabled = true;
            btnStartTime.Enabled = true;
            btnAddService.Enabled = true;
            TableDetails(id);
            LoadOrderOfTb(id);
        }

        void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = c;
            dgvSerive.Rows.Clear();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddService frm = new frmAddService();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.services = lstSv;
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                lstSv = frm.services;
            }
            var thisTbOrd = bida.OrderTables.FirstOrDefault(x => x.TableId == tb.TableId && x.OrdStatus == 0);
            if (thisTbOrd != null)
            {
                foreach (var item in lstSv)
                {
                    OrdDetail detail = new OrdDetail()
                    {
                        OrderId = thisTbOrd.OrderId,
                        SvId = item.SvId,
                        Quantity = item.Quantity,
                        Price = (item.Quantity * item.Price)
                    };
                    bida.OrdDetails.InsertOnSubmit(detail);
                }
                bida.SubmitChanges();
            }
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            frmNewTable frm = new frmNewTable();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            frmUpdateTable frm = new frmUpdateTable(tb);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTable();
            dgvSerive.Rows.Clear();
        }

        private void btnEndTime_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tb.EndTime = DateTime.Now;
            var ord = bida.OrderTables.FirstOrDefault(x => x.OrderId == order.OrderId);
            ord.EndTime = tb.EndTime;
            if (tb.PlayTime == null)
            {
                ord.PlayTime = 1;
            }
            else
            {
                ord.PlayTime = tb.PlayTime;
            }
            if (txtSurcharge.Text != "")
            {

                ord.Surcharge = Convert.ToDouble(txtSurcharge.Text);
            }
            else
            {
                ord.Surcharge = 0;
            }
            ord.OrdStatus = 1;
            bida.SubmitChanges();
            var table = bida.BidaTables.SingleOrDefault(x => x.TableId == id);
            table.StartTime = null;
            table.EndTime = null;
            table.StartTime = null;
            table.PlayTime = null;
            table.TableStatus = 1;
            bida.SubmitChanges();
            LoadTable();
            frmChoosePay frm = new frmChoosePay(order);
            frm.Show();
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            btnStartTime.Enabled = false;
            btnEndTime.Enabled = true;
            var table = bida.BidaTables.SingleOrDefault(x => x.TableId == id);
            table.StartTime = DateTime.Now;
            timer.Start();
            table.TableStatus = 0;
            bida.SubmitChanges();
            order = new OrderTable();
            order.TableId = table.TableId;
            order.StartTime = table.StartTime;
            order.OrdStatus = 0;
            bida.OrderTables.InsertOnSubmit(order);
            bida.SubmitChanges();
            LoadTable();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (tb.StartTime != null)
            {
                if (tb.PlayTime == null)
                {
                    btnStartTime.Enabled = false;
                    TimeSpan time = (TimeSpan)(DateTime.Now - tb.StartTime);

                    if (time != null)
                    {
                        if (time.TotalMinutes >= 1)
                        {
                            tb.PlayTime = (int)time.TotalMinutes;
                            bida.SubmitChanges();
                        }
                        txtTiming.Text = TimeSpan.FromMinutes(time.TotalMinutes).ToString();
                    }
                    else
                    {
                        txtTiming.Text = TimeSpan.FromMinutes(0.0).ToString();
                    }
                }
                else
                {
                    btnStartTime.Enabled = false;
                    TimeSpan time = (TimeSpan)(DateTime.Now - tb.StartTime);
                    if (time != null)
                    {
                        double ptime = (double)tb.PlayTime;
                        if (time.TotalMinutes >= 1)
                        {
                            tb.PlayTime = (int)time.TotalMinutes;
                            bida.SubmitChanges();
                        }
                        txtTiming.Text = TimeSpan.FromMinutes(time.TotalMinutes + ptime).ToString();
                    }
                    else
                    {
                        txtTiming.Text = TimeSpan.FromMinutes(0.0).ToString();
                    }
                }
            }
            else
            {
                txtTiming.Text = TimeSpan.FromMinutes(0.0).ToString();
            }

        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            frmChangeTable frm = new frmChangeTable(tb);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadTable();
            }
        }

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            if (order != null)
            {
                if (!String.IsNullOrEmpty(txtSurcharge.Text) || !String.IsNullOrWhiteSpace(txtSurcharge.Text))
                {
                    order.Surcharge = Convert.ToInt32(txtSurcharge.Text);
                    bida.SubmitChanges();
                }
            }
        }
    }
}
