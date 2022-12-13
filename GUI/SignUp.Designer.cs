namespace GUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbConfirm = new GUI.Custom.CustomInput.CustomInput();
            this.label8 = new System.Windows.Forms.Label();
            this.customButton2 = new GUI.Custom.CustomButton.CustomButton();
            this.txbPassword = new GUI.Custom.CustomInput.CustomInput();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEmail = new GUI.Custom.CustomInput.CustomInput();
            this.label6 = new System.Windows.Forms.Label();
            this.txbName = new GUI.Custom.CustomInput.CustomInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customButton1 = new GUI.Custom.CustomButton.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPhone = new GUI.Custom.CustomInput.CustomInput();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.txbPhone);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txbConfirm);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.customButton2);
            this.splitContainer1.Panel2.Controls.Add(this.txbPassword);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txbEmail);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txbName);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.customButton1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(882, 553);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MedicalHere";
            // 
            // txbConfirm
            // 
            this.txbConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.txbConfirm.BorderRadius = 12;
            this.txbConfirm.BorderSize = 2;
            this.txbConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbConfirm.Location = new System.Drawing.Point(35, 444);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirm.Multiline = false;
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbConfirm.PasswordChar = false;
            this.txbConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbConfirm.PlaceholderText = "8+ Characters";
            this.txbConfirm.Size = new System.Drawing.Size(532, 36);
            this.txbConfirm.TabIndex = 14;
            this.txbConfirm.Texts = "";
            this.txbConfirm.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(35, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.customButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customButton2.BorderRadius = 14;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(35, 487);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(211, 54);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Sign Up";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.txbPassword.BorderRadius = 12;
            this.txbPassword.BorderSize = 2;
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(35, 363);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Multiline = false;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPassword.PasswordChar = false;
            this.txbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPassword.PlaceholderText = "8+ Characters";
            this.txbPassword.Size = new System.Drawing.Size(532, 36);
            this.txbPassword.TabIndex = 11;
            this.txbPassword.Texts = "";
            this.txbPassword.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // txbEmail
            // 
            this.txbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.txbEmail.BorderRadius = 12;
            this.txbEmail.BorderSize = 2;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(35, 272);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Multiline = false;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmail.PasswordChar = false;
            this.txbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmail.PlaceholderText = "email@gmail.com";
            this.txbEmail.Size = new System.Drawing.Size(532, 36);
            this.txbEmail.TabIndex = 9;
            this.txbEmail.Texts = "";
            this.txbEmail.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // txbName
            // 
            this.txbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.txbName.BorderRadius = 12;
            this.txbName.BorderSize = 2;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(35, 182);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Multiline = false;
            this.txbName.Name = "txbName";
            this.txbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbName.PasswordChar = false;
            this.txbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbName.PlaceholderText = "Enter your name";
            this.txbName.Size = new System.Drawing.Size(532, 36);
            this.txbName.TabIndex = 7;
            this.txbName.Texts = "";
            this.txbName.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(35, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Create your account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to medicalHere!";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgroundColor = System.Drawing.Color.White;
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customButton1.BorderRadius = 14;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customButton1.Location = new System.Drawing.Point(464, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(103, 38);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Sign In";
            this.customButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Already have an account?";
            // 
            // txbPhone
            // 
            this.txbPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.txbPhone.BorderRadius = 12;
            this.txbPhone.BorderSize = 2;
            this.txbPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPhone.Location = new System.Drawing.Point(35, 106);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhone.Multiline = false;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPhone.PasswordChar = false;
            this.txbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPhone.PlaceholderText = "Enter your name";
            this.txbPhone.Size = new System.Drawing.Size(532, 36);
            this.txbPhone.TabIndex = 16;
            this.txbPhone.Texts = "";
            this.txbPhone.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private PictureBox pictureBox1;
        private Custom.CustomButton.CustomButton customButton1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Custom.CustomInput.CustomInput txbPassword;
        private Label label7;
        private Custom.CustomInput.CustomInput txbEmail;
        private Label label6;
        private Custom.CustomInput.CustomInput txbName;
        private Custom.CustomButton.CustomButton customButton2;
        private Custom.CustomInput.CustomInput txbConfirm;
        private Label label8;
        private Custom.CustomInput.CustomInput txbPhone;
        private Label label9;
    }
}