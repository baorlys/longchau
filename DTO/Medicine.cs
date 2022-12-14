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
        private string categoryName;
        private DateTime dateExpire;
        private string labelerName;
        private string description;
        private int price;
        private int quantity;
        private byte[] img;

        public Medicine(DataRow row)
        {
            this.MdcId = row["mdcId"].ToString();
            this.Name = row["name"].ToString();
            this.Type = row["type"].ToString();
            this.CategoryId = (int)row["categoryId"];
            this.CategoryName = row["categoryName"].ToString();
            this.dateExpire = Convert.ToDateTime(row["dateExpire"]);
            this.LabelerName = row["labelerName"].ToString();
            this.Description = row["description"].ToString();
            this.Price = (int)row["price"];
            this.Quantity = (int)row["quantity"];
            this.Img = (byte[])row["img"];
        }

       

        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public string LabelerName { get => labelerName; set => labelerName = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public byte[] Img { get => img; set => img = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
