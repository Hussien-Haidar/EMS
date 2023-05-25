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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VTCIHHL\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;");

        //load employees form
        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.eMSDataSet.employees);

            // Set the column header text for each column
            dataGridView_employees.Columns[0].HeaderText = "ID";
            dataGridView_employees.Columns[1].HeaderText = "Name";
            dataGridView_employees.Columns[2].HeaderText = "Gender";
            dataGridView_employees.Columns[3].HeaderText = "Department";
            dataGridView_employees.Columns[4].HeaderText = "Birth Date";
            dataGridView_employees.Columns[5].HeaderText = "Join Date";
            dataGridView_employees.Columns[6].HeaderText = "Salary";
            dataGridView_employees.Columns[7].HeaderText = "Phone";

            // TODO: This line of code loads data into the 'eMSDataSet.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.eMSDataSet.departments);

            // Set the column header text for each column
            dataGridView_departments.Columns[0].HeaderText = "ID";
            dataGridView_departments.Columns[1].HeaderText = "Department";

            // TODO: This line of code loads data into the 'eMSDataSet.attendences' table. You can move, or remove it, as needed.
            this.attendencesTableAdapter.Fill(this.eMSDataSet.attendences);

            // Set the column header text for each column
            dataGridView_attendance.Columns[0].HeaderText = "ID";
            dataGridView_attendance.Columns[1].HeaderText = "Time Entered";
            dataGridView_attendance.Columns[2].HeaderText = "Time Left";
            dataGridView_attendance.Columns[3].HeaderText = "Employee ID";

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM [employees]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Assign the DataTable as the data source for the DataGridView
            dataGridView_salaries.DataSource = dataTable;

            // Set the column name for the "Employees" column
            dataGridView_salaries.Columns["name"].HeaderText = "Employees";
            con.Close();

            con.Open();
            // Query the database to retrieve the join_date column for the desired employee(s)
            string query = "SELECT join_date, birth FROM [employees]";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string joinDateText = reader["join_date"].ToString();
                string birthDateText = reader["birth"].ToString();

                // Parse the join_date text to extract the month name
                DateTime joinDate = DateTime.Parse(joinDateText);
                DateTime birthDate = DateTime.Parse(birthDateText);

                string joinMonthName = joinDate.ToString("MMMM");
                string birthMonthName = birthDate.ToString("MMM");

                // Use the monthName variable as desired (e.g., store it, display it, etc.)
                Console.WriteLine("Month Name: " + joinMonthName + ", "+ birthMonthName);
            }

            reader.Close();


        }

        //exit system when pressing exit tool strip menu button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //logout from the  system when pressing logout tool strip menu button
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the Login form
            Login loginForm = new Login();

            // Hide the Employee form and show the Login form
            Hide();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the Employee form when Login form is closed
            loginForm.Show();
        }

        //add employee button
        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            if (!txt_emp_name.Text.Equals("") && !txt_phone.Text.Equals("") && !comboBox_department.Text.Equals("") && !numupdwn_salary.Value.Equals(0)
                && !comboBox_gender.Text.Equals(""))
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert Into [employees] (name, gender, department, birth, join_date, salary, phone) " +
                    "values ('" + txt_emp_name.Text + "', '" + comboBox_gender.Text + "', '" + comboBox_department.Text + "', '" +
                    dateTimePicker_birth.Text + "', '" + dateTimePicker_join.Text + "', '"+numupdwn_salary.Value+"', '" + txt_phone.Text + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0) 
                {
                    MessageBox.Show("Employee has been added successfully");
                    txt_emp_name.Text = txt_phone.Text = comboBox_gender.Text = comboBox_department.Text = "";
                    dateTimePicker_birth.Value = dateTimePicker_birth.MinDate;
                    dateTimePicker_join.Value = dateTimePicker_join.MinDate;
                    RefreshData();
                }
                else 
                {
                    MessageBox.Show("error");
                }
                     }
            else
            {
                MessageBox.Show("Please enter all requirnments");
            }
        }

        //delete employee button
        private void btn_delete_emp_Click(object sender, EventArgs e)
        {
            if (!txt_emp_name.Text.Equals("") && !txt_phone.Text.Equals("") && !comboBox_department.Text.Equals("") && !numupdwn_salary.Value.Equals(0)
                && !comboBox_gender.Text.Equals(""))
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete [employees] where id = "+txt_id.Text, con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Employee has been permenantly deleted");
                    txt_emp_name.Text = txt_phone.Text = comboBox_gender.Text = comboBox_department.Text = "";
                    dateTimePicker_birth.Value = dateTimePicker_birth.MinDate;
                    dateTimePicker_join.Value = dateTimePicker_join.MinDate;
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        //update employee button
        private void btn_update_emp_Click(object sender, EventArgs e)
        {
            if (!txt_emp_name.Text.Equals("") && !txt_phone.Text.Equals("") && !comboBox_department.Text.Equals("") && !numupdwn_salary.Value.Equals(0)
                && !comboBox_gender.Text.Equals(""))
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update [employees] set name='"+txt_emp_name.Text+"', gender='"+comboBox_gender.Text+"', " +
                    "department='"+comboBox_department.Text+"', birth='"+dateTimePicker_birth.Text+"', join_date='"+dateTimePicker_join.Text+"', " +
                    "salary='"+numupdwn_salary.Value+"', phone='"+txt_phone.Text+"'  where id = " + txt_id.Text, con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Employee has been successfully updated");
                    txt_emp_name.Text = txt_phone.Text = comboBox_gender.Text = comboBox_department.Text = "";
                    dateTimePicker_birth.Value = dateTimePicker_birth.MinDate;
                    dateTimePicker_join.Value = dateTimePicker_join.MinDate;
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        //add department button
        private void btn_add_department_Click(object sender, EventArgs e)
        {
            if (txt_department.Text == "")
            {
                MessageBox.Show("Please fill all requirnments");
            }
            else
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert Into [departments] (department) values ('" + txt_department.Text + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("New department has been added successfully");
                    txt_department.Text = "";
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();
            }
        }

        //delete department button
        private void btn_delete_dapartment_Click(object sender, EventArgs e)
        {
            if (!txt_department.Text.Equals(""))
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete [departments] where id = " + txt_id.Text, con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Department has been permenantly deleted");
                    txt_department.Text = "";
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        //update department button
        private void btn_update_department_Click(object sender, EventArgs e)
        {
            if (!txt_department.Text.Equals(""))
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update [departments] set department='" + txt_department.Text + "' where id = " + txt_id.Text, con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Department has been successfully updated");
                    txt_department.Text = "";
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        //add attendance button
        private void btn_add_attendance_Click(object sender, EventArgs e)
        {
            string enteredTimeSelection = GetSelectedRadioButtonText(groupBox_entered_time);
            string leftTimeSelection = GetSelectedRadioButtonText(groupBox_left_time);

            // Function to get the selected radio button text from a GroupBox
            string GetSelectedRadioButtonText(GroupBox groupBox)
            {
                string selectedRadioButtonText = "";

                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked)
                    {
                        selectedRadioButtonText = radioButton.Text;
                        break;
                    }
                }

                return selectedRadioButtonText;
            }

            // Check if radio buttons are selected in both group boxes
            if (!string.IsNullOrEmpty(enteredTimeSelection) && !string.IsNullOrEmpty(leftTimeSelection))
            {
                // Your existing code for database insertion
                if (!comboBox_employee_name.Text.Equals("") && !numericUpDown_entered_time.Value.Equals(0) && !numericUpDown_left_time.Value.Equals(0))
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [attendences] (time_entered, time_left, emp_id, date) " +
                        "VALUES (@timeEntered, @timeLeft, @empId, @date)", con);

                    // Set parameter values
                    cmd.Parameters.AddWithValue("@timeEntered", numericUpDown_entered_time.Value + " " + enteredTimeSelection);
                    cmd.Parameters.AddWithValue("@timeLeft", numericUpDown_left_time.Value + " " + leftTimeSelection);
                    cmd.Parameters.AddWithValue("@empId", "5"); // Assuming you have a specific employee ID
                    cmd.Parameters.AddWithValue("@date", dateTimePicker_current_date.Text);

                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Attendance has been added successfully");
                        comboBox_employee_name.Text = "";
                        numericUpDown_entered_time.Value = numericUpDown_left_time.Value = 0;
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please enter all requirements");
                }
            }
            else
            {
                MessageBox.Show("Please select an attendance option for both entered time and left time");
            }
        }

        //check if the user has changed the selected tab
        private void tabControl_management_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the user chooses employees tab
            if (tabControl_management.SelectedTab == tab_employees) 
            {
                label_title.Text = "Manage Employees";
                txt_department.Visible = false;
                label_department.Visible = false;

                label_current_date.Visible = false;
                label_entered_time.Visible = false;
                label_left_time.Visible = false;

                label_name.Visible = true;
                label_emp_department.Visible = true;
                label_gender.Visible = true;
                label_birth.Visible = true;
                label_join.Visible = true;
                label_salary.Visible = true;
                label_phone.Visible = true;

                txt_emp_name.Visible = true;
                txt_phone.Visible = true;
                comboBox_gender.Visible = true;
                comboBox_department.Visible = true;
                numupdwn_salary.Visible = true;
                dateTimePicker_birth.Visible = true;
                dateTimePicker_join.Visible = true;

                dateTimePicker_current_date.Visible = false;
                btn_add_attendance.Visible = false;
                groupBox_left_time.Visible = false;
                groupBox_entered_time.Visible = false;
                numericUpDown_entered_time.Visible = false;
                numericUpDown_left_time.Visible = false;
                comboBox_employee_name.Visible = false;

                btn_add_emp.Visible = true;
                btn_delete_emp.Visible = true;
                btn_update_emp.Visible = true;

                btn_add_department.Visible = false;
                btn_delete_dapartment.Visible = false;
                btn_update_department.Visible = false;

                btn_add_attendance.Visible = false;
            }
            
            //if the user chooses departments tab
            else if (tabControl_management.SelectedTab == tab_departments)
            {
                label_title.Text = "Manage Departments";
                txt_department.Visible = true;
                label_department.Visible = true;

                label_name.Visible = false;
                label_emp_department.Visible = false;
                label_gender.Visible = false;
                label_birth.Visible = false;
                label_join.Visible = false;
                label_salary.Visible = false;
                label_phone.Visible = false;
                label_current_date.Visible = false;
                label_entered_time.Visible = false;
                label_left_time.Visible = false;

                txt_emp_name.Visible = false;
                txt_phone.Visible = false;
                comboBox_gender.Visible = false;
                comboBox_department.Visible = false;
                numupdwn_salary.Visible = false;
                dateTimePicker_birth.Visible = false;
                dateTimePicker_join.Visible = false;
                dateTimePicker_current_date.Visible = false;
                groupBox_left_time.Visible = false;
                groupBox_entered_time.Visible = false;
                numericUpDown_entered_time.Visible = false;
                numericUpDown_left_time.Visible = false;

                btn_add_emp.Visible = false;
                btn_delete_emp.Visible = false;
                btn_update_emp.Visible = false;

                btn_add_attendance.Visible = false;

                btn_add_department.Visible = true;
                btn_delete_dapartment.Visible = true;
                btn_update_department.Visible = true;
            }
            
            //if the user chooses attendence tab
            else if (tabControl_management.SelectedTab == tab_attendance)
            {
                label_title.Text = "Add Attendance";
                label_name.Visible = true;
                label_current_date.Visible = true;
                label_entered_time.Visible = true;
                label_left_time.Visible = true;

                comboBox_employee_name.Visible = true;
                dateTimePicker_current_date.Visible = true;
                numericUpDown_entered_time.Visible = true;
                numericUpDown_left_time.Visible = true;
                groupBox_entered_time.Visible = true;
                groupBox_left_time.Visible = true;
                btn_add_attendance.Visible = true;

                label_department.Visible = false;
                txt_department.Visible = false;

                label_emp_department.Visible = false;
                label_gender.Visible = false;
                label_birth.Visible = false;
                label_join.Visible = false;
                label_salary.Visible = false;
                label_phone.Visible = false;

                txt_emp_name.Visible = false;
                txt_phone.Visible = false;
                comboBox_gender.Visible = false;
                comboBox_department.Visible = false;
                numupdwn_salary.Visible = false;
                dateTimePicker_birth.Visible = false;
                dateTimePicker_join.Visible = false;

                btn_add_emp.Visible = false;
                btn_delete_emp.Visible = false;
                btn_update_emp.Visible = false;

                btn_add_department.Visible = false;
                btn_delete_dapartment.Visible = false;
                btn_update_department.Visible = false;
            }
        }

        //get the data of the selected row from the data grid view of the employees
        private void dataGridView_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_employees.Rows[e.RowIndex];

                try
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value.ToString();
                    string gender = selectedRow.Cells[2].Value.ToString();
                    string department = selectedRow.Cells[3].Value.ToString();
                    int salary = int.Parse(selectedRow.Cells[6].Value.ToString());
                    string phone = selectedRow.Cells[7].Value.ToString();

                    txt_id.Text = id;
                    txt_emp_name.Text = name;
                    comboBox_gender.Text = gender;
                    comboBox_department.Text = department;
                    numupdwn_salary.Value = salary;
                    txt_phone.Text = phone;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show("Error retrieving cell values: " + ex.Message);
                }
            }
        }

        //get the data of the selected row from the data grid view of the departments
        private void dataGridView_departments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_departments.Rows[e.RowIndex];

                try
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string department = selectedRow.Cells[1].Value.ToString();

                    txt_id.Text = id;
                    txt_department.Text = department;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show("Error retrieving cell values: " + ex.Message);
                }
            }
        }

        private void RefreshData() 
        {
            this.employeesTableAdapter.Fill(this.eMSDataSet.employees);
            this.departmentsTableAdapter.Fill(this.eMSDataSet.departments);
            this.attendencesTableAdapter.Fill(this.eMSDataSet.attendences);
        }

    }
}
