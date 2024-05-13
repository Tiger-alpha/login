using Microsoft.Win32;
using MySql.Data.MySqlClient;
namespace LOGIN
{
    public partial class Form1 : Form
    {
        //Declare MySqlConnection for handling database connection
        private MySqlConnection connection;
        public Form1()
        {

            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=migalangdb;username=root;passwor=;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //sanitized data to remove white-space
            string username = txtUsername.Text.Trim();
            string password = txtpassword.Text;

            //check if username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both " +
                    "username and password");
            }

            try
            {
                //open the connection string
                connection.Open();
                //create a string that will handle query
                string loginquery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                //Execute the command loginquery
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                //sanitize query for sql injection
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //Get row count
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    //MessageBox.Show("Correct username and password");
                    ADMIN ADMINPAGE = new ADMIN();
                    ADMINPAGE.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
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
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register signuppage = new Register();
            signuppage.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
