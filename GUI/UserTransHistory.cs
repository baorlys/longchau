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
    public partial class UserTransHistory : Form
    {
        public UserTransHistory()
        {
            InitializeComponent();
            cbState.SelectedIndex = 0;
            loadData();
        }
        void loadData()
        {
            lvTrans.Items.Clear();
            CultureInfo ci = new CultureInfo("vi-VN");
            List<Transaction> transactions = TransactionDAL.Instance.loadTransListByUserId(Customer.Instance.UserLogin.UserId.ToString(), cbState.SelectedIndex);
            foreach (Transaction item in transactions)
            {
                ListViewItem lvItem = new ListViewItem(item.TransId.ToString());
                lvItem.UseItemStyleForSubItems = false;
                lvItem.SubItems.Add(item.TransDate.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString("c",ci));
                string state = "";
                switch (item.State)
                {
                    case 0:
                        state = "Chưa giao";
                        lvItem.SubItems.Add(state);
                        lvItem.SubItems[3].BackColor = Color.Yellow;
                        break;
                    case 1:
                        state = "Đã giao";
                        lvItem.SubItems.Add(state);
                        lvItem.SubItems[3].BackColor = Color.Green;
                        break;
                    case 2:
                        state = "Bị huỷ";
                        lvItem.SubItems.Add(state);
                        lvItem.SubItems[3].BackColor = Color.Gray;
                        break;
                }
                lvTrans.Items.Add(lvItem);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void lvTrans_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string transId = lvTrans.SelectedItems[0].SubItems[0].Text;
            TransDetail transDetail = new TransDetail(transId);
            transDetail.ShowDialog();
        }
    }
}
