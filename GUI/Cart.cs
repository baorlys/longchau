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

namespace GUI
{
    public partial class Cart : Form
    {
        private static Cart instance;
        private IDictionary<string, int> listItem = new Dictionary<string, int>();
        public static Cart Instance
        {
            get { if (instance == null) instance = new Cart (); return instance; }
            set { Cart.instance = value; }
        }

        public IDictionary<string, int> ListItem { get => listItem; set => listItem = value; }

        public Cart(IDictionary<string, int> listItem)
        {
            InitializeComponent();
            Instance = this;
            ListItem = listItem;
            loadCart();
        }

        private Cart(){
        }

        void loadCart()
        {
            int i = 1;
            CultureInfo ci = new CultureInfo("vi-VN");
            foreach (KeyValuePair<string, int> item in listItem)
            {
                Medicine med = MedicineDAL.Instance.loadMedicineByMdcId(item.Key);
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(med.Name);
                lvItem.SubItems.Add(item.Value.ToString());
                lvItem.SubItems.Add(med.Price.ToString("c",ci));
                int price = item.Value * med.Price;
                lvItem.SubItems.Add(price.ToString("c", ci));
                lvCart.Items.Add(lvItem);
                i++;
            }
        }

    }
}
