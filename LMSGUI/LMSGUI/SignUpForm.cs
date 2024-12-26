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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string secondName = textBox2.Text;
            string email = textBox3.Text;
            string phoneNumber = textBox4.Text;
            string userName = textBox5.Text;
            string password = textBox7.Text;
            string confirmPassword = textBox8.Text;
            string address = textBox6.Text;

            // التحقق من اختيار الدور (Admin أو Member)
            string role = radioButton1.Checked ? "Admin" : radioButton2.Checked ? "Member" : "";

            // التحقق من تطابق كلمة المرور مع تأكيدها
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من اختيار الدور
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role (Admin or Member).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // سلسلة الاتصال بقاعدة البيانات
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // الاستعلام لإدخال البيانات في الجدول المناسب
            string query = role == "Admin" ?
                "INSERT INTO admins (firstname, secondname, email, phoneno, username, password) VALUES (@firstname, @secondname, @email, @phoneNumber, @userName, @password)" :
                "INSERT INTO members (firstname, secondname, email, phoneno, username, password, address) VALUES (@firstname, @secondname, @email, @phoneNumber, @userName, @password, @address)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة القيم إلى الاستعلام
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@SecondName", secondName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Address", address);

                        // تنفيذ الاستعلام
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // التحقق من نجاح الإضافة
                        if (rowsAffected > 0)
                        {
                            // Assuming 'role' contains the value of the user's role
                            if (role == "Admin")
                            {
                                admin adminForm = new admin(); // Assuming 'admin' is the form name
                                adminForm.Show();
                            }
                            else if (role == "Member")
                            {
                                userindex userForm = new userindex(); // Assuming 'userindex' is the form name
                                userForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Role is not recognized. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            this.Hide(); // Hides the current form
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
