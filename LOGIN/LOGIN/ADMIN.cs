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
using MySqlX.XDevAPI.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace LOGIN
{
    public partial class ADMIN : Form
    {
        private MySqlConnection connection;
        public ADMIN()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=migalangdb;username=root;password=;");
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            try
            {
                //open the connection string
                connection.Open();
                //Select query in database
                string showallrecordquery = "SELECT ID, username, name, role FROM users ORDER BY ID ASC";
                //MySql command
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string showallrecordquery = "SELECT ID, username, name, role FROM users WHERE username LIKE CONCAT('%', @search, '%') OR name LIKE CONCAT('%', @search, '%') OR role LIKE CONCAT('%', @search, '%')";

                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                loaddata();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //declare variable for inputs
            string name = txtName.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cbRole.Text;

            //check if name, username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please enter both " +
                    "name, username and password");
            }

            try
            {
                //Register account code
                connection.Open();
                string registerquery = " INSERT INTO users (name, username, password, role) VALUES (@name, @username, @password, @role)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

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
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //declare variable for inputs
            string name = txtName.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cbRole.Text;
            string ID = txtID.Text;

            //check if name, username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please enter both " +
                    "name, username and password");
            }

            try
            {
                //Register account code
                connection.Open();
                string updatequery = "UPDATE users SET name = @name, username = @username, password = @password, role = @role WHERE ID = @ID";
                MySqlCommand command = new MySqlCommand(updatequery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@ID", ID);

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
            txtID.Clear();
            loaddata();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string ID = txtID.Text;
                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("No recond found!");
                    return;
                }
                try
                {
                    connection.Open();
                    string deletequery = "DELETE  FROM users WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(deletequery, connection);
                    command.Parameters.AddWithValue("@ID", ID);
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
                txtID.Clear();
                loaddata();
            }
            else
            {
                MessageBox.Show("Delation cancelled");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }




}
