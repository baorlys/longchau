using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Revenue
    {
        private int transId;
        private int userId;
        private int totalPrice;

        public Revenue(DataRow row)
        {
            this.TransId = (int)row["transId"];
            this.UserId = (int)row["userId"];
            this.TotalPrice = (int)row["totalPrice"];
        }
        public int TransId { get => transId; set => transId = value; }
        public int UserId { get => userId; set => userId = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
