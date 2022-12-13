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

        //private void btnSignIn_Click(object sender, EventArgs e)
        //{
        //    user.Email = txbEmail.Text;
        //    user.Password = txbPassword.Text;
        //    string message = userBLL.checkLogin(user);
        //    switch (message)
        //    {
        //        case "required email":
        //            MessageBox.Show("Vui lòng nhập email");
        //            return;
        //        case "required password":
        //            MessageBox.Show("Vui lòng nhập mật khẩu");
        //            return;
        //        case "invalid email/pass":
        //            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
        //            return;
        //    }
        //    User userLogin = UserDAL.Instance.getUserByEmail(txbEmail.Text);
        //    this.Hide();
        //    if(userLogin.RoleId == 0)
        //    {
        //        Admin admin = new Admin(userLogin);
        //        admin.ShowDialog();
        //    }
        //    else
        //    {
        //        Customer customer = new Customer(userLogin);
        //        customer.ShowDialog();
        //    }

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

        private void txbEmail__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.RemovePlaceholder();
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.RemovePlaceholder();
        }
    }
}
