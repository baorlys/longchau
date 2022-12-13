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
        private string type;
        private int categoryId;
        private DateTime startDate;
        private string labelerName;
        private string description;
        private int price;
        private int quantity;
        private string img;

        public Medicine(DataRow row)
        {
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.Type = row["type"].ToString();
            this.CategoryId = (int)row["categoryId"];
            this.StartDate = Convert.ToDateTime(row["startDate"]);
            this.LabelerName = row["labelerName"].ToString();
            this.Description = row["description"].ToString();
            this.Price = (int)row["price"];
            this.Quantity = (int)row["quantity"];
            this.Img = row["img"].ToString();
        }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string LabelerName { get => labelerName; set => labelerName = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Img { get => img; set => img = value; }
    }
}
