namespace StaffSetu
{
    partial class UserWiseAttendence
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
            this.lb_UserAttendenceReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.TxtStaffId = new System.Windows.Forms.TextBox();
            this.dataGridViewAttendence = new System.Windows.Forms.DataGridView();
            this.lblAttendenceFrom = new System.Windows.Forms.Label();
            this.lblAttendenceTill = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DtAttendenceFrom = new System.Windows.Forms.DateTimePicker();
            this.DtAttendenceTill = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_UserAttendenceReport, 0, 0);
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
            // lb_UserAttendenceReport
            // 
            this.lb_UserAttendenceReport.BackColor = System.Drawing.Color.RosyBrown;
            this.lb_UserAttendenceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_UserAttendenceReport.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_UserAttendenceReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_UserAttendenceReport.Location = new System.Drawing.Point(3, 0);
            this.lb_UserAttendenceReport.Name = "lb_UserAttendenceReport";
            this.lb_UserAttendenceReport.Size = new System.Drawing.Size(1112, 58);
            this.lb_UserAttendenceReport.TabIndex = 1;
            this.lb_UserAttendenceReport.Text = "User Attendence Report";
            this.lb_UserAttendenceReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtStaffId, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewAttendence, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblAttendenceFrom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAttendenceTill, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnSearch, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.DtAttendenceFrom, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.DtAttendenceTill, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1112, 666);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblID.Location = new System.Drawing.Point(23, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(208, 58);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtStaffId
            // 
            this.TxtStaffId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStaffId.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtStaffId.Location = new System.Drawing.Point(237, 22);
            this.TxtStaffId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtStaffId.Name = "TxtStaffId";
            this.TxtStaffId.Size = new System.Drawing.Size(315, 32);
            this.TxtStaffId.TabIndex = 5;
            this.TxtStaffId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtStaffId_Validating_1);
            // 
            // dataGridViewAttendence
            // 
            this.dataGridViewAttendence.AllowUserToAddRows = false;
            this.dataGridViewAttendence.AllowUserToDeleteRows = false;
            this.dataGridViewAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewAttendence, 4);
            this.dataGridViewAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAttendence.Location = new System.Drawing.Point(23, 197);
            this.dataGridViewAttendence.Name = "dataGridViewAttendence";
            this.dataGridViewAttendence.ReadOnly = true;
            this.dataGridViewAttendence.RowHeadersWidth = 62;
            this.dataGridViewAttendence.RowTemplate.Height = 28;
            this.dataGridViewAttendence.Size = new System.Drawing.Size(1086, 466);
            this.dataGridViewAttendence.TabIndex = 6;
            // 
            // lblAttendenceFrom
            // 
            this.lblAttendenceFrom.AutoSize = true;
            this.lblAttendenceFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttendenceFrom.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblAttendenceFrom.Location = new System.Drawing.Point(23, 78);
            this.lblAttendenceFrom.Name = "lblAttendenceFrom";
            this.lblAttendenceFrom.Size = new System.Drawing.Size(208, 58);
            this.lblAttendenceFrom.TabIndex = 34;
            this.lblAttendenceFrom.Text = "From";
            this.lblAttendenceFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendenceTill
            // 
            this.lblAttendenceTill.AutoSize = true;
            this.lblAttendenceTill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttendenceTill.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblAttendenceTill.Location = new System.Drawing.Point(23, 136);
            this.lblAttendenceTill.Name = "lblAttendenceTill";
            this.lblAttendenceTill.Size = new System.Drawing.Size(208, 58);
            this.lblAttendenceTill.TabIndex = 35;
            this.lblAttendenceTill.Text = "To";
            this.lblAttendenceTill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Font = new System.Drawing.Font("Merriweather Black", 9F);
            this.BtnSearch.Location = new System.Drawing.Point(578, 138);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Size = new System.Drawing.Size(124, 44);
            this.BtnSearch.TabIndex = 33;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DtAttendenceFrom
            // 
            this.DtAttendenceFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtAttendenceFrom.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.DtAttendenceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAttendenceFrom.Location = new System.Drawing.Point(237, 81);
            this.DtAttendenceFrom.Name = "DtAttendenceFrom";
            this.DtAttendenceFrom.Size = new System.Drawing.Size(315, 32);
            this.DtAttendenceFrom.TabIndex = 36;
            this.DtAttendenceFrom.Validating += new System.ComponentModel.CancelEventHandler(this.DtAttendenceFrom_Validating);
            // 
            // DtAttendenceTill
            // 
            this.DtAttendenceTill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtAttendenceTill.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.DtAttendenceTill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAttendenceTill.Location = new System.Drawing.Point(237, 139);
            this.DtAttendenceTill.Name = "DtAttendenceTill";
            this.DtAttendenceTill.Size = new System.Drawing.Size(315, 32);
            this.DtAttendenceTill.TabIndex = 37;
            this.DtAttendenceTill.Validating += new System.ComponentModel.CancelEventHandler(this.DtAttendenceTill_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserWiseAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserWiseAttendence";
            this.Text = "UserWiseAttendence";
            this.Load += new System.EventHandler(this.UserWiseAttendence_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_UserAttendenceReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox TxtStaffId;
        private System.Windows.Forms.DataGridView dataGridViewAttendence;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label lblAttendenceFrom;
        private System.Windows.Forms.Label lblAttendenceTill;
        private System.Windows.Forms.DateTimePicker DtAttendenceFrom;
        private System.Windows.Forms.DateTimePicker DtAttendenceTill;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}