namespace LOGIN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            chbShowPassword = new CheckBox();
            btnSignin = new Button();
            btnClose = new Button();
            label4 = new Label();
            linksignup = new LinkLabel();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 40);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(63, 133);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(63, 197);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(62, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(225, 27);
            txtUsername.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(62, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(63, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 7;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Black;
            chbShowPassword.Font = new Font("Snap ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = Color.Fuchsia;
            chbShowPassword.Location = new Point(63, 249);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(146, 21);
            chbShowPassword.TabIndex = 8;
            chbShowPassword.Text = "Show password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Black;
            btnSignin.FlatStyle = FlatStyle.Popup;
            btnSignin.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(61, 280);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(226, 44);
            btnSignin.TabIndex = 9;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(61, 349);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(226, 44);
            btnClose.TabIndex = 10;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(61, 327);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 11;
            label4.Text = "Don't have an account?";
            // 
            // linksignup
            // 
            linksignup.ActiveLinkColor = Color.Black;
            linksignup.AutoSize = true;
            linksignup.BackColor = Color.Black;
            linksignup.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linksignup.ForeColor = Color.Red;
            linksignup.LinkColor = Color.Red;
            linksignup.Location = new Point(226, 327);
            linksignup.Name = "linksignup";
            linksignup.Size = new Size(59, 17);
            linksignup.TabIndex = 12;
            linksignup.TabStop = true;
            linksignup.Text = "Sign up";
            linksignup.LinkClicked += linksignup_LinkClicked;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.Black;
            txtpassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.DimGray;
            txtpassword.Location = new Point(63, 214);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Enter your password";
            txtpassword.Size = new Size(225, 27);
            txtpassword.TabIndex = 13;
            txtpassword.TextChanged += txtpassword_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 495);
            Controls.Add(txtpassword);
            Controls.Add(linksignup);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnSignin);
            Controls.Add(chbShowPassword);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private Panel panel1;
        private Panel panel2;
        private CheckBox chbShowPassword;
        private Button btnSignin;
        private Button btnClose;
        private Label label4;
        private LinkLabel linksignup;
        private TextBox txtpassword;
    }
}
