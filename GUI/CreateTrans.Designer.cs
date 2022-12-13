namespace GUI
{
    partial class CreateTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvCart = new System.Windows.Forms.ListView();
            this.colIndex = new System.Windows.Forms.ColumnHeader();
            this.colMdcId = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colQuantity = new System.Windows.Forms.ColumnHeader();
            this.colUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbShipCost = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colMdcId,
            this.colName,
            this.colQuantity,
            this.colUnitPrice,
            this.colPrice});
            this.lvCart.FullRowSelect = true;
            this.lvCart.Location = new System.Drawing.Point(12, 12);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(555, 348);
            this.lvCart.TabIndex = 1;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "STT";
            this.colIndex.Width = 30;
            // 
            // colMdcId
            // 
            this.colMdcId.Text = "Mã sản phẩm";
            this.colMdcId.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Tên sản phẩm";
            this.colName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Đơn giá";
            this.colUnitPrice.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Thành tiền";
            this.colPrice.Width = 80;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(689, 266);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(196, 23);
            this.tbTotalPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị vận chuyển";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "Grab",
            "Gojek",
            "BE",
            "GHTK"});
            this.cbBrand.Location = new System.Drawing.Point(689, 182);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(196, 23);
            this.cbBrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(689, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 23);
            this.tbName.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(689, 134);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(196, 23);
            this.tbAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng hoá đơn";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(689, 95);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(196, 23);
            this.tbPhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiền ship";
            // 
            // tbShipCost
            // 
            this.tbShipCost.Location = new System.Drawing.Point(689, 225);
            this.tbShipCost.Name = "tbShipCost";
            this.tbShipCost.Size = new System.Drawing.Size(196, 23);
            this.tbShipCost.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(810, 317);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(718, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbShipCost);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lvCart);
            this.Name = "CreateTrans";
            this.Text = "CreateTrans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvCart;
        private ColumnHeader colIndex;
        private ColumnHeader colMdcId;
        private ColumnHeader colName;
        private ColumnHeader colQuantity;
        private ColumnHeader colUnitPrice;
        private ColumnHeader colPrice;
        private TextBox tbTotalPrice;
        private Label label1;
        private Label label2;
        private ComboBox cbBrand;
        private Label label3;
        private TextBox tbName;
        private TextBox tbAddress;
        private Label label4;
        private TextBox tbPhone;
        private Label label5;
        private Label label6;
        private TextBox tbShipCost;
        private Button btnConfirm;
        private Button btnCancel;
    }
}