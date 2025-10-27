using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment_Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(TxtPassword_KeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs enter)
        {
            if (txtUsername.Text == "Me" && txtPassword.Text == "Me")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = string.Empty;
                lblErrorMssg.Text = "Please try again.";
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs enter)
        {
            if (enter.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs enter)
        {
            if (enter.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}

