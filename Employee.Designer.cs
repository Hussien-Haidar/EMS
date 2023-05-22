namespace EMS
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete_emp = new System.Windows.Forms.Button();
            this.btn_update_emp = new System.Windows.Forms.Button();
            this.btn_add_emp = new System.Windows.Forms.Button();
            this.comboBox_department = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_join = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_birth = new System.Windows.Forms.DateTimePicker();
            this.numupdwn_salary = new System.Windows.Forms.NumericUpDown();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tabControl_management = new System.Windows.Forms.TabControl();
            this.tab_employees = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new EMS.EMSDataSet();
            this.tab_departments = new System.Windows.Forms.TabPage();
            this.tab_attendance = new System.Windows.Forms.TabPage();
            this.employeesTableAdapter = new EMS.EMSDataSetTableAdapters.employeesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl_management.SuspendLayout();
            this.tab_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_delete_emp);
            this.panel1.Controls.Add(this.btn_update_emp);
            this.panel1.Controls.Add(this.btn_add_emp);
            this.panel1.Controls.Add(this.comboBox_department);
            this.panel1.Controls.Add(this.dateTimePicker_join);
            this.panel1.Controls.Add(this.dateTimePicker_birth);
            this.panel1.Controls.Add(this.numupdwn_salary);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_emp_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 537);
            this.panel1.TabIndex = 1;
            // 
            // btn_delete_emp
            // 
            this.btn_delete_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_emp.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_emp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_delete_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_delete_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_delete_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete_emp.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete_emp.Location = new System.Drawing.Point(138, 487);
            this.btn_delete_emp.Name = "btn_delete_emp";
            this.btn_delete_emp.Size = new System.Drawing.Size(105, 35);
            this.btn_delete_emp.TabIndex = 9;
            this.btn_delete_emp.Text = "DELETE";
            this.btn_delete_emp.UseVisualStyleBackColor = false;
            // 
            // btn_update_emp
            // 
            this.btn_update_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update_emp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update_emp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_update_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_update_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_update_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_emp.ForeColor = System.Drawing.Color.Snow;
            this.btn_update_emp.Location = new System.Drawing.Point(18, 487);
            this.btn_update_emp.Name = "btn_update_emp";
            this.btn_update_emp.Size = new System.Drawing.Size(105, 35);
            this.btn_update_emp.TabIndex = 8;
            this.btn_update_emp.Text = "UPDATE";
            this.btn_update_emp.UseVisualStyleBackColor = false;
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_emp.BackColor = System.Drawing.Color.Teal;
            this.btn_add_emp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_add_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_add_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_add_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_emp.ForeColor = System.Drawing.Color.Snow;
            this.btn_add_emp.Location = new System.Drawing.Point(17, 446);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Size = new System.Drawing.Size(226, 35);
            this.btn_add_emp.TabIndex = 7;
            this.btn_add_emp.Text = "ADD";
            this.btn_add_emp.UseVisualStyleBackColor = false;
            // 
            // comboBox_department
            // 
            this.comboBox_department.FormattingEnabled = true;
            this.comboBox_department.Location = new System.Drawing.Point(17, 173);
            this.comboBox_department.Name = "comboBox_department";
            this.comboBox_department.Size = new System.Drawing.Size(221, 21);
            this.comboBox_department.TabIndex = 2;
            // 
            // dateTimePicker_join
            // 
            this.dateTimePicker_join.Location = new System.Drawing.Point(17, 283);
            this.dateTimePicker_join.Name = "dateTimePicker_join";
            this.dateTimePicker_join.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_join.TabIndex = 4;
            // 
            // dateTimePicker_birth
            // 
            this.dateTimePicker_birth.Location = new System.Drawing.Point(17, 229);
            this.dateTimePicker_birth.Name = "dateTimePicker_birth";
            this.dateTimePicker_birth.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_birth.TabIndex = 3;
            // 
            // numupdwn_salary
            // 
            this.numupdwn_salary.BackColor = System.Drawing.Color.Snow;
            this.numupdwn_salary.Location = new System.Drawing.Point(17, 339);
            this.numupdwn_salary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numupdwn_salary.Name = "numupdwn_salary";
            this.numupdwn_salary.Size = new System.Drawing.Size(221, 20);
            this.numupdwn_salary.TabIndex = 5;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_phone.Location = new System.Drawing.Point(17, 393);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(226, 28);
            this.txt_phone.TabIndex = 6;
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_emp_name.Location = new System.Drawing.Point(12, 114);
            this.txt_emp_name.Multiline = true;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(226, 28);
            this.txt_emp_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Join Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employee Daily Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EMS.Properties.Resources.id_card;
            this.pictureBox2.Location = new System.Drawing.Point(58, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.Teal;
            this.label_title.Location = new System.Drawing.Point(265, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(165, 20);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Manage Employees";
            // 
            // tabControl_management
            // 
            this.tabControl_management.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_management.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_management.Controls.Add(this.tab_employees);
            this.tabControl_management.Controls.Add(this.tab_departments);
            this.tabControl_management.Controls.Add(this.tab_attendance);
            this.tabControl_management.Location = new System.Drawing.Point(269, 57);
            this.tabControl_management.Name = "tabControl_management";
            this.tabControl_management.SelectedIndex = 0;
            this.tabControl_management.Size = new System.Drawing.Size(800, 448);
            this.tabControl_management.TabIndex = 10;
            // 
            // tab_employees
            // 
            this.tab_employees.Controls.Add(this.dataGridView1);
            this.tab_employees.Location = new System.Drawing.Point(4, 25);
            this.tab_employees.Name = "tab_employees";
            this.tab_employees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_employees.Size = new System.Drawing.Size(792, 419);
            this.tab_employees.TabIndex = 0;
            this.tab_employees.Text = "Employees";
            this.tab_employees.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "join_date";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "join_date";
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.eMSDataSet;
            // 
            // eMSDataSet
            // 
            this.eMSDataSet.DataSetName = "EMSDataSet";
            this.eMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_departments
            // 
            this.tab_departments.Location = new System.Drawing.Point(4, 25);
            this.tab_departments.Name = "tab_departments";
            this.tab_departments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_departments.Size = new System.Drawing.Size(792, 419);
            this.tab_departments.TabIndex = 1;
            this.tab_departments.Text = "Departments";
            this.tab_departments.UseVisualStyleBackColor = true;
            // 
            // tab_attendance
            // 
            this.tab_attendance.Location = new System.Drawing.Point(4, 25);
            this.tab_attendance.Name = "tab_attendance";
            this.tab_attendance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_attendance.Size = new System.Drawing.Size(792, 419);
            this.tab_attendance.TabIndex = 2;
            this.tab_attendance.Text = "Attendance";
            this.tab_attendance.UseVisualStyleBackColor = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.tabControl_management);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl_management.ResumeLayout(false);
            this.tab_employees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numupdwn_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_department;
        private System.Windows.Forms.DateTimePicker dateTimePicker_join;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_emp;
        private System.Windows.Forms.Button btn_delete_emp;
        private System.Windows.Forms.Button btn_update_emp;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TabControl tabControl_management;
        private System.Windows.Forms.TabPage tab_employees;
        private System.Windows.Forms.TabPage tab_departments;
        private System.Windows.Forms.TabPage tab_attendance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EMSDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}