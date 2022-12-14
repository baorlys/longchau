using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Import
    {
        private string importId;
        private DateTime requestDate;
        private string mdcId;
        private string name;
        private int quantity=0;
        private DateTime dateExpire;
        private int status=0;

        public Import(string importId, DateTime requestDate, string mdcId, string name, int quantity, DateTime dateExpire, int status)
        {
            this.ImportId = importId;
            this.RequestDate = requestDate;
            this.MdcId = mdcId;
            this.Name = name;
            this.Quantity = quantity;
            this.DateExpire = dateExpire;
            this.Status = status;
        }

        public Import(DataRow row)
        {
            this.ImportId = row["importId"].ToString();
            this.RequestDate = Convert.ToDateTime(row["requestDate"]);
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.Quantity = (int)row["quantity"];
            this.DateExpire = Convert.ToDateTime(row["dateExpire"]);
            this.Status = (int)row["status"];
        }

        public string ImportId { get => importId; set => importId = value; }
        public DateTime RequestDate { get => requestDate; set => requestDate = value; }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public int Status { get => status; set => status = value; }
    }
}
