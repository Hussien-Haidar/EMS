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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.eMSDataSet.employees);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the Login form
            Login loginForm = new Login();

            // Hide the Employee form and show the Login form
            Hide();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the Employee form when Login form is closed
            loginForm.Show();
        }
    }
}
