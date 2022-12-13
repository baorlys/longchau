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

        private void btnsignin_click(object sender, eventargs e)
        {
            user.Email = txbEmail.Texts;
            user.Password = txbPassword.Texts;
            string message = userBLL.checkLogin(user);
            switch (message)
            {
                case "required email":
                    MessageBox.Show("vui lòng nhập email");
                    return;
                case "required password":
                    MessageBox.Show("vui lòng nhập mật khẩu");
                    return;
                case "invalid email/pass":
                    MessageBox.Show("tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            User userlogin = UserDAL.instance.getuserbyemail(txbEmail.Texts);
            this.hide();
            if (userlogin.roleid == 0)
            {
                Admin admin = new Admin(userlogin);
                admin.showdialog();
            }
            else
            {
                Customer customer = new Customer(userlogin);
                customer.showdialog();
            }

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

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
