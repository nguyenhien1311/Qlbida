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

        BidaDataContext bida = new BidaDataContext();

        public frmTable()
        {
            InitializeComponent();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {

            foreach (var table in bida.BidaTables)
            {
                string status;
                Button btn = new Button() { Width = 120, Height = 120 };
                if (table.TableStatus == 1)
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
                btn.Text = table.TableName + Environment.NewLine + Environment.NewLine + status;
                flpTableList.Controls.Add(btn);
            }

        }
    }
}
