namespace StaffSetu
{
    partial class UserWiseSalary
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
            this.lb_UserwiseSalaryReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.TxtStaffId = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dataGridViewSalary = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_UserwiseSalaryReport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_UserwiseSalaryReport
            // 
            this.lb_UserwiseSalaryReport.BackColor = System.Drawing.Color.LightCoral;
            this.lb_UserwiseSalaryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_UserwiseSalaryReport.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_UserwiseSalaryReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_UserwiseSalaryReport.Location = new System.Drawing.Point(3, 0);
            this.lb_UserwiseSalaryReport.Name = "lb_UserwiseSalaryReport";
            this.lb_UserwiseSalaryReport.Size = new System.Drawing.Size(1002, 58);
            this.lb_UserwiseSalaryReport.TabIndex = 3;
            this.lb_UserwiseSalaryReport.Text = "User Salary Report";
            this.lb_UserwiseSalaryReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtStaffId, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblYear, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CmbYear, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnSearch, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewSalary, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 666);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblID.Location = new System.Drawing.Point(23, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(190, 58);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtStaffId
            // 
            this.TxtStaffId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStaffId.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtStaffId.Location = new System.Drawing.Point(219, 22);
            this.TxtStaffId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtStaffId.Name = "TxtStaffId";
            this.TxtStaffId.Size = new System.Drawing.Size(288, 32);
            this.TxtStaffId.TabIndex = 6;
            this.TxtStaffId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtStaffId_Validating);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblYear.Location = new System.Drawing.Point(23, 78);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(190, 58);
            this.lblYear.TabIndex = 39;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbYear
            // 
            this.CmbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbYear.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Location = new System.Drawing.Point(219, 81);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(288, 33);
            this.CmbYear.TabIndex = 38;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Font = new System.Drawing.Font("Merriweather Black", 9F);
            this.BtnSearch.Location = new System.Drawing.Point(219, 138);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Size = new System.Drawing.Size(124, 44);
            this.BtnSearch.TabIndex = 34;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridViewSalary
            // 
            this.dataGridViewSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewSalary, 3);
            this.dataGridViewSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalary.Location = new System.Drawing.Point(23, 197);
            this.dataGridViewSalary.Name = "dataGridViewSalary";
            this.dataGridViewSalary.RowHeadersWidth = 62;
            this.dataGridViewSalary.RowTemplate.Height = 28;
            this.dataGridViewSalary.Size = new System.Drawing.Size(976, 466);
            this.dataGridViewSalary.TabIndex = 40;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserWiseSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserWiseSalary";
            this.Text = "UserWiseSalary";
            this.Load += new System.EventHandler(this.UserWiseSalary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_UserwiseSalaryReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox TxtStaffId;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView dataGridViewSalary;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}