using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MedicineInfo : Form
    {
        private static MedicineInfo instance;

        private Medicine med;

        public Medicine Med
        {
            get { return med; }
            set { med = value; }
        }

        public static MedicineInfo Instance { get => instance; set => instance = value; }

        public MedicineInfo(Medicine med)
        {
            InitializeComponent();
            nudQuantity.Maximum = med.Quantity;
            Instance = this;
            this.Med = med;
            loadMedInfo();
        }

        void loadMedInfo()
        {
            tbName.Text = med.Name;
            CultureInfo ci = new CultureInfo("vi-VN");
            tbPrice.Text = med.Price.ToString("c",ci);
            tbQuantity.Text = med.Quantity.ToString();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudQuantity.Value;
            if (Customer.Cart.ContainsKey(med.MdcId))
            {
                Customer.Cart[med.MdcId] += quantity;
            }
            else Customer.Cart[med.MdcId] = quantity;
            Customer.Instance.loadCart();
            MessageBox.Show("đã thêm " + quantity + " sản phẩm vào giỏ hàng");
        }
    }
}
