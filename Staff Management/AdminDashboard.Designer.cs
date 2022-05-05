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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterToolStripMenuItem,
            this.AttendenceToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MasterToolStripMenuItem
            // 
            this.MasterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.MasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem,
            this.DeaprtmentToolStripMenuItem,
            this.DesignationToolStripMenuItem,
            this.SubjectToolStripMenuItem1});
            this.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
            this.MasterToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.MasterToolStripMenuItem.Text = "Master";
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.StaffToolStripMenuItem.Text = "Staff";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // DeaprtmentToolStripMenuItem
            // 
            this.DeaprtmentToolStripMenuItem.Name = "DeaprtmentToolStripMenuItem";
            this.DeaprtmentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DeaprtmentToolStripMenuItem.Text = "Department";
            this.DeaprtmentToolStripMenuItem.Click += new System.EventHandler(this.DeaprtmentToolStripMenuItem_Click);
            // 
            // DesignationToolStripMenuItem
            // 
            this.DesignationToolStripMenuItem.Name = "DesignationToolStripMenuItem";
            this.DesignationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DesignationToolStripMenuItem.Text = "Designation";
            this.DesignationToolStripMenuItem.Click += new System.EventHandler(this.DesignationToolStripMenuItem_Click);
            // 
            // SubjectToolStripMenuItem1
            // 
            this.SubjectToolStripMenuItem1.Name = "SubjectToolStripMenuItem1";
            this.SubjectToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
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
            this.AttendenceToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.AttendenceToolStripMenuItem.Text = "Attendence";
            // 
            // MarkAttendenceToolStripMenuItem
            // 
            this.MarkAttendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkIndividualAttendenceToolStripMenuItem,
            this.MarkMultipleAttendenceToolStripMenuItem});
            this.MarkAttendenceToolStripMenuItem.Name = "MarkAttendenceToolStripMenuItem";
            this.MarkAttendenceToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MarkAttendenceToolStripMenuItem.Text = "Mark ";
            // 
            // MarkIndividualAttendenceToolStripMenuItem
            // 
            this.MarkIndividualAttendenceToolStripMenuItem.Name = "MarkIndividualAttendenceToolStripMenuItem";
            this.MarkIndividualAttendenceToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MarkIndividualAttendenceToolStripMenuItem.Text = "Individual";
            this.MarkIndividualAttendenceToolStripMenuItem.Click += new System.EventHandler(this.MarkIndividualAttendenceToolStripMenuItem_Click);
            // 
            // MarkMultipleAttendenceToolStripMenuItem
            // 
            this.MarkMultipleAttendenceToolStripMenuItem.Name = "MarkMultipleAttendenceToolStripMenuItem";
            this.MarkMultipleAttendenceToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MarkMultipleAttendenceToolStripMenuItem.Text = "Multiple";
            this.MarkMultipleAttendenceToolStripMenuItem.Click += new System.EventHandler(this.MarkMultipleAttendenceToolStripMenuItem_Click);
            // 
            // AttendenceRulesToolStripMenuItem
            // 
            this.AttendenceRulesToolStripMenuItem.Name = "AttendenceRulesToolStripMenuItem";
            this.AttendenceRulesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.AttendenceRulesToolStripMenuItem.Text = "Rules";
            this.AttendenceRulesToolStripMenuItem.Click += new System.EventHandler(this.AttendenceRulesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userwiseToolStripMenuItem,
            this.monthwiseToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // userwiseToolStripMenuItem
            // 
            this.userwiseToolStripMenuItem.Name = "userwiseToolStripMenuItem";
            this.userwiseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.userwiseToolStripMenuItem.Text = "User-wise";
            // 
            // monthwiseToolStripMenuItem
            // 
            this.monthwiseToolStripMenuItem.Name = "monthwiseToolStripMenuItem";
            this.monthwiseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.monthwiseToolStripMenuItem.Text = "Month-wise";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 905);
            this.panel1.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1362, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}