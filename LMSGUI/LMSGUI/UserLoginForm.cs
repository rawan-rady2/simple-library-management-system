using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMSGUI
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text; // TextBox for Username
            string password = textBox2.Text; // TextBox for Password

            // Connection string to the database
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // SQL query to check if the username and password exist
            string checkQuery = "SELECT COUNT(*) FROM members WHERE username = @username AND password = @password";

            // SQL query to retrieve the UserID
            string userIdQuery = "SELECT userid FROM members WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        // Adding parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Retrieve UserID
                            using (SqlCommand userIdCmd = new SqlCommand(userIdQuery, conn))
                            {
                                userIdCmd.Parameters.AddWithValue("@username", userName);
                                userIdCmd.Parameters.AddWithValue("@password", password);

                                object result = userIdCmd.ExecuteScalar();
                                if (result != null)
                                {
                                    int userId = Convert.ToInt32(result);

                                    // Redirect to UserIndex form
                                    userindex user = new userindex(); // Assuming UserIndex is the form name
                                    user.Username = userName;
                                    user.UserID = userId.ToString(); // تمرير UserID إلى النموذج
                                    user.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("An error occurred while retrieving UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // If username and password do not exist
                            MessageBox.Show("Account not found. Please sign up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
