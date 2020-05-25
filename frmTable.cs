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
                BidaTable bidaTable = bida.BidaTables.SingleOrDefault(x=>x.TableId == table.Id);
                string status;
                Button btn = new Button() { Width = 120, Height = 120 };
                btn.Click += btn_Click;
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
                btn.Text = table.Name + Environment.NewLine + Environment.NewLine +table.CatName+ Environment.NewLine + Environment.NewLine + status;
                flpTableList.Controls.Add(btn);
            }

        }

        void TableDetails(int id) { 
            
        }

        void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            var table = btn.Tag as BidaTable;
            int id = table.TableId;
            txtTableName.Text = table.TableName;
            txtTablePrice.Text = table.Price.ToString();
            btnUpdateTable.Enabled = true;
            btnStartTime.Enabled = true;
            btnEndTime.Enabled = true;
            btnAddService.Enabled = true;
            TableDetails(id);
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
            frmChoosePay frm = new frmChoosePay();
            frm.Show();
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            countingPlayTime.Start();
            LoadTable();
        }

        private int minute = 0;

        private void countingPlayTime_Tick(object sender, EventArgs e)
        {
            minute++;
            txtTiming.Text = minute.ToString();
        }
    }
}
