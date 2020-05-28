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

        public frmTable()
        {
            InitializeComponent();
            bida = new BidaDataContext();
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
                        btn.BackColor = Color.LimeGreen;
                        break;
                    default:
                        btn.BackColor = Color.OrangeRed;
                        break;
                }
                btn.Text = table.Name + Environment.NewLine + Environment.NewLine + table.CatName + Environment.NewLine + Environment.NewLine + status;
                flpTableList.Controls.Add(btn);
            }

        }

        void TableDetails(int id)
        {
            tb = bida.BidaTables.SingleOrDefault(x => x.TableId == id);
            txtTableName.Text = tb.TableName;
            txtTablePrice.Text = tb.Price.ToString();
            txtTiming.Text = (DateTime.Now - tb.StartTime).ToString();
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.RoyalBlue;
            var table = btn.Tag as BidaTable;
            id = table.TableId;
            btnUpdateTable.Enabled = true;
            btnStartTime.Enabled = true;
            btnAddService.Enabled = true;
            TableDetails(id);
        }

        void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LimeGreen;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddService frm = new frmAddService();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
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
        }

        private void btnEndTime_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tb.EndTime = DateTime.Now;
            MessageBox.Show(tb.StartTime.ToString() + Environment.NewLine + tb.EndTime.ToString());
            frmChoosePay frm = new frmChoosePay();
            frm.Show();
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            btnStartTime.Enabled = false;
            btnEndTime.Enabled = true;
            tb.StartTime = DateTime.Now;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now - tb.StartTime;
            txtTiming.Text = time.ToString();
        }
    }
}
