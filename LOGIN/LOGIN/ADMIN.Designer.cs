namespace LOGIN
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            panel6 = new Panel();
            txtSearch = new TextBox();
            btnLogout = new Button();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            cbRole = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(280, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(385, 457);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 192, 0);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(552, 138);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 25);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Red;
            panel6.Location = new Point(321, 159);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 2);
            panel6.TabIndex = 25;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Black;
            txtSearch.ForeColor = Color.DimGray;
            txtSearch.Location = new Point(315, 138);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 23);
            txtSearch.TabIndex = 24;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(523, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 32);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(317, 36);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 26;
            label1.Text = "Welcome";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Location = new Point(33, 372);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 42;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(34, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(34, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(34, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(34, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 38;
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.Black;
            cbRole.ForeColor = Color.DimGray;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Student", "Teacher", "Blocked" });
            cbRole.Location = new Point(33, 351);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(226, 23);
            cbRole.TabIndex = 37;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(33, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(226, 23);
            txtPassword.TabIndex = 36;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(33, 191);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 23);
            txtUsername.TabIndex = 35;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(33, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 34;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Black;
            txtID.ForeColor = Color.DimGray;
            txtID.Location = new Point(33, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(226, 23);
            txtID.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(33, 331);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 32;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(33, 255);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 31;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(31, 171);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 30;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(31, 89);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 29;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(34, 11);
            label2.Name = "label2";
            label2.Size = new Size(14, 17);
            label2.TabIndex = 28;
            label2.Text = "*";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(34, 537);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(226, 44);
            btnRemove.TabIndex = 45;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(34, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 44);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(34, 412);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 44);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(666, 622);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "ADMIN";
            Text = "ADMIN";
            Load += ADMIN_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private Panel panel6;
        private TextBox txtSearch;
        private Button btnLogout;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
    }
}