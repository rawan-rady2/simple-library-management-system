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
    public partial class viewbooks : Form
    {
        public viewbooks()
        {
            InitializeComponent();
        }

        private void viewbooks_Load(object sender, EventArgs e)
        {
            // تحميل الكتب عند تحميل النموذج
            LoadBooks();
        }
      
        private void LoadBooks()
        {
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";
            string query = "SELECT Title, Author, Price, Status FROM Books";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable booksTable = new DataTable();
                        adapter.Fill(booksTable);

                        // تحقق من عدد الصفوف
                        Console.WriteLine($"Number of rows fetched: {booksTable.Rows.Count}");

                        // تعيين البيانات إلى DataGridView
                        dgvBooks.DataSource = booksTable;
                       


                        // التأكد من أن AutoGenerateColumns مفعلة
                        dgvBooks.AutoGenerateColumns = true;

                        // تحديث عناوين الأعمدة (اختياري إذا كانت بحاجة لتغيير)
                        dgvBooks.Columns["Title"].HeaderText = "Book Title";
                        dgvBooks.Columns["Author"].HeaderText = "Author";
                        dgvBooks.Columns["Price"].HeaderText = "Price";
                        dgvBooks.Columns["Status"].HeaderText = "Availability";


                      

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewbooks_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    }

