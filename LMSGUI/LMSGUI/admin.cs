
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMSGUI
{
  
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        // Properties to store Username and UserID
        public string Username { get; set; }
        public string UserID { get; set; }

        private void admin_Load(object sender, EventArgs e)
        {
            // Update labels with Username and UserID
            label2.Text = "Welcome: " + Username;
            label3.Text = "ID: " + UserID;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            books book = new books();

            book.UserID = this.UserID;
            book.Username = this.Username;

            book.Show();
            
        }
    }

}
