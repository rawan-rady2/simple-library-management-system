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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;  // TextBox لرقم العضو (ID)
            string isbn = txtISBN.Text;  // TextBox لرقم ISBN
            DateTime reservationDate = DateTime.Now;  // تاريخ الحجز (الوقت الحالي)

            // التأكد من صحة البيانات المدخلة
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter both UserID and ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // الاتصال بقاعدة البيانات
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";
            string query = "INSERT INTO Reservations (userid, ISBN, resevation_date) VALUES (@userID, @isbn, @reservationDate)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // تنفيذ الاستعلام لإضافة البيانات إلى جدول الحجوزات
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة المعاملات لتجنب SQL Injection
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@reservationDate", reservationDate);

                        // تنفيذ الاستعلام
                        cmd.ExecuteNonQuery();

                        // عرض رسالة نجاح
                        MessageBox.Show("Reservation Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.libraryDataSet2.Reservations);

        }

        private void btnCancelreserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("Please enter both User ID and ISBN to cancel the reservation.");
                return;
            }

            // الحصول على القيم المدخلة
            string userId = txtUserID.Text;
            string isbn = txtISBN.Text;

            // سلسلة الاتصال بقاعدة البيانات
            string connectionString = @"Data Source=1122AD\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True; Encrypt=False";

            // SQL Query لحذف السجل من جدول Reservations
            string query = "DELETE FROM Reservations WHERE userid = @userid AND ISBN = @isbn";

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
                        MessageBox.Show("Reservation canceled successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No reservation record found for the given User ID and ISBN.");
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

