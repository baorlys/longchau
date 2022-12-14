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
    public partial class UserInfo : Form
    {
        private User userLogin;

        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }
        public UserInfo(User userLogin)
        {
            InitializeComponent();
            this.UserLogin = userLogin;
            loadData();
        }

        void loadData()
        {
            tbEmail.Text = UserLogin.Email;
            tbName.Text = UserLogin.Name;
            tbPhone.Text = UserLogin.Phone;
            tbAddress.Text = UserLogin.Address;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            if (name == "") {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            if (phone == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (address == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            UserDAL.Instance.updateUserInfo(email, name, phone, address);
            MessageBox.Show("Tài khoản đã cập nhật");
            this.Close();

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
