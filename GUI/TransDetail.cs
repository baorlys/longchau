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
    public partial class TransDetail : Form
    {
        private string transId;

        public string TransId { get => transId; set => transId = value; }

        public TransDetail(string transId)
        {
            InitializeComponent();
            this.TransId = transId;
            loadData();
        }

        void loadData()
        {
            int i = 1;
            CultureInfo ci = new CultureInfo("vi-VN");
            List<TransactionDetail> transDetailList = TransactionDetailDAL.Instance.loadTransDetail(Convert.ToInt32(TransId));
            int totalPrice = 0;
            foreach (TransactionDetail item in transDetailList)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(item.MdcId);
                lvItem.SubItems.Add(item.Name);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.Price.ToString("c", ci));
                int price = item.Quantity * item.Price;
                totalPrice += price;
                lvItem.SubItems.Add(price.ToString("c", ci));
                lvTransDetail.Items.Add(lvItem);
                i++;
            }
            totalPrice += 30000;
            tbTotalPrice.Text = totalPrice.ToString("c", ci);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
