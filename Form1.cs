using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "payawson" & password.Text == "elearning")
            {
                //if user enters details correctly
                MessageBox.Show("User Login Correctly");
            }
            else
            {
                //if user enters details incorrectly
                MessageBox.Show("Sorry User Login incorrectly");
            }
        }
    }
}
