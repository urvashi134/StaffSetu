namespace Staff_Management
{
    partial class Attendence_Rules
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.dataGridViewAttendenceRules = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSalaryCalDays = new System.Windows.Forms.TextBox();
            this.rdBtnMonthly = new System.Windows.Forms.RadioButton();
            this.rdBtnDaywise = new System.Windows.Forms.RadioButton();
            this.lblSalaryCalculation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoursDays = new System.Windows.Forms.Label();
            this.numWorkingHours = new System.Windows.Forms.NumericUpDown();
            this.rdBtnHours = new System.Windows.Forms.RadioButton();
            this.rdBtnDays = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.numLeaves = new System.Windows.Forms.NumericUpDown();
            this.CmbDesg = new System.Windows.Forms.ComboBox();
            this.TxtRuleName = new System.Windows.Forms.TextBox();
            this.lblLeaveAllowed = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSalaryCalDaysUpdate = new System.Windows.Forms.TextBox();
            this.rdBtnMonthlyUpdate = new System.Windows.Forms.RadioButton();
            this.rdBtnDaywiseUpdate = new System.Windows.Forms.RadioButton();
            this.lblUpdateSalaryCalculation = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUpdateHoursDays = new System.Windows.Forms.Label();
            this.numWorkingHoursUpdate = new System.Windows.Forms.NumericUpDown();
            this.rdBtnHoursUpdate = new System.Windows.Forms.RadioButton();
            this.rdBtnDaysUpdate = new System.Windows.Forms.RadioButton();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbDesgUpdate = new System.Windows.Forms.ComboBox();
            this.lblUpdateDesignation = new System.Windows.Forms.Label();
            this.BtnResetUpdatePage = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.numLeavesUpdate = new System.Windows.Forms.NumericUpDown();
            this.TxtRuleNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateLeaveAllowed = new System.Windows.Forms.Label();
            this.lblUpdateRuleName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendenceRules)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeaves)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHoursUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeavesUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 360);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.dataGridViewAttendenceRules);
            this.tabPageView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageView.Location = new System.Drawing.Point(4, 26);
            this.tabPageView.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageView.Size = new System.Drawing.Size(946, 330);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "View";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendenceRules
            // 
            this.dataGridViewAttendenceRules.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAttendenceRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendenceRules.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewAttendenceRules.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAttendenceRules.Name = "dataGridViewAttendenceRules";
            this.dataGridViewAttendenceRules.RowHeadersWidth = 62;
            this.dataGridViewAttendenceRules.RowTemplate.Height = 33;
            this.dataGridViewAttendenceRules.Size = new System.Drawing.Size(942, 362);
            this.dataGridViewAttendenceRules.TabIndex = 5;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAdd.Controls.Add(this.panel2);
            this.tabPageAdd.Controls.Add(this.panel1);
            this.tabPageAdd.Controls.Add(this.BtnReset);
            this.tabPageAdd.Controls.Add(this.BtnSave);
            this.tabPageAdd.Controls.Add(this.numLeaves);
            this.tabPageAdd.Controls.Add(this.CmbDesg);
            this.tabPageAdd.Controls.Add(this.TxtRuleName);
            this.tabPageAdd.Controls.Add(this.lblLeaveAllowed);
            this.tabPageAdd.Controls.Add(this.lblDesignation);
            this.tabPageAdd.Controls.Add(this.lblRuleName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 26);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Size = new System.Drawing.Size(946, 366);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtSalaryCalDays);
            this.panel2.Controls.Add(this.rdBtnMonthly);
            this.panel2.Controls.Add(this.rdBtnDaywise);
            this.panel2.Controls.Add(this.lblSalaryCalculation);
            this.panel2.Location = new System.Drawing.Point(18, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 49);
            this.panel2.TabIndex = 43;
            // 
            // TxtSalaryCalDays
            // 
            this.TxtSalaryCalDays.Location = new System.Drawing.Point(411, 7);
            this.TxtSalaryCalDays.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalaryCalDays.Name = "TxtSalaryCalDays";
            this.TxtSalaryCalDays.Size = new System.Drawing.Size(120, 25);
            this.TxtSalaryCalDays.TabIndex = 44;
            this.TxtSalaryCalDays.Visible = false;
            this.TxtSalaryCalDays.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSalaryCalDays_Validating);
            // 
            // rdBtnMonthly
            // 
            this.rdBtnMonthly.AutoSize = true;
            this.rdBtnMonthly.Location = new System.Drawing.Point(286, 9);
            this.rdBtnMonthly.Name = "rdBtnMonthly";
            this.rdBtnMonthly.Size = new System.Drawing.Size(80, 23);
            this.rdBtnMonthly.TabIndex = 4;
            this.rdBtnMonthly.TabStop = true;
            this.rdBtnMonthly.Text = "Monthly";
            this.rdBtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rdBtnDaywise
            // 
            this.rdBtnDaywise.AutoSize = true;
            this.rdBtnDaywise.Location = new System.Drawing.Point(192, 10);
            this.rdBtnDaywise.Name = "rdBtnDaywise";
            this.rdBtnDaywise.Size = new System.Drawing.Size(88, 23);
            this.rdBtnDaywise.TabIndex = 3;
            this.rdBtnDaywise.TabStop = true;
            this.rdBtnDaywise.Text = "Day-Wise";
            this.rdBtnDaywise.UseVisualStyleBackColor = true;
            this.rdBtnDaywise.CheckedChanged += new System.EventHandler(this.rdBtnDaywise_CheckedChanged);
            // 
            // lblSalaryCalculation
            // 
            this.lblSalaryCalculation.AutoSize = true;
            this.lblSalaryCalculation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalaryCalculation.Location = new System.Drawing.Point(2, 13);
            this.lblSalaryCalculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalaryCalculation.Name = "lblSalaryCalculation";
            this.lblSalaryCalculation.Size = new System.Drawing.Size(116, 19);
            this.lblSalaryCalculation.TabIndex = 2;
            this.lblSalaryCalculation.Text = "Salary Calculation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHoursDays);
            this.panel1.Controls.Add(this.numWorkingHours);
            this.panel1.Controls.Add(this.rdBtnHours);
            this.panel1.Controls.Add(this.rdBtnDays);
            this.panel1.Location = new System.Drawing.Point(18, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 47);
            this.panel1.TabIndex = 42;
            // 
            // lblHoursDays
            // 
            this.lblHoursDays.AutoSize = true;
            this.lblHoursDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoursDays.Location = new System.Drawing.Point(2, 19);
            this.lblHoursDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursDays.Name = "lblHoursDays";
            this.lblHoursDays.Size = new System.Drawing.Size(145, 19);
            this.lblHoursDays.TabIndex = 3;
            this.lblHoursDays.Text = "Working Hours / Days";
            // 
            // numWorkingHours
            // 
            this.numWorkingHours.Location = new System.Drawing.Point(411, 17);
            this.numWorkingHours.Name = "numWorkingHours";
            this.numWorkingHours.Size = new System.Drawing.Size(120, 25);
            this.numWorkingHours.TabIndex = 41;
            this.numWorkingHours.Visible = false;
            // 
            // rdBtnHours
            // 
            this.rdBtnHours.AutoSize = true;
            this.rdBtnHours.Location = new System.Drawing.Point(192, 17);
            this.rdBtnHours.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnHours.Name = "rdBtnHours";
            this.rdBtnHours.Size = new System.Drawing.Size(64, 23);
            this.rdBtnHours.TabIndex = 15;
            this.rdBtnHours.TabStop = true;
            this.rdBtnHours.Text = "Hours";
            this.rdBtnHours.UseVisualStyleBackColor = true;
            this.rdBtnHours.CheckedChanged += new System.EventHandler(this.rdBtnHours_CheckedChanged);
            // 
            // rdBtnDays
            // 
            this.rdBtnDays.AutoSize = true;
            this.rdBtnDays.Location = new System.Drawing.Point(286, 17);
            this.rdBtnDays.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnDays.Name = "rdBtnDays";
            this.rdBtnDays.Size = new System.Drawing.Size(57, 23);
            this.rdBtnDays.TabIndex = 20;
            this.rdBtnDays.TabStop = true;
            this.rdBtnDays.Text = "Days";
            this.rdBtnDays.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(172, 246);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(78, 27);
            this.BtnReset.TabIndex = 40;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(42, 246);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(78, 27);
            this.BtnSave.TabIndex = 35;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numLeaves
            // 
            this.numLeaves.Location = new System.Drawing.Point(217, 199);
            this.numLeaves.Margin = new System.Windows.Forms.Padding(2);
            this.numLeaves.Name = "numLeaves";
            this.numLeaves.Size = new System.Drawing.Size(173, 25);
            this.numLeaves.TabIndex = 30;
            // 
            // CmbDesg
            // 
            this.CmbDesg.FormattingEnabled = true;
            this.CmbDesg.Location = new System.Drawing.Point(217, 52);
            this.CmbDesg.Margin = new System.Windows.Forms.Padding(2);
            this.CmbDesg.Name = "CmbDesg";
            this.CmbDesg.Size = new System.Drawing.Size(175, 25);
            this.CmbDesg.TabIndex = 10;
            // 
            // TxtRuleName
            // 
            this.TxtRuleName.Location = new System.Drawing.Point(217, 21);
            this.TxtRuleName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRuleName.Name = "TxtRuleName";
            this.TxtRuleName.Size = new System.Drawing.Size(175, 25);
            this.TxtRuleName.TabIndex = 5;
            this.TxtRuleName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRuleName_Validating);
            // 
            // lblLeaveAllowed
            // 
            this.lblLeaveAllowed.AutoSize = true;
            this.lblLeaveAllowed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveAllowed.Location = new System.Drawing.Point(18, 201);
            this.lblLeaveAllowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveAllowed.Name = "lblLeaveAllowed";
            this.lblLeaveAllowed.Size = new System.Drawing.Size(102, 19);
            this.lblLeaveAllowed.TabIndex = 4;
            this.lblLeaveAllowed.Text = "Leaves Allowed";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesignation.Location = new System.Drawing.Point(18, 49);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(82, 19);
            this.lblDesignation.TabIndex = 2;
            this.lblDesignation.Text = "Designation";
            // 
            // lblRuleName
            // 
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRuleName.Location = new System.Drawing.Point(18, 19);
            this.lblRuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(75, 19);
            this.lblRuleName.TabIndex = 0;
            this.lblRuleName.Text = "Rule Name";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUpdate.Controls.Add(this.panel3);
            this.tabPageUpdate.Controls.Add(this.panel4);
            this.tabPageUpdate.Controls.Add(this.BtnSearch);
            this.tabPageUpdate.Controls.Add(this.CmbDesgUpdate);
            this.tabPageUpdate.Controls.Add(this.lblUpdateDesignation);
            this.tabPageUpdate.Controls.Add(this.BtnResetUpdatePage);
            this.tabPageUpdate.Controls.Add(this.BtnUpdate);
            this.tabPageUpdate.Controls.Add(this.numLeavesUpdate);
            this.tabPageUpdate.Controls.Add(this.TxtRuleNameUpdate);
            this.tabPageUpdate.Controls.Add(this.lblUpdateLeaveAllowed);
            this.tabPageUpdate.Controls.Add(this.lblUpdateRuleName);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(946, 366);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtSalaryCalDaysUpdate);
            this.panel3.Controls.Add(this.rdBtnMonthlyUpdate);
            this.panel3.Controls.Add(this.rdBtnDaywiseUpdate);
            this.panel3.Controls.Add(this.lblUpdateSalaryCalculation);
            this.panel3.Location = new System.Drawing.Point(24, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 49);
            this.panel3.TabIndex = 52;
            // 
            // TxtSalaryCalDaysUpdate
            // 
            this.TxtSalaryCalDaysUpdate.Location = new System.Drawing.Point(411, 7);
            this.TxtSalaryCalDaysUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalaryCalDaysUpdate.Name = "TxtSalaryCalDaysUpdate";
            this.TxtSalaryCalDaysUpdate.Size = new System.Drawing.Size(120, 25);
            this.TxtSalaryCalDaysUpdate.TabIndex = 44;
            this.TxtSalaryCalDaysUpdate.Text = "0";
            this.TxtSalaryCalDaysUpdate.Visible = false;
            // 
            // rdBtnMonthlyUpdate
            // 
            this.rdBtnMonthlyUpdate.AutoSize = true;
            this.rdBtnMonthlyUpdate.Location = new System.Drawing.Point(286, 9);
            this.rdBtnMonthlyUpdate.Name = "rdBtnMonthlyUpdate";
            this.rdBtnMonthlyUpdate.Size = new System.Drawing.Size(80, 23);
            this.rdBtnMonthlyUpdate.TabIndex = 4;
            this.rdBtnMonthlyUpdate.TabStop = true;
            this.rdBtnMonthlyUpdate.Text = "Monthly";
            this.rdBtnMonthlyUpdate.UseVisualStyleBackColor = true;
            // 
            // rdBtnDaywiseUpdate
            // 
            this.rdBtnDaywiseUpdate.AutoSize = true;
            this.rdBtnDaywiseUpdate.Location = new System.Drawing.Point(192, 10);
            this.rdBtnDaywiseUpdate.Name = "rdBtnDaywiseUpdate";
            this.rdBtnDaywiseUpdate.Size = new System.Drawing.Size(88, 23);
            this.rdBtnDaywiseUpdate.TabIndex = 3;
            this.rdBtnDaywiseUpdate.TabStop = true;
            this.rdBtnDaywiseUpdate.Text = "Day-Wise";
            this.rdBtnDaywiseUpdate.UseVisualStyleBackColor = true;
            this.rdBtnDaywiseUpdate.CheckedChanged += new System.EventHandler(this.rdBtnDaywiseUpdate_CheckedChanged);
            // 
            // lblUpdateSalaryCalculation
            // 
            this.lblUpdateSalaryCalculation.AutoSize = true;
            this.lblUpdateSalaryCalculation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateSalaryCalculation.Location = new System.Drawing.Point(2, 13);
            this.lblUpdateSalaryCalculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateSalaryCalculation.Name = "lblUpdateSalaryCalculation";
            this.lblUpdateSalaryCalculation.Size = new System.Drawing.Size(116, 19);
            this.lblUpdateSalaryCalculation.TabIndex = 2;
            this.lblUpdateSalaryCalculation.Text = "Salary Calculation";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblUpdateHoursDays);
            this.panel4.Controls.Add(this.numWorkingHoursUpdate);
            this.panel4.Controls.Add(this.rdBtnHoursUpdate);
            this.panel4.Controls.Add(this.rdBtnDaysUpdate);
            this.panel4.Location = new System.Drawing.Point(24, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 47);
            this.panel4.TabIndex = 51;
            // 
            // lblUpdateHoursDays
            // 
            this.lblUpdateHoursDays.AutoSize = true;
            this.lblUpdateHoursDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateHoursDays.Location = new System.Drawing.Point(2, 19);
            this.lblUpdateHoursDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateHoursDays.Name = "lblUpdateHoursDays";
            this.lblUpdateHoursDays.Size = new System.Drawing.Size(145, 19);
            this.lblUpdateHoursDays.TabIndex = 3;
            this.lblUpdateHoursDays.Text = "Working Hours / Days";
            // 
            // numWorkingHoursUpdate
            // 
            this.numWorkingHoursUpdate.Location = new System.Drawing.Point(411, 17);
            this.numWorkingHoursUpdate.Name = "numWorkingHoursUpdate";
            this.numWorkingHoursUpdate.Size = new System.Drawing.Size(120, 25);
            this.numWorkingHoursUpdate.TabIndex = 41;
            this.numWorkingHoursUpdate.Visible = false;
            // 
            // rdBtnHoursUpdate
            // 
            this.rdBtnHoursUpdate.AutoSize = true;
            this.rdBtnHoursUpdate.Location = new System.Drawing.Point(192, 16);
            this.rdBtnHoursUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnHoursUpdate.Name = "rdBtnHoursUpdate";
            this.rdBtnHoursUpdate.Size = new System.Drawing.Size(64, 23);
            this.rdBtnHoursUpdate.TabIndex = 15;
            this.rdBtnHoursUpdate.TabStop = true;
            this.rdBtnHoursUpdate.Text = "Hours";
            this.rdBtnHoursUpdate.UseVisualStyleBackColor = true;
            this.rdBtnHoursUpdate.CheckedChanged += new System.EventHandler(this.rdBtnHoursUpdate_CheckedChanged);
            // 
            // rdBtnDaysUpdate
            // 
            this.rdBtnDaysUpdate.AutoSize = true;
            this.rdBtnDaysUpdate.Location = new System.Drawing.Point(286, 17);
            this.rdBtnDaysUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnDaysUpdate.Name = "rdBtnDaysUpdate";
            this.rdBtnDaysUpdate.Size = new System.Drawing.Size(57, 23);
            this.rdBtnDaysUpdate.TabIndex = 20;
            this.rdBtnDaysUpdate.TabStop = true;
            this.rdBtnDaysUpdate.Text = "Days";
            this.rdBtnDaysUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(436, 16);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(78, 27);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CmbDesgUpdate
            // 
            this.CmbDesgUpdate.FormattingEnabled = true;
            this.CmbDesgUpdate.Location = new System.Drawing.Point(223, 19);
            this.CmbDesgUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.CmbDesgUpdate.Name = "CmbDesgUpdate";
            this.CmbDesgUpdate.Size = new System.Drawing.Size(175, 25);
            this.CmbDesgUpdate.TabIndex = 5;
            // 
            // lblUpdateDesignation
            // 
            this.lblUpdateDesignation.AutoSize = true;
            this.lblUpdateDesignation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateDesignation.Location = new System.Drawing.Point(24, 16);
            this.lblUpdateDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateDesignation.Name = "lblUpdateDesignation";
            this.lblUpdateDesignation.Size = new System.Drawing.Size(82, 19);
            this.lblUpdateDesignation.TabIndex = 22;
            this.lblUpdateDesignation.Text = "Designation";
            // 
            // BtnResetUpdatePage
            // 
            this.BtnResetUpdatePage.Location = new System.Drawing.Point(174, 248);
            this.BtnResetUpdatePage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResetUpdatePage.Name = "BtnResetUpdatePage";
            this.BtnResetUpdatePage.Size = new System.Drawing.Size(78, 27);
            this.BtnResetUpdatePage.TabIndex = 50;
            this.BtnResetUpdatePage.Text = "Reset";
            this.BtnResetUpdatePage.UseVisualStyleBackColor = true;
            this.BtnResetUpdatePage.Click += new System.EventHandler(this.BtnResetUpdate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(52, 248);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 27);
            this.BtnUpdate.TabIndex = 45;
            this.BtnUpdate.Text = "Save";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnSaveUpdate_Click);
            // 
            // numLeavesUpdate
            // 
            this.numLeavesUpdate.Location = new System.Drawing.Point(223, 201);
            this.numLeavesUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.numLeavesUpdate.Name = "numLeavesUpdate";
            this.numLeavesUpdate.Size = new System.Drawing.Size(173, 25);
            this.numLeavesUpdate.TabIndex = 40;
            // 
            // TxtRuleNameUpdate
            // 
            this.TxtRuleNameUpdate.Location = new System.Drawing.Point(223, 56);
            this.TxtRuleNameUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRuleNameUpdate.Name = "TxtRuleNameUpdate";
            this.TxtRuleNameUpdate.Size = new System.Drawing.Size(175, 25);
            this.TxtRuleNameUpdate.TabIndex = 15;
            // 
            // lblUpdateLeaveAllowed
            // 
            this.lblUpdateLeaveAllowed.AutoSize = true;
            this.lblUpdateLeaveAllowed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateLeaveAllowed.Location = new System.Drawing.Point(28, 203);
            this.lblUpdateLeaveAllowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateLeaveAllowed.Name = "lblUpdateLeaveAllowed";
            this.lblUpdateLeaveAllowed.Size = new System.Drawing.Size(102, 19);
            this.lblUpdateLeaveAllowed.TabIndex = 15;
            this.lblUpdateLeaveAllowed.Text = "Leaves Allowed";
            // 
            // lblUpdateRuleName
            // 
            this.lblUpdateRuleName.AutoSize = true;
            this.lblUpdateRuleName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateRuleName.Location = new System.Drawing.Point(24, 55);
            this.lblUpdateRuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRuleName.Name = "lblUpdateRuleName";
            this.lblUpdateRuleName.Size = new System.Drawing.Size(75, 19);
            this.lblUpdateRuleName.TabIndex = 11;
            this.lblUpdateRuleName.Text = "Rule Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attendence Rules By Designation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Attendence_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Attendence_Rules";
            this.Text = "Attendence Rules";
            this.Load += new System.EventHandler(this.Attendence_Rules_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendenceRules)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeaves)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHoursUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeavesUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.DataGridView dataGridViewAttendenceRules;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblHoursDays;
        private System.Windows.Forms.Label lblLeaveAllowed;
        private System.Windows.Forms.ComboBox CmbDesg;
        private System.Windows.Forms.TextBox TxtRuleName;
        private System.Windows.Forms.NumericUpDown numLeaves;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button tnSearch;
        private System.Windows.Forms.ComboBox CmbDesgUpdate;
        private System.Windows.Forms.Label lblUpdateDesignation;
        private System.Windows.Forms.Button BtnResetUpdatePage;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.NumericUpDown numLeavesUpdate;
        private System.Windows.Forms.TextBox TxtRuleNameUpdate;
        private System.Windows.Forms.Label lblUpdateLeaveAllowed;
        private System.Windows.Forms.Label lblUpdateRuleName;
        private System.Windows.Forms.RadioButton rdBtnDays;
        private System.Windows.Forms.RadioButton rdBtnHours;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numWorkingHours;
        private System.Windows.Forms.Label lblSalaryCalculation;
        private System.Windows.Forms.RadioButton rdBtnDaywise;
        private System.Windows.Forms.RadioButton rdBtnMonthly;
        private System.Windows.Forms.TextBox TxtSalaryCalDays;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtSalaryCalDaysUpdate;
        private System.Windows.Forms.RadioButton rdBtnMonthlyUpdate;
        private System.Windows.Forms.RadioButton rdBtnDaywiseUpdate;
        private System.Windows.Forms.Label lblUpdateSalaryCalculation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUpdateHoursDays;
        private System.Windows.Forms.NumericUpDown numWorkingHoursUpdate;
        private System.Windows.Forms.RadioButton rdBtnHoursUpdate;
        private System.Windows.Forms.RadioButton rdBtnDaysUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
    }
}