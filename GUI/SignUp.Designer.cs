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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new GUI.Custom.CustomButton.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customInput1 = new GUI.Custom.CustomInput.CustomInput();
            this.customInput2 = new GUI.Custom.CustomInput.CustomInput();
            this.label6 = new System.Windows.Forms.Label();
            this.customInput3 = new GUI.Custom.CustomInput.CustomInput();
            this.label7 = new System.Windows.Forms.Label();
            this.customButton2 = new GUI.Custom.CustomButton.CustomButton();
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
            this.splitContainer1.Panel2.Controls.Add(this.customButton2);
            this.splitContainer1.Panel2.Controls.Add(this.customInput3);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.customInput2);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.customInput1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.customButton1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(882, 553);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
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
            this.customButton1.Location = new System.Drawing.Point(456, 18);
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
            this.label2.Location = new System.Drawing.Point(259, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Already have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to medicalHere!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Create your account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // customInput1
            // 
            this.customInput1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customInput1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.customInput1.BorderRadius = 12;
            this.customInput1.BorderSize = 2;
            this.customInput1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customInput1.Location = new System.Drawing.Point(27, 200);
            this.customInput1.Margin = new System.Windows.Forms.Padding(4);
            this.customInput1.Multiline = false;
            this.customInput1.Name = "customInput1";
            this.customInput1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customInput1.PasswordChar = false;
            this.customInput1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customInput1.PlaceholderText = "Enter your name";
            this.customInput1.Size = new System.Drawing.Size(532, 36);
            this.customInput1.TabIndex = 7;
            this.customInput1.Texts = "";
            this.customInput1.UnderlinedStyle = false;
            // 
            // customInput2
            // 
            this.customInput2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customInput2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.customInput2.BorderRadius = 12;
            this.customInput2.BorderSize = 2;
            this.customInput2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customInput2.Location = new System.Drawing.Point(27, 290);
            this.customInput2.Margin = new System.Windows.Forms.Padding(4);
            this.customInput2.Multiline = false;
            this.customInput2.Name = "customInput2";
            this.customInput2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customInput2.PasswordChar = false;
            this.customInput2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customInput2.PlaceholderText = "email@gmail.com";
            this.customInput2.Size = new System.Drawing.Size(532, 36);
            this.customInput2.TabIndex = 9;
            this.customInput2.Texts = "";
            this.customInput2.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // customInput3
            // 
            this.customInput3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customInput3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(155)))));
            this.customInput3.BorderRadius = 12;
            this.customInput3.BorderSize = 2;
            this.customInput3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customInput3.Location = new System.Drawing.Point(27, 381);
            this.customInput3.Margin = new System.Windows.Forms.Padding(4);
            this.customInput3.Multiline = false;
            this.customInput3.Name = "customInput3";
            this.customInput3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customInput3.PasswordChar = false;
            this.customInput3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customInput3.PlaceholderText = "8+ Characters";
            this.customInput3.Size = new System.Drawing.Size(532, 36);
            this.customInput3.TabIndex = 11;
            this.customInput3.Texts = "";
            this.customInput3.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
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
            this.customButton2.Location = new System.Drawing.Point(27, 452);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(211, 54);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Sign Up";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
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
        private Custom.CustomInput.CustomInput customInput3;
        private Label label7;
        private Custom.CustomInput.CustomInput customInput2;
        private Label label6;
        private Custom.CustomInput.CustomInput customInput1;
        private Custom.CustomButton.CustomButton customButton2;
    }
}