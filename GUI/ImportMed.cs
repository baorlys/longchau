﻿using DAL;
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
    public partial class ImportMed : Form
    {
        private string mdcId;
        public ImportMed(string mdcId)
        {
            InitializeComponent();
            MdcId = mdcId;
            tbMdcId.Text = mdcId;
        }

        public string MdcId { get => mdcId; set => mdcId = value; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn nhập hàng hoá này không?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int quantity = (int)nudQuantity.Value;
                ImportDAL.Instance.importMed(MdcId, quantity);
                MessageBox.Show("Gửi yêu cầu thành công");
                this.Hide();

            }
            
        }
    }
}
