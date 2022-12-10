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
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colQuantity = new System.Windows.Forms.ColumnHeader();
            this.colUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colName,
            this.colQuantity,
            this.colUnitPrice,
            this.colPrice});
            this.lvCart.Location = new System.Drawing.Point(36, 52);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(455, 348);
            this.lvCart.TabIndex = 0;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "STT";
            this.colIndex.Width = 30;
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
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 552);
            this.Controls.Add(this.lvCart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvCart;
        private ColumnHeader colIndex;
        private ColumnHeader colName;
        private ColumnHeader colQuantity;
        private ColumnHeader colUnitPrice;
        private ColumnHeader colPrice;
    }
}