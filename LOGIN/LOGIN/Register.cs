using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
namespace LOGIN
{
    public partial class Register : Form
    {
        private MySqlConnection connection;
        public Register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=migalangdb;username=root;password=;");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //declare variable for inputs
            string name = txtName.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //check if name, username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter both " +
                    "name, username and password");
            }

            try
            {
                //Register account code
                connection.Open();
                string registerquery = " INSERT INTO users (name, username, password) VALUES (@name, @username, @password)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //Get row affected
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registered Successfully! ");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account! ");
                }
            }
            catch (Exception ex)
            {
                //Display any error if occured
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //close connection whether  there is a error or not
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
