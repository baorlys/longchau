using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;


namespace GUI
{
    public partial class SignIn : Form
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //user.Email = txbEmail.Texts;
            //user.Password = txbPassword.Texts;
            //string message = userBLL.checkLogin(user);
            //switch (message)
            //{
            //    case "required email":
            //        MessageBox.Show("Vui lòng nhập email");
            //        return;
            //    case "required password":
            //        MessageBox.Show("Vui lòng nhập mật khẩu");
            //        return;
            //    case "invalid email/pass":
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            //        return;
            //}
            //User userLogin = UserDAL.Instance.getUserByEmail(txbEmail.Texts);
            //this.Hide();
            //if (userLogin.RoleId == 0)
            //{
            //    Admin admin = new Admin(userLogin);
            //    admin.ShowDialog();
            //}
            //else
            //{
            //    Customer customer = new Customer(userLogin);
            //    customer.ShowDialog();
            //}


            //Hard user to test customer
            this.Hide();
            User userLogin = UserDAL.Instance.getUserByEmail("admin@gmail.com");
            Admin Admin = new Admin(userLogin);
            Admin.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show();
            this.Hide();
        }
    }
}
