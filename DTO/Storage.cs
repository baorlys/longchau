using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Storage
    {
        private string storageId;
        private string importId;
        private string mdcId;
        private string name;
        private int quantity = 0;
        private DateTime dateExpire;
        private int status = 0;

        public Storage(string storageId, string importId, string mdcId, string name, int quantity, DateTime dateExpire, int status)
        {
            this.storageId = storageId;
            this.importId = importId;
            this.mdcId = mdcId;
            this.name = name;
            this.quantity = quantity;
            this.dateExpire = dateExpire;
            this.status = status;
        }

        public Storage(DataRow row)
        {
            this.storageId = row["storageId"].ToString();
            this.importId = row["importId"].ToString();
            this.mdcId = row["mdcId"].ToString();
            this.name = row["name"].ToString();
            this.quantity = (int)row["quantity"];
            this.dateExpire = (DateTime)row["dateExpire"];
            this.status = (int)row["status"];
        }

        public string StorageId { get => storageId; set => storageId = value; }
        public string ImportId { get => importId; set => importId = value; }
        public string MdcId { get => mdcId; set => mdcId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public int Status { get => status; set => status = value; }
    }
}
