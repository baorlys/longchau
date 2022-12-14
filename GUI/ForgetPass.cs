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
    public partial class ForgetPass : Form
    {
        private string email;
        
        public ForgetPass()
        {
            InitializeComponent();
        }

        public ForgetPass(string email)
        {
            InitializeComponent();
            this.email = email;
            txbEmail.Texts = email;
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Texts;
            if (email == "")
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            Random r = new Random();
            int randNum = r.Next(1000000);
            string otp = randNum.ToString("D6");

            if (UserDAL.Instance.sendOTP(email,otp))
            {
                MessageBox.Show("Mã OTP đã được gửi đến email của bạn");
                this.Hide();
                OTP oTP = new OTP(email);
                oTP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email không tồn tại");
                return;
            }

        }

        private void txbEmail__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
