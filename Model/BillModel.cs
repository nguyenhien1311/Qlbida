using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlBida.Model
{
    class BillModel
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PlayTime  { get; set; }
        public double SurCharge { get; set; }
        public double TotalPrice { get; set; }
    }
}
