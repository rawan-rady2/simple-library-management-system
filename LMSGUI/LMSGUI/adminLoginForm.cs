using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSGUI
{
    public partial class adminLoginForm : Form
    {
        public adminLoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text; // TextBox for Username
            string password = textBox2.Text; // TextBox for Password

            // Connection string to the database
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // SQL query to check if the username and password exist
            string query = "SELECT AdminID, username FROM admins WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve UserID and Username
                                int userId = reader.GetInt32(0); // AdminID
                                string retrievedUsername = reader.GetString(1); // Username

                                // Open the admin form
                                admin adminForm = new admin
                                {
                                    Username = retrievedUsername,
                                    UserID = userId.ToString()
                                };

                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                // If username and password do not exist
                                MessageBox.Show("Account not found. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

