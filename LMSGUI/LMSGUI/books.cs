using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMSGUI
{
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }
        public string Username { get; set; }
        public string UserID { get; set; }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet5.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet5.Books);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            int isbn;
            if (!int.TryParse(textBox4.Text, out isbn)) // التحقق من أن المدخل في textBox4 هو رقم صحيح
            {
                MessageBox.Show("Please enter a valid ISBN.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // إذا لم يكن المدخل صحيحًا، نوقف العملية
            }

            string author = textBox2.Text;
            string category = textBox3.Text;
            double price;
            if (!double.TryParse(textBox5.Text, out price)) // التحقق من أن المدخل في textBox5 هو رقم صحيح
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // إذا لم يكن المدخل صحيحًا، نوقف العملية
            }

            if (string.IsNullOrEmpty(UserID))
            {
                MessageBox.Show("AdminID is not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";
            string query = @"INSERT INTO Books 
                     (Title, Author, Category, Price, ISBN, AdminID)
                     VALUES (@Title, @Author, @Category, @Price, @ISBN, @AdminID)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Author", author);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@ISBN", isbn); // تم تمرير القيمة الصالحة
                        cmd.Parameters.AddWithValue("@AdminID", UserID); // تأكد من أن UserID له قيمة

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // تحديث DataGridView (إذا لزم الأمر)
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