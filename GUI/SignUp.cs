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
    public partial class SignUp : Form
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        public SignUp()
        {
            InitializeComponent();
        }

        //private void btnSignUp_Click(object sender, EventArgs e)
        //{
        //    user.Email = txbEmail.Text;
        //    user.Name = txbName.Text;
        //    user.Phone = txbPhone.Text;
        //    user.Password = txbPassword.Text;
        //    string confirmPass = txbConfirm.Text;
        //    MessageHandler etUser = userBLL.checkSignUp(user,confirmPass);
        //    if (etUser.getStatus() == false)
        //    {
        //        MessageBox.Show(etUser.getMessage());
        //        return;
        //    }
        //    User userLogin = UserDAL.Instance.getUserByEmail(txbEmail.Text);
        //    Customer customer = new Customer(userLogin);
        //    customer.ShowDialog();
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
