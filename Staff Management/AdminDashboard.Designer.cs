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
            this.AttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.leaveToolStripMenuItem});
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
            this.toolStripMenuItem1});
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
            // 
            // DeaprtmentToolStripMenuItem
            // 
            this.DeaprtmentToolStripMenuItem.Name = "DeaprtmentToolStripMenuItem";
            this.DeaprtmentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DeaprtmentToolStripMenuItem.Text = "Department";
            // 
            // DesignationToolStripMenuItem
            // 
            this.DesignationToolStripMenuItem.Name = "DesignationToolStripMenuItem";
            this.DesignationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DesignationToolStripMenuItem.Text = "Designation";
            // 
            // AttendenceToolStripMenuItem
            // 
            this.AttendenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem";
            this.AttendenceToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.AttendenceToolStripMenuItem.Text = "Attendence";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1362, 944);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
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
        private ToolStripMenuItem toolStripMenuItem1;
    }
}