using System.Windows.Forms;

namespace Staff_Management
{
    partial class Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.DataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDeptLocation = new System.Windows.Forms.TextBox();
            this.TxtDeptName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnResetUpdatePage = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtLocationUpdate = new System.Windows.Forms.TextBox();
            this.TxtNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateLocation = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtIDUpdate = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageView
            // 
            this.tabPageView.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageView.Controls.Add(this.DataGridViewDepartment);
            this.tabPageView.Location = new System.Drawing.Point(4, 37);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1104, 643);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "View";
            // 
            // DataGridViewDepartment
            // 
            this.DataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewDepartment.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDepartment.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDepartment.Location = new System.Drawing.Point(25, 35);
            this.DataGridViewDepartment.Name = "DataGridViewDepartment";
            this.DataGridViewDepartment.ReadOnly = true;
            this.DataGridViewDepartment.RowHeadersWidth = 62;
            this.DataGridViewDepartment.RowTemplate.Height = 33;
            this.DataGridViewDepartment.Size = new System.Drawing.Size(851, 499);
            this.DataGridViewDepartment.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageAdd.Controls.Add(this.BtnReset);
            this.tabPageAdd.Controls.Add(this.BtnSave);
            this.tabPageAdd.Controls.Add(this.TxtDeptLocation);
            this.tabPageAdd.Controls.Add(this.TxtDeptName);
            this.tabPageAdd.Controls.Add(this.lblLocation);
            this.tabPageAdd.Controls.Add(this.LblName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 37);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1104, 643);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Azure;
            this.BtnReset.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(217, 266);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Padding = new System.Windows.Forms.Padding(5);
            this.BtnReset.Size = new System.Drawing.Size(112, 46);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Azure;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(61, 266);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5);
            this.BtnSave.Size = new System.Drawing.Size(112, 46);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtDeptLocation
            // 
            this.TxtDeptLocation.Location = new System.Drawing.Point(137, 146);
            this.TxtDeptLocation.Multiline = true;
            this.TxtDeptLocation.Name = "TxtDeptLocation";
            this.TxtDeptLocation.Size = new System.Drawing.Size(288, 67);
            this.TxtDeptLocation.TabIndex = 5;
            this.TxtDeptLocation.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDeptLocation_Validating);
            // 
            // TxtDeptName
            // 
            this.TxtDeptName.Location = new System.Drawing.Point(137, 83);
            this.TxtDeptName.Name = "TxtDeptName";
            this.TxtDeptName.Size = new System.Drawing.Size(288, 32);
            this.TxtDeptName.TabIndex = 4;
            this.TxtDeptName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDeptName_Validating);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(29, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(93, 28);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(29, 83);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(69, 28);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageUpdate.Controls.Add(this.groupBox1);
            this.tabPageUpdate.Controls.Add(this.BtnSearch);
            this.tabPageUpdate.Controls.Add(this.TxtIDUpdate);
            this.tabPageUpdate.Controls.Add(this.lblID);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 37);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(1104, 643);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnResetUpdatePage);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.TxtLocationUpdate);
            this.groupBox1.Controls.Add(this.TxtNameUpdate);
            this.groupBox1.Controls.Add(this.lblUpdateLocation);
            this.groupBox1.Controls.Add(this.lblUpdateName);
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 293);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // BtnResetUpdatePage
            // 
            this.BtnResetUpdatePage.BackColor = System.Drawing.Color.Azure;
            this.BtnResetUpdatePage.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetUpdatePage.Location = new System.Drawing.Point(174, 204);
            this.BtnResetUpdatePage.Name = "BtnResetUpdatePage";
            this.BtnResetUpdatePage.Padding = new System.Windows.Forms.Padding(5);
            this.BtnResetUpdatePage.Size = new System.Drawing.Size(112, 46);
            this.BtnResetUpdatePage.TabIndex = 31;
            this.BtnResetUpdatePage.Text = "Reset";
            this.BtnResetUpdatePage.UseVisualStyleBackColor = false;
            this.BtnResetUpdatePage.Click += new System.EventHandler(this.BtnResetUpdate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(18, 204);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.BtnUpdate.Size = new System.Drawing.Size(112, 46);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtLocationUpdate
            // 
            this.TxtLocationUpdate.Location = new System.Drawing.Point(126, 102);
            this.TxtLocationUpdate.Multiline = true;
            this.TxtLocationUpdate.Name = "TxtLocationUpdate";
            this.TxtLocationUpdate.Size = new System.Drawing.Size(288, 67);
            this.TxtLocationUpdate.TabIndex = 29;
            this.TxtLocationUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLocationUpdate_Validating);
            // 
            // TxtNameUpdate
            // 
            this.TxtNameUpdate.Location = new System.Drawing.Point(126, 38);
            this.TxtNameUpdate.Name = "TxtNameUpdate";
            this.TxtNameUpdate.Size = new System.Drawing.Size(288, 32);
            this.TxtNameUpdate.TabIndex = 28;
            this.TxtNameUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNameUpdate_Validating);
            // 
            // lblUpdateLocation
            // 
            this.lblUpdateLocation.AutoSize = true;
            this.lblUpdateLocation.Location = new System.Drawing.Point(18, 102);
            this.lblUpdateLocation.Name = "lblUpdateLocation";
            this.lblUpdateLocation.Size = new System.Drawing.Size(93, 28);
            this.lblUpdateLocation.TabIndex = 27;
            this.lblUpdateLocation.Text = "Location";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(18, 38);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(69, 28);
            this.lblUpdateName.TabIndex = 26;
            this.lblUpdateName.Text = "Name";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(313, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(5);
            this.BtnSearch.Size = new System.Drawing.Size(112, 46);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtIDUpdate
            // 
            this.TxtIDUpdate.Location = new System.Drawing.Point(137, 34);
            this.TxtIDUpdate.Name = "TxtIDUpdate";
            this.TxtIDUpdate.Size = new System.Drawing.Size(126, 32);
            this.TxtIDUpdate.TabIndex = 5;
            this.TxtIDUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIDUpdate_Validating);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(29, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 28);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1362, 892);
            this.Controls.Add(this.tabControl1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private TabControl tabControl1;
        private TabPage tabPageView;
        private TabPage tabPageAdd;
        private TabPage tabPageUpdate;
        private DataGridView DataGridViewDepartment;
        private Label LblName;
        private Label lblLocation;
        private TextBox TxtDeptLocation;
        private TextBox TxtDeptName;
        private Button BtnSave;
        private Button BtnReset;
        private TextBox TxtIDUpdate;
        private Label lblID;
        private Button BtnSearch;
        private GroupBox groupBox1;
        private Button BtnResetUpdatePage;
        private Button BtnUpdate;
        private TextBox TxtLocationUpdate;
        private TextBox TxtNameUpdate;
        private Label lblUpdateLocation;
        private Label lblUpdateName;
        private ErrorProvider errorProvider1;
    }
}