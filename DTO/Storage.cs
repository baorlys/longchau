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
        private int quantity = 0;
        private DateTime dateExpire;
        private int status = 0;

        public Storage(string storageId, string importId, int quantity, DateTime dateExpire, int status)
        {
            this.StorageId = storageId;
            this.ImportId = importId;
            this.Quantity = quantity;
            this.DateExpire = dateExpire;
            this.Status = status;
        }

        public Storage(DataRow row)
        {
            this.StorageId = row["storageId"].ToString();
            this.ImportId = row["importId"].ToString();
            this.Quantity = (int)row["quantity"];
            this.DateExpire = Convert.ToDateTime(row["dateExpire"]);
            this.Status = (int)row["status"];
        }

        public string StorageId { get => storageId; set => storageId = value; }
        public string ImportId { get => importId; set => importId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public int Status { get => status; set => status = value; }
    }
}
