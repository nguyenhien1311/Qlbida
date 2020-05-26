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

        BidaDataContext bida;
        BidaTable tb;
        DateTime startTime, endTime;


        public frmTable()
        {
            InitializeComponent();
            bida = new BidaDataContext();
            btnUpdateTable.Enabled = false;
            btnStartTime.Enabled = false;
            btnEndTime.Enabled = false;
            btnAddService.Enabled = false;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
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

        BidaTable TableDetails(int id)
        {
            tb = bida.BidaTables.SingleOrDefault(x => x.TableId == id);
            txtTableName.Text = tb.TableName;
            txtTablePrice.Text = tb.Price.ToString();
            if (tb.PlayTime > 0)
            {
                btnStartTime.Enabled = false;
            }
            return tb;
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.RoyalBlue;
            var table = btn.Tag as BidaTable;
            int id = table.TableId;
            txtTiming.Text = TimeSpan.FromSeconds(0).ToString();
            btnUpdateTable.Enabled = true;
            btnStartTime.Enabled = true;
            btnEndTime.Enabled = true;
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
            frmUpdateTable frm = new frmUpdateTable();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnEndTime_Click(object sender, EventArgs e)
        {
            countingPlayTime.Stop();
            endTime = DateTime.Now;
            MessageBox.Show(startTime.ToString() + Environment.NewLine + endTime.ToString());
            frmChoosePay frm = new frmChoosePay();
            frm.Show();
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            if (tb.PlayTime == 0)
            {
                countingPlayTime.Start();
            }
        }


        private void countingPlayTime_Tick(object sender, EventArgs e)
        {
            tb.PlayTime++;
            txtTiming.Text = TimeSpan.FromSeconds((double)tb.PlayTime).ToString();
        }
    }
}
