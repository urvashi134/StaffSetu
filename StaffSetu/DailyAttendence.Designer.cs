namespace Staff_Management
{
    partial class DailyAttendence
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_MarkDailyAttendence = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.Lb_AddUserReg_FingerprintImpression = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.DtToday = new System.Windows.Forms.DateTimePicker();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.rdBtnAbsent = new System.Windows.Forms.RadioButton();
            this.rdBtnPresent = new System.Windows.Forms.RadioButton();
            this.rdBtnLeave = new System.Windows.Forms.RadioButton();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.PictureBx_AddUserReg_FingerprintImpression = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBx_AddUserReg_FingerprintImpression)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_MarkDailyAttendence, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1512, 1050);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_MarkDailyAttendence
            // 
            this.lb_MarkDailyAttendence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_MarkDailyAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MarkDailyAttendence.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_MarkDailyAttendence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MarkDailyAttendence.Location = new System.Drawing.Point(3, 0);
            this.lb_MarkDailyAttendence.Name = "lb_MarkDailyAttendence";
            this.lb_MarkDailyAttendence.Size = new System.Drawing.Size(1506, 84);
            this.lb_MarkDailyAttendence.TabIndex = 1;
            this.lb_MarkDailyAttendence.Text = "Daily Attendence";
            this.lb_MarkDailyAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStaffID, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Lb_AddUserReg_FingerprintImpression, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblStartTime, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblEndTime, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.DtToday, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtStaffID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.rdBtnAbsent, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rdBtnPresent, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.rdBtnLeave, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.timeStart, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.timeEnd, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.PictureBx_AddUserReg_FingerprintImpression, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1506, 960);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(370, 57);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStaffID.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblStaffID.Location = new System.Drawing.Point(3, 57);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(370, 57);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Staff ID";
            this.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_AddUserReg_FingerprintImpression
            // 
            this.Lb_AddUserReg_FingerprintImpression.AutoSize = true;
            this.Lb_AddUserReg_FingerprintImpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_AddUserReg_FingerprintImpression.Font = new System.Drawing.Font("Merriweather", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AddUserReg_FingerprintImpression.Location = new System.Drawing.Point(4, 114);
            this.Lb_AddUserReg_FingerprintImpression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_AddUserReg_FingerprintImpression.Name = "Lb_AddUserReg_FingerprintImpression";
            this.tableLayoutPanel2.SetRowSpan(this.Lb_AddUserReg_FingerprintImpression, 2);
            this.Lb_AddUserReg_FingerprintImpression.Size = new System.Drawing.Size(368, 114);
            this.Lb_AddUserReg_FingerprintImpression.TabIndex = 36;
            this.Lb_AddUserReg_FingerprintImpression.Text = "Fingerprint Impression";
            this.Lb_AddUserReg_FingerprintImpression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblStatus.Location = new System.Drawing.Point(3, 228);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(370, 57);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartTime.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblStartTime.Location = new System.Drawing.Point(3, 285);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(370, 57);
            this.lblStartTime.TabIndex = 38;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndTime.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblEndTime.Location = new System.Drawing.Point(3, 342);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(370, 57);
            this.lblEndTime.TabIndex = 39;
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtToday
            // 
            this.DtToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtToday.Font = new System.Drawing.Font("Merriweather", 10.25F);
            this.DtToday.Location = new System.Drawing.Point(379, 2);
            this.DtToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtToday.Name = "DtToday";
            this.DtToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtToday.Size = new System.Drawing.Size(370, 33);
            this.DtToday.TabIndex = 40;
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStaffID.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtStaffID.Location = new System.Drawing.Point(379, 59);
            this.TxtStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(370, 32);
            this.TxtStaffID.TabIndex = 41;
            this.TxtStaffID.Leave += new System.EventHandler(this.TxtStaffID_Leave);
            this.TxtStaffID.Validating += new System.ComponentModel.CancelEventHandler(this.TxtStaffID_Validating);
            // 
            // rdBtnAbsent
            // 
            this.rdBtnAbsent.AutoSize = true;
            this.rdBtnAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdBtnAbsent.Font = new System.Drawing.Font("Merriweather", 8.249999F);
            this.rdBtnAbsent.Location = new System.Drawing.Point(380, 232);
            this.rdBtnAbsent.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnAbsent.Name = "rdBtnAbsent";
            this.rdBtnAbsent.Size = new System.Drawing.Size(368, 49);
            this.rdBtnAbsent.TabIndex = 43;
            this.rdBtnAbsent.Text = "Absent";
            this.rdBtnAbsent.UseVisualStyleBackColor = true;
            // 
            // rdBtnPresent
            // 
            this.rdBtnPresent.AutoSize = true;
            this.rdBtnPresent.Checked = true;
            this.rdBtnPresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdBtnPresent.Font = new System.Drawing.Font("Merriweather", 8.249999F);
            this.rdBtnPresent.Location = new System.Drawing.Point(756, 232);
            this.rdBtnPresent.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnPresent.Name = "rdBtnPresent";
            this.rdBtnPresent.Size = new System.Drawing.Size(368, 49);
            this.rdBtnPresent.TabIndex = 42;
            this.rdBtnPresent.TabStop = true;
            this.rdBtnPresent.Text = "Present";
            this.rdBtnPresent.UseVisualStyleBackColor = true;
            this.rdBtnPresent.CheckedChanged += new System.EventHandler(this.rdBtnPresent_CheckedChanged);
            // 
            // rdBtnLeave
            // 
            this.rdBtnLeave.AutoSize = true;
            this.rdBtnLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdBtnLeave.Font = new System.Drawing.Font("Merriweather", 8.249999F);
            this.rdBtnLeave.Location = new System.Drawing.Point(1132, 232);
            this.rdBtnLeave.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnLeave.Name = "rdBtnLeave";
            this.rdBtnLeave.Size = new System.Drawing.Size(370, 49);
            this.rdBtnLeave.TabIndex = 44;
            this.rdBtnLeave.Text = "On Leave";
            this.rdBtnLeave.UseVisualStyleBackColor = true;
            // 
            // timeStart
            // 
            this.timeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeStart.Font = new System.Drawing.Font("Merriweather", 10.25F);
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(379, 287);
            this.timeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(370, 33);
            this.timeStart.TabIndex = 45;
            // 
            // timeEnd
            // 
            this.timeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeEnd.Font = new System.Drawing.Font("Merriweather", 10.25F);
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(379, 344);
            this.timeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(370, 33);
            this.timeEnd.TabIndex = 46;
            // 
            // PictureBx_AddUserReg_FingerprintImpression
            // 
            this.PictureBx_AddUserReg_FingerprintImpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBx_AddUserReg_FingerprintImpression.Location = new System.Drawing.Point(380, 119);
            this.PictureBx_AddUserReg_FingerprintImpression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBx_AddUserReg_FingerprintImpression.Name = "PictureBx_AddUserReg_FingerprintImpression";
            this.tableLayoutPanel2.SetRowSpan(this.PictureBx_AddUserReg_FingerprintImpression, 2);
            this.PictureBx_AddUserReg_FingerprintImpression.Size = new System.Drawing.Size(368, 104);
            this.PictureBx_AddUserReg_FingerprintImpression.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBx_AddUserReg_FingerprintImpression.TabIndex = 47;
            this.PictureBx_AddUserReg_FingerprintImpression.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnReset, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(379, 459);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 498);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.BackColor = System.Drawing.Color.Azure;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Merriweather Black", 10F);
            this.BtnSave.Location = new System.Drawing.Point(3, 33);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 58);
            this.BtnSave.TabIndex = 122;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Azure;
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Font = new System.Drawing.Font("Merriweather Black", 10F);
            this.BtnReset.Location = new System.Drawing.Point(168, 33);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(144, 58);
            this.BtnReset.TabIndex = 127;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DailyAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 1050);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DailyAttendence";
            this.Text = "DailyAttendence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_attendence_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBx_AddUserReg_FingerprintImpression)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_MarkDailyAttendence;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label Lb_AddUserReg_FingerprintImpression;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker DtToday;
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.RadioButton rdBtnAbsent;
        private System.Windows.Forms.RadioButton rdBtnPresent;
        private System.Windows.Forms.RadioButton rdBtnLeave;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.PictureBox PictureBx_AddUserReg_FingerprintImpression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}