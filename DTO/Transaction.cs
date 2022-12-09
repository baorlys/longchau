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
        private string transType = null;
        private DateTime transDate;
        private int totalPrice = 0;
        private int brandId = 0;
        private int expressState = 0;
        private int state = 0;

        public Transaction(int transId, int userId,string transType, DateTime transDate, int totalPrice, int brandId, int expressState, int state)
        {
            this.TransId = transId;
            this.UserId = userId;
            this.TransType = transType;
            this.TransDate = transDate;
            this.TotalPrice = totalPrice;
            this.BrandId = brandId;
            this.ExpressState = expressState;
            this.State = state;
        }

        public Transaction(DataRow row)
        {
            this.TransId = (int)row["transId"];
            this.UserId = (int)row["userId"];
            if (row["transType"] != null)
            {
                this.TransType = row["transType"].ToString();
            }
            this.TransDate = Convert.ToDateTime(row["transDate"]); ;
            this.TotalPrice = (int)row["totalPrice"]; ;
            this.BrandId = (int)row["brandId"]; ;
            this.ExpressState = (int)row["expressState"]; ;
            this.State = (int)row["state"]; ;
        }

        public int TransId { get => transId; set => transId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string TransType { get => transType; set => transType = value; }
        public DateTime TransDate { get => transDate; set => transDate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int BrandId { get => brandId; set => brandId = value; }
        public int ExpressState { get => expressState; set => expressState = value; }
        public int State { get => state; set => state = value; }
    }
}
