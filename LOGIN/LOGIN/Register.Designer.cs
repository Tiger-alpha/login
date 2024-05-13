namespace LOGIN
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnSignin = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 40);
            label1.TabIndex = 0;
            label1.Text = "REGISTER ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(28, 161);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(28, 216);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DarkGray;
            txtName.Location = new Point(28, 124);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your name";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DarkGray;
            txtUsername.Location = new Point(28, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DarkGray;
            txtPassword.Location = new Point(28, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(28, 267);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(231, 57);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(0, 192, 0);
            btnSignin.FlatStyle = FlatStyle.Popup;
            btnSignin.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(28, 330);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(231, 57);
            btnSignin.TabIndex = 8;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(29, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(29, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(29, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(293, 467);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSignin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnSignin;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}