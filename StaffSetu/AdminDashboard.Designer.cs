using System.Windows.Forms;

namespace Staff_Management
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeaprtmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DesignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkIndividualAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkMultipleAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttendenceRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Merriweather", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterToolStripMenuItem,
            this.AttendenceToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MasterToolStripMenuItem
            // 
            this.MasterToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.MasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem,
            this.DeaprtmentToolStripMenuItem,
            this.DesignationToolStripMenuItem,
            this.SubjectToolStripMenuItem1});
            this.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
            this.MasterToolStripMenuItem.Size = new System.Drawing.Size(115, 37);
            this.MasterToolStripMenuItem.Text = "Master";
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(265, 42);
            this.StaffToolStripMenuItem.Text = "Staff";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // DeaprtmentToolStripMenuItem
            // 
            this.DeaprtmentToolStripMenuItem.Name = "DeaprtmentToolStripMenuItem";
            this.DeaprtmentToolStripMenuItem.Size = new System.Drawing.Size(265, 42);
            this.DeaprtmentToolStripMenuItem.Text = "Department";
            this.DeaprtmentToolStripMenuItem.Click += new System.EventHandler(this.DeaprtmentToolStripMenuItem_Click);
            // 
            // DesignationToolStripMenuItem
            // 
            this.DesignationToolStripMenuItem.Name = "DesignationToolStripMenuItem";
            this.DesignationToolStripMenuItem.Size = new System.Drawing.Size(265, 42);
            this.DesignationToolStripMenuItem.Text = "Designation";
            this.DesignationToolStripMenuItem.Click += new System.EventHandler(this.DesignationToolStripMenuItem_Click);
            // 
            // SubjectToolStripMenuItem1
            // 
            this.SubjectToolStripMenuItem1.Name = "SubjectToolStripMenuItem1";
            this.SubjectToolStripMenuItem1.Size = new System.Drawing.Size(265, 42);
            this.SubjectToolStripMenuItem1.Text = "Subject";
            this.SubjectToolStripMenuItem1.Click += new System.EventHandler(this.SubjectToolStripMenuItem1_Click);
            // 
            // AttendenceToolStripMenuItem
            // 
            this.AttendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkAttendenceToolStripMenuItem,
            this.AttendenceRulesToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.AttendenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem";
            this.AttendenceToolStripMenuItem.Size = new System.Drawing.Size(166, 37);
            this.AttendenceToolStripMenuItem.Text = "Attendence";
            // 
            // MarkAttendenceToolStripMenuItem
            // 
            this.MarkAttendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkIndividualAttendenceToolStripMenuItem,
            this.MarkMultipleAttendenceToolStripMenuItem});
            this.MarkAttendenceToolStripMenuItem.Name = "MarkAttendenceToolStripMenuItem";
            this.MarkAttendenceToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.MarkAttendenceToolStripMenuItem.Text = "Mark ";
            // 
            // MarkIndividualAttendenceToolStripMenuItem
            // 
            this.MarkIndividualAttendenceToolStripMenuItem.Name = "MarkIndividualAttendenceToolStripMenuItem";
            this.MarkIndividualAttendenceToolStripMenuItem.Size = new System.Drawing.Size(243, 42);
            this.MarkIndividualAttendenceToolStripMenuItem.Text = "Individual";
            this.MarkIndividualAttendenceToolStripMenuItem.Click += new System.EventHandler(this.MarkIndividualAttendenceToolStripMenuItem_Click);
            // 
            // MarkMultipleAttendenceToolStripMenuItem
            // 
            this.MarkMultipleAttendenceToolStripMenuItem.Name = "MarkMultipleAttendenceToolStripMenuItem";
            this.MarkMultipleAttendenceToolStripMenuItem.Size = new System.Drawing.Size(243, 42);
            this.MarkMultipleAttendenceToolStripMenuItem.Text = "Multiple";
            this.MarkMultipleAttendenceToolStripMenuItem.Click += new System.EventHandler(this.MarkMultipleAttendenceToolStripMenuItem_Click);
            // 
            // AttendenceRulesToolStripMenuItem
            // 
            this.AttendenceRulesToolStripMenuItem.Name = "AttendenceRulesToolStripMenuItem";
            this.AttendenceRulesToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.AttendenceRulesToolStripMenuItem.Text = "Rules";
            this.AttendenceRulesToolStripMenuItem.Click += new System.EventHandler(this.AttendenceRulesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userwiseToolStripMenuItem,
            this.monthwiseToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // userwiseToolStripMenuItem
            // 
            this.userwiseToolStripMenuItem.Name = "userwiseToolStripMenuItem";
            this.userwiseToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.userwiseToolStripMenuItem.Text = "User-wise";
            this.userwiseToolStripMenuItem.Click += new System.EventHandler(this.userwiseToolStripMenuItem_Click);
            // 
            // monthwiseToolStripMenuItem
            // 
            this.monthwiseToolStripMenuItem.Name = "monthwiseToolStripMenuItem";
            this.monthwiseToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.monthwiseToolStripMenuItem.Text = "Month-wise";
            this.monthwiseToolStripMenuItem.Click += new System.EventHandler(this.monthwiseToolStripMenuItem_Click);
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(100, 37);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(106, 37);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 664);
            this.panel1.TabIndex = 1;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.lblLoginName.Font = new System.Drawing.Font("Merriweather", 11F, System.Drawing.FontStyle.Bold);
            this.lblLoginName.Location = new System.Drawing.Point(1362, 7);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(0, 29);
            this.lblLoginName.TabIndex = 2;
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 708);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MasterToolStripMenuItem;
        private ToolStripMenuItem AttendenceToolStripMenuItem;
        private ToolStripMenuItem StaffToolStripMenuItem;
        private ToolStripMenuItem DeaprtmentToolStripMenuItem;
        private ToolStripMenuItem DesignationToolStripMenuItem;
        private ToolStripMenuItem leaveToolStripMenuItem;
        private ToolStripMenuItem SubjectToolStripMenuItem1;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem MarkAttendenceToolStripMenuItem;
        private ToolStripMenuItem AttendenceRulesToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem MarkIndividualAttendenceToolStripMenuItem;
        private ToolStripMenuItem MarkMultipleAttendenceToolStripMenuItem;
        private ToolStripMenuItem userwiseToolStripMenuItem;
        private ToolStripMenuItem monthwiseToolStripMenuItem;
        private Label lblLoginName;
        private TableLayoutPanel tableLayoutPanel1;
    }
}