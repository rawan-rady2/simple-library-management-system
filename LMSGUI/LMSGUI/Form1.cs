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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminLoginForm adminForm = new adminLoginForm();
            adminForm.Show(); // لفتح النموذج بدون إغلاق النموذج الرئيسي
                              // adminForm.ShowDialog(); // لفتح النموذج كنافذة حوارية
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserLoginForm userForm = new UserLoginForm();
            userForm.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
