using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSGUI
{
    public partial class userindex : Form
    {
        public string Username { get; set; }
        public string UserID { get; set; }
        public userindex()
        {
            InitializeComponent();

        }
        

        private void userindex_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Welcom: " + Username;
            id.Text ="ID: "+ UserID;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           viewbooks view = new viewbooks();
           view.Show(); // لفتح النموذج بدون إغلاق النموذج الرئيسي
                              // adminForm.ShowDialog(); // لفتح النموذج كنافذة حوارية
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Reserve res=new Reserve();
            res.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Borrow borrow=new Borrow();
            borrow.Show();
        }

       
    }
}
