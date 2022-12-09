using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TransactionDetail
    {

        private int transId;
        private string mdcId;
        private int quantity;
        private string name;
        public TransactionDetail(int transId, string mdcId, string name, int quantity)
        {
            this.TransId = transId;
            this.MdcId = mdcId;
            this.Name = name;
            this.Quantity = quantity;
        }

        public TransactionDetail(DataRow row)
        {
            this.TransId = (int)row["transId"];
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.Quantity = (int)row["quantity"];
        }

        public int TransId { get => transId; set => transId = value; }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
    }
}
