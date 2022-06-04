namespace StaffSetu
{
    partial class ConfirmAttendence
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_ConfirmAttendence = new System.Windows.Forms.Label();
            this.dgvConfirmAttendence = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCalculated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmAttendence)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_ConfirmAttendence, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvConfirmAttendence, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_ConfirmAttendence
            // 
            this.lb_ConfirmAttendence.BackColor = System.Drawing.Color.IndianRed;
            this.lb_ConfirmAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ConfirmAttendence.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_ConfirmAttendence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_ConfirmAttendence.Location = new System.Drawing.Point(3, 0);
            this.lb_ConfirmAttendence.Name = "lb_ConfirmAttendence";
            this.lb_ConfirmAttendence.Size = new System.Drawing.Size(1002, 53);
            this.lb_ConfirmAttendence.TabIndex = 1;
            this.lb_ConfirmAttendence.Text = "Confirm Attendence";
            this.lb_ConfirmAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConfirmAttendence
            // 
            this.dgvConfirmAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmAttendence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StaffName,
            this.PresentDays,
            this.AbsentDays,
            this.LeaveDays,
            this.MonthlySalary,
            this.SalaryCalculated});
            this.dgvConfirmAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfirmAttendence.Location = new System.Drawing.Point(3, 96);
            this.dgvConfirmAttendence.Name = "dgvConfirmAttendence";
            this.dgvConfirmAttendence.RowHeadersWidth = 62;
            this.dgvConfirmAttendence.RowTemplate.Height = 28;
            this.dgvConfirmAttendence.Size = new System.Drawing.Size(1002, 568);
            this.dgvConfirmAttendence.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "StaffId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Name";
            this.StaffName.MinimumWidth = 8;
            this.StaffName.Name = "StaffName";
            this.StaffName.Width = 150;
            // 
            // PresentDays
            // 
            this.PresentDays.DataPropertyName = "PresentDays";
            this.PresentDays.HeaderText = "Present Days";
            this.PresentDays.MinimumWidth = 8;
            this.PresentDays.Name = "PresentDays";
            this.PresentDays.Width = 150;
            // 
            // AbsentDays
            // 
            this.AbsentDays.DataPropertyName = "AbsentDays";
            this.AbsentDays.HeaderText = "Absent Days";
            this.AbsentDays.MinimumWidth = 8;
            this.AbsentDays.Name = "AbsentDays";
            this.AbsentDays.Width = 150;
            // 
            // LeaveDays
            // 
            this.LeaveDays.DataPropertyName = "LeaveDays";
            this.LeaveDays.HeaderText = "Leave Days";
            this.LeaveDays.MinimumWidth = 8;
            this.LeaveDays.Name = "LeaveDays";
            this.LeaveDays.Width = 150;
            // 
            // MonthlySalary
            // 
            this.MonthlySalary.DataPropertyName = "MonthlySalary";
            this.MonthlySalary.HeaderText = "Monthly Salary";
            this.MonthlySalary.MinimumWidth = 8;
            this.MonthlySalary.Name = "MonthlySalary";
            this.MonthlySalary.Width = 150;
            // 
            // SalaryCalculated
            // 
            this.SalaryCalculated.DataPropertyName = "SalaryCalculated";
            this.SalaryCalculated.HeaderText = "Salary Calculated";
            this.SalaryCalculated.MinimumWidth = 8;
            this.SalaryCalculated.Name = "SalaryCalculated";
            this.SalaryCalculated.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Controls.Add(this.lblYear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMonth, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Merriweather", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(34, 0);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 34);
            this.lblYear.TabIndex = 28;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Font = new System.Drawing.Font("Merriweather", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(334, 0);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(112, 34);
            this.lblMonth.TabIndex = 41;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConfirmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfirmAttendence";
            this.Text = "ConfirmAttendence";
            this.Load += new System.EventHandler(this.ConfirmAttendence_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmAttendence)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_ConfirmAttendence;
        private System.Windows.Forms.DataGridView dgvConfirmAttendence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCalculated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
    }
}