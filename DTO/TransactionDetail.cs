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
        private string name;
        private int quantity;
        private int price;


        public TransactionDetail(DataRow row)
        {
            this.TransId = (int)row["transId"];
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = (int)row["price"];
        }

        public int TransId { get => transId; set => transId = value; }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
}
