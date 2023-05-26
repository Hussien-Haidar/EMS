using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label_reset_Click(object sender, EventArgs e)
        {
            txt_username.Text = txt_password.Text = "";
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Equals("a") && txt_password.Text.Equals("a"))
            {
                // Create an instance of the Employees form
                Employee employeesForm = new Employee();

                // Hide the login form and show the Employees form
                this.Hide();
                employeesForm.FormClosed += (s, args) => this.Close(); // Close the main form when employees form is closed
                employeesForm.Show();
            }
            else if (txt_username.Text.Equals("") || txt_password.Text.Equals(""))
            {
                MessageBox.Show("Please enter all requirements");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
