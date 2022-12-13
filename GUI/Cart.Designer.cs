namespace GUI
{
    partial class Cart
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.lvCart.Location = new System.Drawing.Point(36, 52);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(555, 348);
            this.lvCart.TabIndex = 0;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCart_MouseDoubleClick);
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
            this.tbTotalPrice.Location = new System.Drawing.Point(334, 430);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(152, 23);
            this.tbTotalPrice.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(516, 430);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Đặt hàng";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(516, 471);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(75, 23);
            this.btnDelAll.TabIndex = 3;
            this.btnDelAll.Text = "Xoá tất cả sản phẩm ";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(36, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 552);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lvCart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvCart;
        private ColumnHeader colIndex;
        private ColumnHeader colName;
        private ColumnHeader colQuantity;
        private ColumnHeader colUnitPrice;
        private ColumnHeader colPrice;
        private TextBox tbTotalPrice;
        private Button btnConfirm;
        private ColumnHeader colMdcId;
        private Button btnDelAll;
        private Button btnBack;
    }
}