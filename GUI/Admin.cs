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
    public partial class Admin : Form
    {
        private User userLogin;

        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }
        public Admin(User userLogin)
        {
            InitializeComponent();
            adminToolStripMenuItem.Text += " (" + userLogin.Name + ")";
            this.UserLogin = userLogin;
            cbState.SelectedIndex = 0;
            loadDTP();
            loadMedicine();
            loadTrans(null, 0);
            loadRevenue(dtpFrom.Value, dtpTo.Value);
        }

        #region Method
        void loadMedicine()
        {
            dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicineToDt();
        }

        void loadRevenue(DateTime from, DateTime to)
        {
            dgvRevenue.DataSource = RevenueDAL.Instance.loadRevenueToDt(from,to);
            RevenueDAL revDAL = RevenueDAL.Instance;
            List<Revenue> listRev = revDAL.loadRevenue(from, to);
            tbCountTrans.Text = revDAL.countNumberTrans(listRev).ToString();
            tbTotalPriceRevenue.Text = revDAL.getTotalPriceRev(listRev).ToString();
        }

        void loadTrans(string? date, int state)
        {
            List<Transaction> listTrans = TransactionDAL.Instance.loadTransList(date, state);
            foreach(Transaction trans in listTrans) {
                Button btnTrans = new Button() { Width = TransactionDAL.TransWidth, Height = TransactionDAL.TransHeight};
                btnTrans.Click += btnTrans_Click;
                btnTrans.Tag = trans;
                string stateStr = "";
                switch (trans.State)
                {
                    case 0:
                        btnTrans.BackColor = Color.Yellow;
                        stateStr = "Chưa giao";
                        break;
                    case 1:
                        btnTrans.BackColor = Color.Green;
                        stateStr = "Đã giao";
                        break;
                }
                btnTrans.Text = "HD" + trans.UserId.ToString() + Environment.NewLine + stateStr; 

                flpTrans.Controls.Add(btnTrans);
            }
        }

        void showTransDetail(int transId)
        {
            lvTrans.Items.Clear();
            List<TransactionDetail> transDetailList = TransactionDetailDAL.Instance.loadTransDetail(transId);
            float totalPrice = 0;
            foreach (TransactionDetail item in transDetailList) {
                ListViewItem lvItem = new ListViewItem(item.MdcId.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvTrans.Items.Add(lvItem);
            }
            CultureInfo ci = new CultureInfo("vi-VN");
            tbTotalPrice.Text = totalPrice.ToString("c", ci);

        }

        void loadDTP()
        {
            DateTime today = DateTime.Now;
            dtpTrans.Value = today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
        }
        #endregion

        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }
        private void btnGetTrans_Click(object sender, EventArgs e)
        {
            string? date = dtpTrans.Value.ToShortDateString();
            flpTrans.Controls.Clear();
            if (cbWithOutDate.Checked) date = null;
            loadTrans(date, cbState.SelectedIndex);
        }

        void btnTrans_Click(object sender, EventArgs e)
        {
            int transId = ((sender as Button).Tag as Transaction).TransId;
            showTransDetail(transId);
        }

        #endregion

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            loadRevenue(dtpFrom.Value, dtpTo.Value);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(userLogin);
            userInfo.ShowDialog();
        }
    }
}
