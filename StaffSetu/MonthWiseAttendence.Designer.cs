namespace StaffSetu
{
    partial class MonthWiseAttendence
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
            this.lb_MonthAttendenceReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_MonthAttendenceReport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_MonthAttendenceReport
            // 
            this.lb_MonthAttendenceReport.BackColor = System.Drawing.Color.RosyBrown;
            this.lb_MonthAttendenceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MonthAttendenceReport.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_MonthAttendenceReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MonthAttendenceReport.Location = new System.Drawing.Point(3, 0);
            this.lb_MonthAttendenceReport.Name = "lb_MonthAttendenceReport";
            this.lb_MonthAttendenceReport.Size = new System.Drawing.Size(1112, 58);
            this.lb_MonthAttendenceReport.TabIndex = 2;
            this.lb_MonthAttendenceReport.Text = "Monthly Attendence Report";
            this.lb_MonthAttendenceReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblMonth, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblYear, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CmbMonth, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.CmbYear, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnSearch, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1112, 666);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblMonth.Location = new System.Drawing.Point(23, 20);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(208, 58);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblYear.Location = new System.Drawing.Point(23, 78);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(208, 58);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbMonth
            // 
            this.CmbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbMonth.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Location = new System.Drawing.Point(237, 23);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(262, 33);
            this.CmbMonth.TabIndex = 3;
            // 
            // CmbYear
            // 
            this.CmbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbYear.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Location = new System.Drawing.Point(237, 81);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(262, 33);
            this.CmbYear.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Font = new System.Drawing.Font("Merriweather Black", 9F);
            this.BtnSearch.Location = new System.Drawing.Point(525, 80);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Size = new System.Drawing.Size(124, 44);
            this.BtnSearch.TabIndex = 34;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(23, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 524);
            this.dataGridView1.TabIndex = 35;
            // 
            // MonthWiseAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MonthWiseAttendence";
            this.Text = "MonthWiseAttendence";
            this.Load += new System.EventHandler(this.MonthWiseAttendence_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_MonthAttendenceReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}