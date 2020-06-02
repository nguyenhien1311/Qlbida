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
    public partial class frmChangeTable : Form
    {
        BidaDataContext db;
        BidaTable tb;

        public frmChangeTable(BidaTable table)
        {
            InitializeComponent();
            db = new BidaDataContext();
            tb = table;
        }

        private void frmChangeTable_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        void LoadTable()
        {
            var data = from t in db.BidaTables
                       where t.TableStatus == 1
                       select t;
            cbxTable.DataSource = data;
            cbxTable.DisplayMember = "TableName";
            cbxTable.ValueMember = "TableId";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var thisTbOrd = db.OrderTables.SingleOrDefault(x => x.TableId == tb.TableId);
            if (thisTbOrd != null)
            {
                int id = (cbxTable.SelectedItem as BidaTable).TableId;
                var tbChange = db.BidaTables.SingleOrDefault(x => x.TableId == id);
                tbChange.StartTime = tb.StartTime;
                tbChange.PlayTime = tb.PlayTime;
                tbChange.TableStatus = 0;
                db.SubmitChanges();
                thisTbOrd.TableId = tbChange.TableId;
                db.SubmitChanges();
                var table = db.BidaTables.SingleOrDefault(x => x.TableId == tb.TableId);
                table.PlayTime = null;
                table.StartTime = null;
                table.TableStatus = 1;
                db.SubmitChanges();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
