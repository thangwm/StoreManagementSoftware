using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StoreManagementSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0'; 
            }
            else
            {
                txtpassword.PasswordChar = '●'; 
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password!");
                return;
            }
            else if (MainClass.IsValidUser(txtusername.Text, txtpassword.Text) == false)
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
            else
            {
                this.Hide();
                Main f = new Main();
                f.Show();
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
