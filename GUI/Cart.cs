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
using DAL;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Cart : Form
    {
        private static Cart instance;
        private IDictionary<string, int> listItem = new Dictionary<string, int>();
        private int totalPrice = 0;
        public static Cart Instance
        {
            get { if (instance == null) instance = new Cart (); return instance; }
            set { Cart.instance = value; }
        }

        public IDictionary<string, int> ListItem { get => listItem; set => listItem = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Cart(IDictionary<string, int> listItem)
        {
            InitializeComponent();
            Instance = this;
            ListItem = listItem;
            loadCart();
        }

        private Cart(){
        }

        public void loadCart()
        {
            int i = 1;
            CultureInfo ci = new CultureInfo("vi-VN");
            foreach (KeyValuePair<string, int> item in listItem)
            {
                Medicine med = MedicineDAL.Instance.loadMedicineByMdcId(item.Key);
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(med.MdcId);
                lvItem.SubItems.Add(med.Name);
                lvItem.SubItems.Add(item.Value.ToString());
                lvItem.SubItems.Add(med.Price.ToString("c",ci));
                int price = item.Value * med.Price;
                TotalPrice += price;
                lvItem.SubItems.Add(price.ToString("c", ci));
                lvCart.Items.Add(lvItem);
                i++;
            }
            tbTotalPrice.Text = TotalPrice.ToString("c", ci); 
        }

        private void lvCart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string mdcId = lvCart.SelectedItems[0].SubItems[1].Text;
            Medicine med = MedicineDAL.Instance.loadMedicineByMdcId(mdcId);
            CartDetail cartDetail = new CartDetail(med, Instance.listItem[med.MdcId]);
            this.Hide();
            cartDetail.ShowDialog();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> item in listItem)
            {
                MedicineDAL.Instance.updateQuantity(item.Key, item.Value);
            }
            Customer.Cart.Clear();
            Customer.Instance.loadCart();
            Customer.Instance.loadMedicine();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CreateTrans createTrans = new CreateTrans();
            createTrans.ShowDialog();
            
        }
    }
}
