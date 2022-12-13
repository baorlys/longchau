using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemCart
    {
        private string mdcId;
        private int quantity;

        public ItemCart(string mdcId, int quantity)
        {
            this.MdcId = mdcId;
            this.Quantity = quantity;
        }

        public string MdcId { get => mdcId; set => mdcId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
