using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CartDetail : Form
    {
        private static CartDetail instance;
        private Medicine med;
        private int quantityBuy;
        public static CartDetail Instance
        {
            get { if (instance == null) instance = new CartDetail(); return instance; }
            set { CartDetail.instance = value; }
        }

        public Medicine Med { get => med; set => med = value; }
        public int QuantityBuy { get => quantityBuy; set => quantityBuy = value; }

        public CartDetail(Medicine med, int quantity)
        {
            InitializeComponent();
            Instance = this;
            Instance.Med = med;
            Instance.QuantityBuy = quantity;
            nudQuantityBuy.Maximum = med.Quantity + quantity;
            loadData();
        }

        private CartDetail() { }

        void loadData()
        {
            tbName.Text = med.Name;
            nudQuantityBuy.Value = Instance.QuantityBuy;
            tbQuantity.Text = med.Quantity.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int diff = Instance.QuantityBuy - (int)nudQuantityBuy.Value;
            MedicineDAL.Instance.updateQuantity(med.MdcId, diff);
            Customer.Cart.Remove(med.MdcId);
            Customer.Cart[med.MdcId] = (int)nudQuantityBuy.Value;
            if (nudQuantityBuy.Value == 0) Customer.Cart.Remove(med.MdcId);
            Customer.Instance.loadCart();
            Customer.Instance.loadMedicine();
            this.Hide();
            if(Customer.Cart.Count == 0)
            {
                return;
            }
            Cart cart = new Cart(Customer.Cart);
            cart.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart(Customer.Cart);
            cart.ShowDialog();
        }
    }
}
