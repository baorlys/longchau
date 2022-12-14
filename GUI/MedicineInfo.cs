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
            Instance = this;
            Instance.Med = med;
            nudQuantity.Maximum = med.Quantity;
            if (med.Quantity == 0) btnAddCart.Enabled = false;
            loadMedInfo();
        }

        void loadMedInfo()
        {
            tbName.Text = med.Name;
            CultureInfo ci = new CultureInfo("vi-VN");
            tbPrice.Text = med.Price.ToString("c",ci);
            tbQuantity.Text = med.Quantity.ToString();
            tbType.Text = med.Type;
            rtbDesc.Text = med.Description;
            MemoryStream ms = new MemoryStream(med.Img);
            Bitmap bmp = new Bitmap(ms);
            pbMed.Width = 250;
            pbMed.Height = 250;
            pbMed.BackgroundImageLayout = ImageLayout.Stretch;
            pbMed.BackgroundImage = bmp;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudQuantity.Value;
            MedicineDAL.Instance.updateQuantity(med.MdcId, -quantity);
            if (Customer.Cart.ContainsKey(med.MdcId))
            {
                Customer.Cart[med.MdcId] += quantity;
            }
            else Customer.Cart[med.MdcId] = quantity;
            Instance.Med.Quantity = med.Quantity - quantity;
            if (Instance.Med.Quantity == 0) btnAddCart.Enabled = false;
            Customer.Instance.loadCart();
            Customer.Instance.loadMedicine();
            loadMedInfo();
            MessageBox.Show("đã thêm " + quantity + " sản phẩm vào giỏ hàng");
            this.Hide();
        }
    }
}
