using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

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

        private Customer() { }

        public Customer(User userLogin)
        {
            InitializeComponent();
            Instance = this;
            this.userLogin = userLogin;

            xinChàoToolStripMenuItem.Text += " " + userLogin.Name;
            giỏHàngToolStripMenuItem.Text = "Giỏ hàng (" + Cart.Count + ")";

        }



        #region methods
        public void loadMedicine()
        {
            flpMed.Controls.Clear(); 
            List<Medicine> listMed = MedicineDAL.Instance.loadMedicineByName(tbSearch.Text);
            CultureInfo ci = new CultureInfo("vi-VN");
            foreach (Medicine med in listMed)
            {
                PictureBox picMed = new PictureBox();
                picMed.Click += picMed_Click;
                picMed.Tag = med;
                picMed.Width = 280;
                picMed.Height = 280;
                picMed.BackgroundImageLayout = ImageLayout.Stretch;
                MemoryStream ms = new MemoryStream(med.Img);
                Bitmap bmp = new Bitmap(ms);
                picMed.BackgroundImage = bmp;
                picMed.BorderStyle = BorderStyle.FixedSingle;

                Label price = new Label();
                price.Text = med.Price.ToString("c", ci);
                price.BackColor = Color.Green;
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Dock = DockStyle.Bottom;
                price.Width = 50;


                Label name = new Label();
                name.Text = med.Name;
                if (med.Quantity == 0)
                {
                    name.Text += " (hết hàng)";
                    name.BackColor = Color.IndianRed;
                }
                else name.BackColor = Color.LightBlue;
                if (Cart.ContainsKey(med.MdcId))
                {
                    name.Text = med.Name + " (trong giỏ hàng)";
                    name.BackColor = Color.Yellow;
                }
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Width = 280;

                picMed.Controls.Add(price);
                picMed.Controls.Add(name);
                flpMed.Controls.Add(picMed);

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
        void picMed_Click(object sender, EventArgs e)
        {
            Medicine med = (sender as PictureBox).Tag as Medicine;
            MedicineInfo medicineInfo = new MedicineInfo(med);
            medicineInfo.ShowDialog();
        }
        #endregion

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart listItem = new Cart(Cart);
            listItem.ShowDialog();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadMedicine();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadMedicine();
        }

        private void lịchSửMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTransHistory userTransHistory = new UserTransHistory();
            userTransHistory.ShowDialog();
            
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(UserLogin);
            userInfo.ShowDialog();
        }
    }
}
