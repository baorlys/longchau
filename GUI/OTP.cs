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

namespace GUI
{
    public partial class OTP : Form
    {
        private string email;

        public OTP(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        public OTP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass(email);
            this.Hide();
            forgetPass.ShowDialog();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string otp = txbOTP.Texts;
            if (otp == "")
            {
                MessageBox.Show("Vui lòng nhập mã OTP");
                return;
            }
            if (UserDAL.Instance.checkOTP(email,otp))
            {
                ResetPass resetPass = new ResetPass(email);
                this.Hide();
                resetPass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng");
            }
        }
    }
}
