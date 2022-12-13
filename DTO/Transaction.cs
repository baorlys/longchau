using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Transaction
    {
        private int transId;
        private int userId;
        private int name;
        private DateTime transDate;
        private int totalPrice = 0;
        private int brandId = 0;
        private string brandName;
        private int expressState = 0;
        private int state = 0;

        public Transaction(DataRow row)
        {
            this.TransId = (int)row["transId"];
            this.UserId = (int)row["userId"];
            this.Name = (int)row["name"];
            this.TransDate = Convert.ToDateTime(row["transDate"]); ;
            this.TotalPrice = (int)row["totalPrice"]; ;
            this.BrandId = (int)row["brandId"]; ;
            this.BrandName = row["brandName"].ToString();
            this.ExpressState = (int)row["expressState"]; ;
            this.State = (int)row["state"]; ;
        }

        public int TransId { get => transId; set => transId = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Name { get => name; set => name = value; }
        public DateTime TransDate { get => transDate; set => transDate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int BrandId { get => brandId; set => brandId = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public int ExpressState { get => expressState; set => expressState = value; }
        public int State { get => state; set => state = value; }
    }
}
