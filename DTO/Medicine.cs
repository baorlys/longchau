using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Medicine
    {
        private string mdcId;
        private string name;
        private string dosageForm;
        private int price;
        private DateTime startDate;
        private DateTime dateExpire;
        private string labelerName;
        private int quantity;

        public Medicine(DataRow row)
        {
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.DosageForm = row["dosageForm"].ToString();
            this.Price = (int)row["price"];
            this.StartDate = Convert.ToDateTime(row["startDate"]);
            this.DateExpire = Convert.ToDateTime(row["dateExpire"]);
            this.LabelerName = row["labelerName"].ToString();
            this.Quantity = (int)row["quantity"];
        }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public string DosageForm { get => dosageForm; set => dosageForm = value; }
        public int Price { get => price; set => price = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public string LabelerName { get => labelerName; set => labelerName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
