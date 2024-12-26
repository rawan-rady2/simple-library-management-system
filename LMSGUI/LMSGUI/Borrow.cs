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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet4.Borrowing' table. You can move, or remove it, as needed.
            this.borrowingTableAdapter1.Fill(this.libraryDataSet4.Borrowing);
            // TODO: This line of code loads data into the 'libraryDataSet3.Borrowing' table. You can move, or remove it, as needed.
            this.borrowingTableAdapter.Fill(this.libraryDataSet3.Borrowing);

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtISBN.Text) || cmbPeriod.SelectedItem == null)
            {
                MessageBox.Show("يرجى ملء جميع الحقول!");
                return;
            }

            // الحصول على القيم المدخلة
            string userId = txtUserID.Text;
            string isbn = txtISBN.Text;
            int borrowingPeriod = int.Parse(cmbPeriod.SelectedItem.ToString());
            DateTime borrowDate = DateTime.Now;
            DateTime dueDate = borrowDate.AddDays(borrowingPeriod);
            decimal fine = 50.00m; // قيمة افتراضية للغرامة

            // سلسلة الاتصال بقاعدة البيانات
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // SQL Query
            string query = "INSERT INTO Borrowing (userid, ISBN, borrow_date, due_date, fine) VALUES (@userid, @isbn, @borrow_date, @due_date, @fine)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userid", userId);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@borrow_date", borrowDate);
                command.Parameters.AddWithValue("@due_date", dueDate);
                command.Parameters.AddWithValue("@fine", fine);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Borrowing completed successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("Please enter both User ID and ISBN to cancel the borrowing.");
                return;
            }

            // الحصول على القيم المدخلة
            string userId = txtUserID.Text;
            string isbn = txtISBN.Text;

            // سلسلة الاتصال بقاعدة البيانات
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // SQL Query لحذف السجل
            string query = "DELETE FROM Borrowing WHERE userid = @userid AND ISBN = @isbn";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userid", userId);
                command.Parameters.AddWithValue("@isbn", isbn);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Borrowing canceled successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No borrowing record found for the given User ID and ISBN.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
    

