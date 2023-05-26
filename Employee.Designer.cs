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
            this.label_total_salary = new System.Windows.Forms.Label();
            this.txt_total_salary = new System.Windows.Forms.TextBox();
            this.btn_add_attendance = new System.Windows.Forms.Button();
            this.groupBox_left_time = new System.Windows.Forms.GroupBox();
            this.radioButton_left_am = new System.Windows.Forms.RadioButton();
            this.radioButton_left_pm = new System.Windows.Forms.RadioButton();
            this.comboBox_employee_name = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new EMS.EMSDataSet();
            this.numericUpDown_left_time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_entered_time = new System.Windows.Forms.NumericUpDown();
            this.label_left_time = new System.Windows.Forms.Label();
            this.groupBox_entered_time = new System.Windows.Forms.GroupBox();
            this.radioButton_entered_am = new System.Windows.Forms.RadioButton();
            this.radioButton_entered_pm = new System.Windows.Forms.RadioButton();
            this.label_entered_time = new System.Windows.Forms.Label();
            this.label_current_date = new System.Windows.Forms.Label();
            this.dateTimePicker_current_date = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_delete_dapartment = new System.Windows.Forms.Button();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.btn_update_department = new System.Windows.Forms.Button();
            this.btn_delete_emp = new System.Windows.Forms.Button();
            this.btn_add_department = new System.Windows.Forms.Button();
            this.label_department = new System.Windows.Forms.Label();
            this.btn_update_emp = new System.Windows.Forms.Button();
            this.btn_add_emp = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_department = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_join = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_birth = new System.Windows.Forms.DateTimePicker();
            this.numupdwn_salary = new System.Windows.Forms.NumericUpDown();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.label_join = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_emp_department = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tabControl_management = new System.Windows.Forms.TabControl();
            this.tab_employees = new System.Windows.Forms.TabPage();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_departments = new System.Windows.Forms.TabPage();
            this.dataGridView_departments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_attendance = new System.Windows.Forms.TabPage();
            this.dataGridView_attendance = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeenteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeleftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_salaries = new System.Windows.Forms.TabPage();
            this.dataGridView_salaries = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesTableAdapter = new EMS.EMSDataSetTableAdapters.employeesTableAdapter();
            this.departmentsTableAdapter = new EMS.EMSDataSetTableAdapters.departmentsTableAdapter();
            this.attendencesTableAdapter = new EMS.EMSDataSetTableAdapters.attendencesTableAdapter();
            this.label_footer = new System.Windows.Forms.Label();
            this.btn_give_salary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox_left_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_left_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_entered_time)).BeginInit();
            this.groupBox_entered_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl_management.SuspendLayout();
            this.tab_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.tab_departments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departments)).BeginInit();
            this.tab_attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendencesBindingSource)).BeginInit();
            this.tabPage_salaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salaries)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_give_salary);
            this.panel1.Controls.Add(this.label_total_salary);
            this.panel1.Controls.Add(this.txt_total_salary);
            this.panel1.Controls.Add(this.btn_add_attendance);
            this.panel1.Controls.Add(this.groupBox_left_time);
            this.panel1.Controls.Add(this.comboBox_employee_name);
            this.panel1.Controls.Add(this.numericUpDown_left_time);
            this.panel1.Controls.Add(this.numericUpDown_entered_time);
            this.panel1.Controls.Add(this.label_left_time);
            this.panel1.Controls.Add(this.groupBox_entered_time);
            this.panel1.Controls.Add(this.label_entered_time);
            this.panel1.Controls.Add(this.label_current_date);
            this.panel1.Controls.Add(this.dateTimePicker_current_date);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_delete_dapartment);
            this.panel1.Controls.Add(this.txt_department);
            this.panel1.Controls.Add(this.btn_update_department);
            this.panel1.Controls.Add(this.btn_delete_emp);
            this.panel1.Controls.Add(this.btn_add_department);
            this.panel1.Controls.Add(this.label_department);
            this.panel1.Controls.Add(this.btn_update_emp);
            this.panel1.Controls.Add(this.btn_add_emp);
            this.panel1.Controls.Add(this.comboBox_gender);
            this.panel1.Controls.Add(this.comboBox_department);
            this.panel1.Controls.Add(this.dateTimePicker_join);
            this.panel1.Controls.Add(this.dateTimePicker_birth);
            this.panel1.Controls.Add(this.numupdwn_salary);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_emp_name);
            this.panel1.Controls.Add(this.label_join);
            this.panel1.Controls.Add(this.label_birth);
            this.panel1.Controls.Add(this.label_salary);
            this.panel1.Controls.Add(this.label_gender);
            this.panel1.Controls.Add(this.label_emp_department);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 637);
            this.panel1.TabIndex = 1;
            // 
            // label_total_salary
            // 
            this.label_total_salary.AutoSize = true;
            this.label_total_salary.BackColor = System.Drawing.Color.Teal;
            this.label_total_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_total_salary.ForeColor = System.Drawing.Color.Transparent;
            this.label_total_salary.Location = new System.Drawing.Point(16, 159);
            this.label_total_salary.Name = "label_total_salary";
            this.label_total_salary.Size = new System.Drawing.Size(92, 16);
            this.label_total_salary.TabIndex = 25;
            this.label_total_salary.Text = "Total Salary\r\n";
            this.label_total_salary.Visible = false;
            // 
            // txt_total_salary
            // 
            this.txt_total_salary.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_total_salary.Location = new System.Drawing.Point(12, 178);
            this.txt_total_salary.Multiline = true;
            this.txt_total_salary.Name = "txt_total_salary";
            this.txt_total_salary.Size = new System.Drawing.Size(226, 28);
            this.txt_total_salary.TabIndex = 24;
            this.txt_total_salary.Visible = false;
            // 
            // btn_add_attendance
            // 
            this.btn_add_attendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_attendance.BackColor = System.Drawing.Color.Teal;
            this.btn_add_attendance.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_add_attendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_add_attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_add_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_attendance.ForeColor = System.Drawing.Color.Snow;
            this.btn_add_attendance.Location = new System.Drawing.Point(9, 540);
            this.btn_add_attendance.Name = "btn_add_attendance";
            this.btn_add_attendance.Size = new System.Drawing.Size(226, 35);
            this.btn_add_attendance.TabIndex = 23;
            this.btn_add_attendance.Text = "ADD";
            this.btn_add_attendance.UseVisualStyleBackColor = false;
            this.btn_add_attendance.Visible = false;
            this.btn_add_attendance.Click += new System.EventHandler(this.btn_add_attendance_Click);
            // 
            // groupBox_left_time
            // 
            this.groupBox_left_time.Controls.Add(this.radioButton_left_am);
            this.groupBox_left_time.Controls.Add(this.radioButton_left_pm);
            this.groupBox_left_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_left_time.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_left_time.Location = new System.Drawing.Point(13, 378);
            this.groupBox_left_time.Name = "groupBox_left_time";
            this.groupBox_left_time.Size = new System.Drawing.Size(221, 45);
            this.groupBox_left_time.TabIndex = 7;
            this.groupBox_left_time.TabStop = false;
            this.groupBox_left_time.Text = "AM or PM";
            this.groupBox_left_time.Visible = false;
            // 
            // radioButton_left_am
            // 
            this.radioButton_left_am.AutoSize = true;
            this.radioButton_left_am.Location = new System.Drawing.Point(6, 19);
            this.radioButton_left_am.Name = "radioButton_left_am";
            this.radioButton_left_am.Size = new System.Drawing.Size(43, 17);
            this.radioButton_left_am.TabIndex = 4;
            this.radioButton_left_am.TabStop = true;
            this.radioButton_left_am.Text = "AM";
            this.radioButton_left_am.UseVisualStyleBackColor = true;
            // 
            // radioButton_left_pm
            // 
            this.radioButton_left_pm.AutoSize = true;
            this.radioButton_left_pm.Location = new System.Drawing.Point(109, 19);
            this.radioButton_left_pm.Name = "radioButton_left_pm";
            this.radioButton_left_pm.Size = new System.Drawing.Size(43, 17);
            this.radioButton_left_pm.TabIndex = 5;
            this.radioButton_left_pm.TabStop = true;
            this.radioButton_left_pm.Text = "PM";
            this.radioButton_left_pm.UseVisualStyleBackColor = true;
            // 
            // comboBox_employee_name
            // 
            this.comboBox_employee_name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "name", true));
            this.comboBox_employee_name.DataSource = this.employeesBindingSource;
            this.comboBox_employee_name.DisplayMember = "name";
            this.comboBox_employee_name.FormattingEnabled = true;
            this.comboBox_employee_name.Location = new System.Drawing.Point(12, 114);
            this.comboBox_employee_name.Name = "comboBox_employee_name";
            this.comboBox_employee_name.Size = new System.Drawing.Size(226, 21);
            this.comboBox_employee_name.TabIndex = 22;
            this.comboBox_employee_name.ValueMember = "id";
            this.comboBox_employee_name.Visible = false;
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
            // numericUpDown_left_time
            // 
            this.numericUpDown_left_time.BackColor = System.Drawing.Color.Snow;
            this.numericUpDown_left_time.Location = new System.Drawing.Point(14, 341);
            this.numericUpDown_left_time.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_left_time.Name = "numericUpDown_left_time";
            this.numericUpDown_left_time.Size = new System.Drawing.Size(221, 20);
            this.numericUpDown_left_time.TabIndex = 21;
            this.numericUpDown_left_time.Visible = false;
            // 
            // numericUpDown_entered_time
            // 
            this.numericUpDown_entered_time.BackColor = System.Drawing.Color.Snow;
            this.numericUpDown_entered_time.Location = new System.Drawing.Point(12, 231);
            this.numericUpDown_entered_time.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_entered_time.Name = "numericUpDown_entered_time";
            this.numericUpDown_entered_time.Size = new System.Drawing.Size(221, 20);
            this.numericUpDown_entered_time.TabIndex = 19;
            this.numericUpDown_entered_time.Visible = false;
            // 
            // label_left_time
            // 
            this.label_left_time.AutoSize = true;
            this.label_left_time.BackColor = System.Drawing.Color.Teal;
            this.label_left_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_left_time.ForeColor = System.Drawing.Color.Transparent;
            this.label_left_time.Location = new System.Drawing.Point(14, 322);
            this.label_left_time.Name = "label_left_time";
            this.label_left_time.Size = new System.Drawing.Size(71, 16);
            this.label_left_time.TabIndex = 20;
            this.label_left_time.Text = "Left Time";
            this.label_left_time.Visible = false;
            // 
            // groupBox_entered_time
            // 
            this.groupBox_entered_time.Controls.Add(this.radioButton_entered_am);
            this.groupBox_entered_time.Controls.Add(this.radioButton_entered_pm);
            this.groupBox_entered_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_entered_time.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_entered_time.Location = new System.Drawing.Point(14, 268);
            this.groupBox_entered_time.Name = "groupBox_entered_time";
            this.groupBox_entered_time.Size = new System.Drawing.Size(221, 45);
            this.groupBox_entered_time.TabIndex = 6;
            this.groupBox_entered_time.TabStop = false;
            this.groupBox_entered_time.Text = "AM or PM";
            this.groupBox_entered_time.Visible = false;
            // 
            // radioButton_entered_am
            // 
            this.radioButton_entered_am.AutoSize = true;
            this.radioButton_entered_am.Location = new System.Drawing.Point(6, 19);
            this.radioButton_entered_am.Name = "radioButton_entered_am";
            this.radioButton_entered_am.Size = new System.Drawing.Size(43, 17);
            this.radioButton_entered_am.TabIndex = 2;
            this.radioButton_entered_am.TabStop = true;
            this.radioButton_entered_am.Text = "AM";
            this.radioButton_entered_am.UseVisualStyleBackColor = true;
            // 
            // radioButton_entered_pm
            // 
            this.radioButton_entered_pm.AutoSize = true;
            this.radioButton_entered_pm.Location = new System.Drawing.Point(109, 19);
            this.radioButton_entered_pm.Name = "radioButton_entered_pm";
            this.radioButton_entered_pm.Size = new System.Drawing.Size(43, 17);
            this.radioButton_entered_pm.TabIndex = 3;
            this.radioButton_entered_pm.TabStop = true;
            this.radioButton_entered_pm.Text = "PM";
            this.radioButton_entered_pm.UseVisualStyleBackColor = true;
            // 
            // label_entered_time
            // 
            this.label_entered_time.AutoSize = true;
            this.label_entered_time.BackColor = System.Drawing.Color.Teal;
            this.label_entered_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_entered_time.ForeColor = System.Drawing.Color.Transparent;
            this.label_entered_time.Location = new System.Drawing.Point(14, 212);
            this.label_entered_time.Name = "label_entered_time";
            this.label_entered_time.Size = new System.Drawing.Size(100, 16);
            this.label_entered_time.TabIndex = 18;
            this.label_entered_time.Text = "Entered Time";
            this.label_entered_time.Visible = false;
            // 
            // label_current_date
            // 
            this.label_current_date.AutoSize = true;
            this.label_current_date.BackColor = System.Drawing.Color.Teal;
            this.label_current_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_current_date.ForeColor = System.Drawing.Color.Transparent;
            this.label_current_date.Location = new System.Drawing.Point(17, 159);
            this.label_current_date.Name = "label_current_date";
            this.label_current_date.Size = new System.Drawing.Size(52, 16);
            this.label_current_date.TabIndex = 17;
            this.label_current_date.Text = "Today";
            this.label_current_date.Visible = false;
            // 
            // dateTimePicker_current_date
            // 
            this.dateTimePicker_current_date.Location = new System.Drawing.Point(12, 177);
            this.dateTimePicker_current_date.Name = "dateTimePicker_current_date";
            this.dateTimePicker_current_date.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_current_date.TabIndex = 16;
            this.dateTimePicker_current_date.Value = new System.DateTime(2023, 5, 23, 0, 0, 0, 0);
            this.dateTimePicker_current_date.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(75, 483);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 15;
            this.txt_id.Visible = false;
            // 
            // btn_delete_dapartment
            // 
            this.btn_delete_dapartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_dapartment.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_dapartment.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_delete_dapartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_delete_dapartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_delete_dapartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete_dapartment.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete_dapartment.Location = new System.Drawing.Point(129, 581);
            this.btn_delete_dapartment.Name = "btn_delete_dapartment";
            this.btn_delete_dapartment.Size = new System.Drawing.Size(105, 35);
            this.btn_delete_dapartment.TabIndex = 14;
            this.btn_delete_dapartment.Text = "DELETE";
            this.btn_delete_dapartment.UseVisualStyleBackColor = false;
            this.btn_delete_dapartment.Visible = false;
            this.btn_delete_dapartment.Click += new System.EventHandler(this.btn_delete_dapartment_Click);
            // 
            // txt_department
            // 
            this.txt_department.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_department.Location = new System.Drawing.Point(12, 114);
            this.txt_department.Multiline = true;
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(226, 28);
            this.txt_department.TabIndex = 12;
            this.txt_department.Visible = false;
            // 
            // btn_update_department
            // 
            this.btn_update_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update_department.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update_department.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_update_department.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_update_department.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_update_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_department.ForeColor = System.Drawing.Color.Snow;
            this.btn_update_department.Location = new System.Drawing.Point(8, 581);
            this.btn_update_department.Name = "btn_update_department";
            this.btn_update_department.Size = new System.Drawing.Size(105, 35);
            this.btn_update_department.TabIndex = 13;
            this.btn_update_department.Text = "UPDATE";
            this.btn_update_department.UseVisualStyleBackColor = false;
            this.btn_update_department.Visible = false;
            this.btn_update_department.Click += new System.EventHandler(this.btn_update_department_Click);
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
            this.btn_delete_emp.Location = new System.Drawing.Point(129, 581);
            this.btn_delete_emp.Name = "btn_delete_emp";
            this.btn_delete_emp.Size = new System.Drawing.Size(105, 35);
            this.btn_delete_emp.TabIndex = 9;
            this.btn_delete_emp.Text = "DELETE";
            this.btn_delete_emp.UseVisualStyleBackColor = false;
            this.btn_delete_emp.Click += new System.EventHandler(this.btn_delete_emp_Click);
            // 
            // btn_add_department
            // 
            this.btn_add_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_department.BackColor = System.Drawing.Color.Teal;
            this.btn_add_department.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_add_department.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_add_department.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_add_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_department.ForeColor = System.Drawing.Color.Snow;
            this.btn_add_department.Location = new System.Drawing.Point(9, 540);
            this.btn_add_department.Name = "btn_add_department";
            this.btn_add_department.Size = new System.Drawing.Size(226, 35);
            this.btn_add_department.TabIndex = 12;
            this.btn_add_department.Text = "ADD";
            this.btn_add_department.UseVisualStyleBackColor = false;
            this.btn_add_department.Visible = false;
            this.btn_add_department.Click += new System.EventHandler(this.btn_add_department_Click);
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.BackColor = System.Drawing.Color.Teal;
            this.label_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_department.ForeColor = System.Drawing.Color.Transparent;
            this.label_department.Location = new System.Drawing.Point(17, 95);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(119, 16);
            this.label_department.TabIndex = 13;
            this.label_department.Text = "Add Department";
            this.label_department.Visible = false;
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
            this.btn_update_emp.Location = new System.Drawing.Point(9, 581);
            this.btn_update_emp.Name = "btn_update_emp";
            this.btn_update_emp.Size = new System.Drawing.Size(105, 35);
            this.btn_update_emp.TabIndex = 8;
            this.btn_update_emp.Text = "UPDATE";
            this.btn_update_emp.UseVisualStyleBackColor = false;
            this.btn_update_emp.Click += new System.EventHandler(this.btn_update_emp_Click);
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
            this.btn_add_emp.Location = new System.Drawing.Point(8, 540);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Size = new System.Drawing.Size(226, 35);
            this.btn_add_emp.TabIndex = 7;
            this.btn_add_emp.Text = "ADD";
            this.btn_add_emp.UseVisualStyleBackColor = false;
            this.btn_add_emp.Click += new System.EventHandler(this.btn_add_emp_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(13, 177);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(221, 21);
            this.comboBox_gender.TabIndex = 2;
            // 
            // comboBox_department
            // 
            this.comboBox_department.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentsBindingSource, "department", true));
            this.comboBox_department.DataSource = this.departmentsBindingSource;
            this.comboBox_department.DisplayMember = "department";
            this.comboBox_department.FormattingEnabled = true;
            this.comboBox_department.Location = new System.Drawing.Point(13, 231);
            this.comboBox_department.Name = "comboBox_department";
            this.comboBox_department.Size = new System.Drawing.Size(221, 21);
            this.comboBox_department.TabIndex = 2;
            this.comboBox_department.ValueMember = "id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.eMSDataSet;
            // 
            // dateTimePicker_join
            // 
            this.dateTimePicker_join.Location = new System.Drawing.Point(13, 341);
            this.dateTimePicker_join.Name = "dateTimePicker_join";
            this.dateTimePicker_join.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_join.TabIndex = 4;
            // 
            // dateTimePicker_birth
            // 
            this.dateTimePicker_birth.Location = new System.Drawing.Point(13, 287);
            this.dateTimePicker_birth.Name = "dateTimePicker_birth";
            this.dateTimePicker_birth.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker_birth.TabIndex = 3;
            // 
            // numupdwn_salary
            // 
            this.numupdwn_salary.BackColor = System.Drawing.Color.Snow;
            this.numupdwn_salary.Location = new System.Drawing.Point(13, 397);
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
            this.txt_phone.Location = new System.Drawing.Point(12, 449);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(222, 28);
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
            // label_join
            // 
            this.label_join.AutoSize = true;
            this.label_join.BackColor = System.Drawing.Color.Teal;
            this.label_join.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_join.ForeColor = System.Drawing.Color.Transparent;
            this.label_join.Location = new System.Drawing.Point(14, 322);
            this.label_join.Name = "label_join";
            this.label_join.Size = new System.Drawing.Size(73, 16);
            this.label_join.TabIndex = 3;
            this.label_join.Text = "Join Date";
            // 
            // label_birth
            // 
            this.label_birth.AutoSize = true;
            this.label_birth.BackColor = System.Drawing.Color.Teal;
            this.label_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_birth.ForeColor = System.Drawing.Color.Transparent;
            this.label_birth.Location = new System.Drawing.Point(14, 268);
            this.label_birth.Name = "label_birth";
            this.label_birth.Size = new System.Drawing.Size(92, 16);
            this.label_birth.TabIndex = 3;
            this.label_birth.Text = "Date of Birth";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.BackColor = System.Drawing.Color.Teal;
            this.label_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_salary.ForeColor = System.Drawing.Color.Transparent;
            this.label_salary.Location = new System.Drawing.Point(14, 378);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(166, 16);
            this.label_salary.TabIndex = 3;
            this.label_salary.Text = "Employee Daily Salary";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.Teal;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_gender.ForeColor = System.Drawing.Color.Transparent;
            this.label_gender.Location = new System.Drawing.Point(14, 158);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(58, 16);
            this.label_gender.TabIndex = 3;
            this.label_gender.Text = "Gender";
            // 
            // label_emp_department
            // 
            this.label_emp_department.AutoSize = true;
            this.label_emp_department.BackColor = System.Drawing.Color.Teal;
            this.label_emp_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_emp_department.ForeColor = System.Drawing.Color.Transparent;
            this.label_emp_department.Location = new System.Drawing.Point(14, 212);
            this.label_emp_department.Name = "label_emp_department";
            this.label_emp_department.Size = new System.Drawing.Size(161, 16);
            this.label_emp_department.TabIndex = 3;
            this.label_emp_department.Text = "Employee Department";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Teal;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_phone.ForeColor = System.Drawing.Color.Transparent;
            this.label_phone.Location = new System.Drawing.Point(17, 430);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(109, 16);
            this.label_phone.TabIndex = 3;
            this.label_phone.Text = "Phone Number";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Teal;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_name.ForeColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(14, 95);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(122, 16);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Employee Name";
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
            this.tabControl_management.Controls.Add(this.tabPage_salaries);
            this.tabControl_management.Location = new System.Drawing.Point(269, 57);
            this.tabControl_management.Name = "tabControl_management";
            this.tabControl_management.SelectedIndex = 0;
            this.tabControl_management.Size = new System.Drawing.Size(800, 448);
            this.tabControl_management.TabIndex = 10;
            this.tabControl_management.SelectedIndexChanged += new System.EventHandler(this.tabControl_management_SelectedIndexChanged);
            // 
            // tab_employees
            // 
            this.tab_employees.Controls.Add(this.dataGridView_employees);
            this.tab_employees.Location = new System.Drawing.Point(4, 25);
            this.tab_employees.Name = "tab_employees";
            this.tab_employees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_employees.Size = new System.Drawing.Size(792, 419);
            this.tab_employees.TabIndex = 0;
            this.tab_employees.Text = "Employees";
            this.tab_employees.UseVisualStyleBackColor = true;
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.AllowUserToOrderColumns = true;
            this.dataGridView_employees.AutoGenerateColumns = false;
            this.dataGridView_employees.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView_employees.DataSource = this.employeesBindingSource;
            this.dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employees.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.ReadOnly = true;
            this.dataGridView_employees.Size = new System.Drawing.Size(786, 413);
            this.dataGridView_employees.TabIndex = 0;
            this.dataGridView_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employees_CellClick);
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
            // tab_departments
            // 
            this.tab_departments.Controls.Add(this.dataGridView_departments);
            this.tab_departments.Location = new System.Drawing.Point(4, 25);
            this.tab_departments.Name = "tab_departments";
            this.tab_departments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_departments.Size = new System.Drawing.Size(792, 419);
            this.tab_departments.TabIndex = 1;
            this.tab_departments.Text = "Departments";
            this.tab_departments.UseVisualStyleBackColor = true;
            // 
            // dataGridView_departments
            // 
            this.dataGridView_departments.AllowUserToAddRows = false;
            this.dataGridView_departments.AllowUserToDeleteRows = false;
            this.dataGridView_departments.AllowUserToOrderColumns = true;
            this.dataGridView_departments.AutoGenerateColumns = false;
            this.dataGridView_departments.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1});
            this.dataGridView_departments.DataSource = this.departmentsBindingSource;
            this.dataGridView_departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_departments.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_departments.Name = "dataGridView_departments";
            this.dataGridView_departments.ReadOnly = true;
            this.dataGridView_departments.Size = new System.Drawing.Size(786, 413);
            this.dataGridView_departments.TabIndex = 0;
            this.dataGridView_departments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_departments_CellClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tab_attendance
            // 
            this.tab_attendance.Controls.Add(this.dataGridView_attendance);
            this.tab_attendance.Location = new System.Drawing.Point(4, 25);
            this.tab_attendance.Name = "tab_attendance";
            this.tab_attendance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_attendance.Size = new System.Drawing.Size(792, 419);
            this.tab_attendance.TabIndex = 2;
            this.tab_attendance.Text = "Attendance";
            this.tab_attendance.UseVisualStyleBackColor = true;
            // 
            // dataGridView_attendance
            // 
            this.dataGridView_attendance.AllowUserToAddRows = false;
            this.dataGridView_attendance.AllowUserToDeleteRows = false;
            this.dataGridView_attendance.AllowUserToOrderColumns = true;
            this.dataGridView_attendance.AutoGenerateColumns = false;
            this.dataGridView_attendance.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.timeenteredDataGridViewTextBoxColumn,
            this.timeleftDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_attendance.DataSource = this.attendencesBindingSource;
            this.dataGridView_attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_attendance.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_attendance.Name = "dataGridView_attendance";
            this.dataGridView_attendance.ReadOnly = true;
            this.dataGridView_attendance.Size = new System.Drawing.Size(786, 413);
            this.dataGridView_attendance.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // timeenteredDataGridViewTextBoxColumn
            // 
            this.timeenteredDataGridViewTextBoxColumn.DataPropertyName = "time_entered";
            this.timeenteredDataGridViewTextBoxColumn.HeaderText = "time_entered";
            this.timeenteredDataGridViewTextBoxColumn.Name = "timeenteredDataGridViewTextBoxColumn";
            this.timeenteredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeleftDataGridViewTextBoxColumn
            // 
            this.timeleftDataGridViewTextBoxColumn.DataPropertyName = "time_left";
            this.timeleftDataGridViewTextBoxColumn.HeaderText = "time_left";
            this.timeleftDataGridViewTextBoxColumn.Name = "timeleftDataGridViewTextBoxColumn";
            this.timeleftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "emp_name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendencesBindingSource
            // 
            this.attendencesBindingSource.DataMember = "attendences";
            this.attendencesBindingSource.DataSource = this.eMSDataSet;
            // 
            // tabPage_salaries
            // 
            this.tabPage_salaries.Controls.Add(this.dataGridView_salaries);
            this.tabPage_salaries.Location = new System.Drawing.Point(4, 25);
            this.tabPage_salaries.Name = "tabPage_salaries";
            this.tabPage_salaries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_salaries.Size = new System.Drawing.Size(792, 419);
            this.tabPage_salaries.TabIndex = 3;
            this.tabPage_salaries.Text = "Salaries";
            this.tabPage_salaries.UseVisualStyleBackColor = true;
            // 
            // dataGridView_salaries
            // 
            this.dataGridView_salaries.AllowUserToAddRows = false;
            this.dataGridView_salaries.AllowUserToDeleteRows = false;
            this.dataGridView_salaries.AllowUserToOrderColumns = true;
            this.dataGridView_salaries.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_salaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_salaries.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_salaries.Name = "dataGridView_salaries";
            this.dataGridView_salaries.ReadOnly = true;
            this.dataGridView_salaries.Size = new System.Drawing.Size(786, 413);
            this.dataGridView_salaries.TabIndex = 0;
            this.dataGridView_salaries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_salaries_CellClick);
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
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // attendencesTableAdapter
            // 
            this.attendencesTableAdapter.ClearBeforeFill = true;
            // 
            // label_footer
            // 
            this.label_footer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_footer.AutoSize = true;
            this.label_footer.BackColor = System.Drawing.Color.Snow;
            this.label_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_footer.ForeColor = System.Drawing.Color.Teal;
            this.label_footer.Location = new System.Drawing.Point(276, 504);
            this.label_footer.Name = "label_footer";
            this.label_footer.Size = new System.Drawing.Size(482, 15);
            this.label_footer.TabIndex = 12;
            this.label_footer.Text = "Windows Form (.NET Framework), Team: Abbass Alayyan / Hussien Haidar";
            // 
            // btn_give_salary
            // 
            this.btn_give_salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_give_salary.BackColor = System.Drawing.Color.Teal;
            this.btn_give_salary.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_give_salary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_give_salary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_give_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_give_salary.ForeColor = System.Drawing.Color.Snow;
            this.btn_give_salary.Location = new System.Drawing.Point(8, 540);
            this.btn_give_salary.Name = "btn_give_salary";
            this.btn_give_salary.Size = new System.Drawing.Size(226, 35);
            this.btn_give_salary.TabIndex = 26;
            this.btn_give_salary.Text = "GIVE SALARY";
            this.btn_give_salary.UseVisualStyleBackColor = false;
            this.btn_give_salary.Visible = false;
            this.btn_give_salary.Click += new System.EventHandler(this.btn_give_salary_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label_footer);
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
            this.groupBox_left_time.ResumeLayout(false);
            this.groupBox_left_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_left_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_entered_time)).EndInit();
            this.groupBox_entered_time.ResumeLayout(false);
            this.groupBox_entered_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl_management.ResumeLayout(false);
            this.tab_employees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.tab_departments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departments)).EndInit();
            this.tab_attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendencesBindingSource)).EndInit();
            this.tabPage_salaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salaries)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.NumericUpDown numupdwn_salary;
        private System.Windows.Forms.Label label_emp_department;
        private System.Windows.Forms.ComboBox comboBox_department;
        private System.Windows.Forms.DateTimePicker dateTimePicker_join;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birth;
        private System.Windows.Forms.Label label_join;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Button btn_add_emp;
        private System.Windows.Forms.Button btn_delete_emp;
        private System.Windows.Forms.Button btn_update_emp;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TabControl tabControl_management;
        private System.Windows.Forms.TabPage tab_employees;
        private System.Windows.Forms.TabPage tab_departments;
        private System.Windows.Forms.TabPage tab_attendance;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.DataGridView dataGridView_departments;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.Button btn_delete_dapartment;
        private System.Windows.Forms.Button btn_update_department;
        private System.Windows.Forms.Button btn_add_department;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dataGridView_attendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker_current_date;
        private System.Windows.Forms.Label label_current_date;
        private System.Windows.Forms.NumericUpDown numericUpDown_left_time;
        private System.Windows.Forms.Label label_left_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_entered_time;
        private System.Windows.Forms.Label label_entered_time;
        private System.Windows.Forms.ComboBox comboBox_employee_name;
        private System.Windows.Forms.RadioButton radioButton_entered_pm;
        private System.Windows.Forms.RadioButton radioButton_entered_am;
        private System.Windows.Forms.RadioButton radioButton_left_pm;
        private System.Windows.Forms.RadioButton radioButton_left_am;
        private System.Windows.Forms.GroupBox groupBox_entered_time;
        private System.Windows.Forms.GroupBox groupBox_left_time;
        private System.Windows.Forms.Button btn_add_attendance;
        private System.Windows.Forms.TabPage tabPage_salaries;
        private System.Windows.Forms.DataGridView dataGridView_salaries;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EMSDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource attendencesBindingSource;
        private EMSDataSetTableAdapters.attendencesTableAdapter attendencesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeenteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeleftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_footer;
        private System.Windows.Forms.Label label_total_salary;
        private System.Windows.Forms.TextBox txt_total_salary;
        private System.Windows.Forms.Button btn_give_salary;
    }
}