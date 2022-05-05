namespace Staff_Management
{
    partial class Add_attendence
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnLeave = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rdBtnAbsent = new System.Windows.Forms.RadioButton();
            this.rdBtnPresent = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.DtToday = new System.Windows.Forms.DateTimePicker();
            this.LblMarkAttendence = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.timeEnd);
            this.panel1.Controls.Add(this.timeStart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.TxtStaffID);
            this.panel1.Controls.Add(this.lblStaffID);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.DtToday);
            this.panel1.Controls.Add(this.LblMarkAttendence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 668);
            this.panel1.TabIndex = 0;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(257, 397);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(121, 48);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(253, 315);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(280, 31);
            this.timeEnd.TabIndex = 19;
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(254, 270);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(280, 31);
            this.timeStart.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBtnLeave);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.rdBtnAbsent);
            this.panel2.Controls.Add(this.rdBtnPresent);
            this.panel2.Location = new System.Drawing.Point(26, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 67);
            this.panel2.TabIndex = 17;
            // 
            // rdBtnLeave
            // 
            this.rdBtnLeave.AutoSize = true;
            this.rdBtnLeave.Location = new System.Drawing.Point(429, 13);
            this.rdBtnLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnLeave.Name = "rdBtnLeave";
            this.rdBtnLeave.Size = new System.Drawing.Size(110, 29);
            this.rdBtnLeave.TabIndex = 20;
            this.rdBtnLeave.Text = "On Leave";
            this.rdBtnLeave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 28);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // rdBtnAbsent
            // 
            this.rdBtnAbsent.AutoSize = true;
            this.rdBtnAbsent.Location = new System.Drawing.Point(331, 13);
            this.rdBtnAbsent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnAbsent.Name = "rdBtnAbsent";
            this.rdBtnAbsent.Size = new System.Drawing.Size(93, 29);
            this.rdBtnAbsent.TabIndex = 19;
            this.rdBtnAbsent.Text = "Absent";
            this.rdBtnAbsent.UseVisualStyleBackColor = true;
            // 
            // rdBtnPresent
            // 
            this.rdBtnPresent.AutoSize = true;
            this.rdBtnPresent.Checked = true;
            this.rdBtnPresent.Location = new System.Drawing.Point(231, 13);
            this.rdBtnPresent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnPresent.Name = "rdBtnPresent";
            this.rdBtnPresent.Size = new System.Drawing.Size(95, 29);
            this.rdBtnPresent.TabIndex = 18;
            this.rdBtnPresent.TabStop = true;
            this.rdBtnPresent.Text = "Present";
            this.rdBtnPresent.UseVisualStyleBackColor = true;
            this.rdBtnPresent.CheckedChanged += new System.EventHandler(this.rdBtnPresent_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(53, 397);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 48);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "End Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartTime.Location = new System.Drawing.Point(26, 263);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(100, 28);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "Start Time";
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Location = new System.Drawing.Point(253, 145);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(281, 31);
            this.TxtStaffID.TabIndex = 6;
            this.TxtStaffID.Leave += new System.EventHandler(this.TxtStaffID_Leave);
            this.TxtStaffID.Validating += new System.ComponentModel.CancelEventHandler(this.TxtStaffID_Validating);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStaffID.Location = new System.Drawing.Point(26, 148);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(75, 28);
            this.lblStaffID.TabIndex = 5;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(26, 88);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // DtToday
            // 
            this.DtToday.Location = new System.Drawing.Point(254, 83);
            this.DtToday.Name = "DtToday";
            this.DtToday.Size = new System.Drawing.Size(280, 31);
            this.DtToday.TabIndex = 4;
            // 
            // LblMarkAttendence
            // 
            this.LblMarkAttendence.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblMarkAttendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMarkAttendence.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMarkAttendence.Location = new System.Drawing.Point(0, 0);
            this.LblMarkAttendence.Name = "LblMarkAttendence";
            this.LblMarkAttendence.Size = new System.Drawing.Size(1253, 52);
            this.LblMarkAttendence.TabIndex = 0;
            this.LblMarkAttendence.Text = "Daily Attendence";
            this.LblMarkAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Add_attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1253, 668);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Add_attendence";
            this.Text = "Mark Attendence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_attendence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblMarkAttendence;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DtToday;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton rdBtnPresent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBtnLeave;
        private System.Windows.Forms.RadioButton rdBtnAbsent;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}