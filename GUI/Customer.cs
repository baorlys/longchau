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
    public partial class Customer : Form
    {
        private static Customer instance;
        private User userLogin;
        private static IDictionary<string, int> cart = new Dictionary<string, int>();
        public int quantity = 0;
        

        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        public static Customer Instance
        {
            get { if (instance == null) instance = new Customer(); return instance; }
            set { Customer.instance = value; }
        }

        public static IDictionary<string, int> Cart { get => cart; set => cart = value; }

        private Customer(){}

        public Customer(User userLogin)
        {
            InitializeComponent();
            Instance = this;
            this.userLogin = userLogin;

            xinChàoToolStripMenuItem.Text += " " + userLogin.Name;
            giỏHàngToolStripMenuItem.Text = "Giỏ hàng (" + Cart.Count + ")";
            loadMedicine();
            
        }

        

        #region methods
        void loadMedicine()
        {
            List<Medicine> listMed = MedicineDAL.Instance.loadMedicine();
            CultureInfo ci = new CultureInfo("vi-VN");
            foreach (Medicine med in listMed)
            {
                Button btnMed = new Button() { Width = MedicineDAL.MedWidth, Height = MedicineDAL.MedHeight };
                btnMed.Click += btnMed_Click;
                btnMed.Tag = med;
                btnMed.BackColor = Color.Aqua;
                btnMed.Text = med.Name + Environment.NewLine + med.Price.ToString("c",ci);

                flpMed.Controls.Add(btnMed);
            }
        }

        public void loadCart()
        {
            giỏHàngToolStripMenuItem.Text = "Giỏ hàng (" + Cart.Count + ")";

        }



        #endregion

        #region events

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }
        void btnMed_Click(object sender, EventArgs e)
        {
            Medicine med = (sender as Button).Tag as Medicine;
            MedicineInfo medicineInfo = new MedicineInfo(med);
            medicineInfo.ShowDialog();
        }
        #endregion

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart listItem = new Cart(Cart);
            listItem.ShowDialog();
        }
    }
}
