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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.TxtDeptName = new System.Windows.Forms.TextBox();
            this.TxtDeptLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.TxtIDUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateLocation = new System.Windows.Forms.Label();
            this.TxtNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.TxtLocationUpdate = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnResetUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_DeptMaster = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.tabControl1.Location = new System.Drawing.Point(3, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageView
            // 
            this.tabPageView.BackColor = System.Drawing.Color.Transparent;
            this.tabPageView.Controls.Add(this.tableLayoutPanel2);
            this.tabPageView.Location = new System.Drawing.Point(4, 37);
            this.tabPageView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageView.Size = new System.Drawing.Size(994, 627);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "View";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewDepartment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnQuit, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 623);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DataGridViewDepartment
            // 
            this.DataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.DataGridViewDepartment, 4);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDepartment.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewDepartment.Location = new System.Drawing.Point(3, 2);
            this.DataGridViewDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewDepartment.Name = "DataGridViewDepartment";
            this.DataGridViewDepartment.ReadOnly = true;
            this.DataGridViewDepartment.RowHeadersWidth = 62;
            this.DataGridViewDepartment.RowTemplate.Height = 33;
            this.DataGridViewDepartment.Size = new System.Drawing.Size(982, 575);
            this.DataGridViewDepartment.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Azure;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnDelete.Location = new System.Drawing.Point(771, 581);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Size = new System.Drawing.Size(94, 40);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Azure;
            this.BtnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuit.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnQuit.Location = new System.Drawing.Point(891, 581);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Padding = new System.Windows.Forms.Padding(4);
            this.BtnQuit.Size = new System.Drawing.Size(94, 40);
            this.BtnQuit.TabIndex = 20;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = false;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAdd.Controls.Add(this.tableLayoutPanel3);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 37);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(994, 627);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblLocation, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtDeptName, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtDeptLocation, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.902153F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.823875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.823875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.000196F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.823875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.823875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.80215F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(988, 623);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblName.Location = new System.Drawing.Point(23, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 54);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblLocation.Location = new System.Drawing.Point(23, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(187, 54);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDeptName
            // 
            this.TxtDeptName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDeptName.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtDeptName.Location = new System.Drawing.Point(216, 32);
            this.TxtDeptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDeptName.Name = "TxtDeptName";
            this.TxtDeptName.Size = new System.Drawing.Size(284, 32);
            this.TxtDeptName.TabIndex = 4;
            this.TxtDeptName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDeptName_Validating);
            // 
            // TxtDeptLocation
            // 
            this.TxtDeptLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDeptLocation.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtDeptLocation.Location = new System.Drawing.Point(216, 86);
            this.TxtDeptLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDeptLocation.Multiline = true;
            this.TxtDeptLocation.Name = "TxtDeptLocation";
            this.tableLayoutPanel3.SetRowSpan(this.TxtDeptLocation, 2);
            this.TxtDeptLocation.Size = new System.Drawing.Size(284, 81);
            this.TxtDeptLocation.TabIndex = 5;
            this.TxtDeptLocation.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDeptLocation_Validating);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnReset, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(216, 226);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 48);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Azure;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnSave.Location = new System.Drawing.Point(3, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(4);
            this.BtnSave.Size = new System.Drawing.Size(126, 44);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Azure;
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnReset.Location = new System.Drawing.Point(155, 2);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Padding = new System.Windows.Forms.Padding(4);
            this.BtnReset.Size = new System.Drawing.Size(126, 44);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.Transparent;
            this.tabPageUpdate.Controls.Add(this.tableLayoutPanel5);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 37);
            this.tabPageUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(994, 627);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel5.Controls.Add(this.lblID, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TxtIDUpdate, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblUpdateLocation, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.TxtNameUpdate, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblUpdateName, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.TxtLocationUpdate, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.BtnSearch, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 2, 6);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(994, 627);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblID.Location = new System.Drawing.Point(23, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(194, 54);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIDUpdate
            // 
            this.TxtIDUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtIDUpdate.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtIDUpdate.Location = new System.Drawing.Point(223, 22);
            this.TxtIDUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIDUpdate.Name = "TxtIDUpdate";
            this.TxtIDUpdate.Size = new System.Drawing.Size(295, 32);
            this.TxtIDUpdate.TabIndex = 5;
            this.TxtIDUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIDUpdate_Validating);
            // 
            // lblUpdateLocation
            // 
            this.lblUpdateLocation.AutoSize = true;
            this.lblUpdateLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdateLocation.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblUpdateLocation.Location = new System.Drawing.Point(23, 128);
            this.lblUpdateLocation.Name = "lblUpdateLocation";
            this.lblUpdateLocation.Size = new System.Drawing.Size(194, 54);
            this.lblUpdateLocation.TabIndex = 27;
            this.lblUpdateLocation.Text = "Location";
            this.lblUpdateLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtNameUpdate
            // 
            this.TxtNameUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNameUpdate.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtNameUpdate.Location = new System.Drawing.Point(223, 76);
            this.TxtNameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNameUpdate.Name = "TxtNameUpdate";
            this.TxtNameUpdate.Size = new System.Drawing.Size(295, 32);
            this.TxtNameUpdate.TabIndex = 28;
            this.TxtNameUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNameUpdate_Validating);
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdateName.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblUpdateName.Location = new System.Drawing.Point(23, 74);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(194, 54);
            this.lblUpdateName.TabIndex = 26;
            this.lblUpdateName.Text = "Name";
            this.lblUpdateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtLocationUpdate
            // 
            this.TxtLocationUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLocationUpdate.Location = new System.Drawing.Point(223, 130);
            this.TxtLocationUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtLocationUpdate.Multiline = true;
            this.TxtLocationUpdate.Name = "TxtLocationUpdate";
            this.tableLayoutPanel5.SetRowSpan(this.TxtLocationUpdate, 2);
            this.TxtLocationUpdate.Size = new System.Drawing.Size(295, 80);
            this.TxtLocationUpdate.TabIndex = 29;
            this.TxtLocationUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLocationUpdate_Validating);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnSearch.Location = new System.Drawing.Point(544, 22);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Size = new System.Drawing.Size(124, 50);
            this.BtnSearch.TabIndex = 32;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.BtnUpdate, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BtnResetUpdate, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(223, 269);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(295, 48);
            this.tableLayoutPanel6.TabIndex = 34;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnUpdate.Location = new System.Drawing.Point(3, 2);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Size = new System.Drawing.Size(131, 44);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // BtnResetUpdate
            // 
            this.BtnResetUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtnResetUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnResetUpdate.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnResetUpdate.Location = new System.Drawing.Point(160, 2);
            this.BtnResetUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResetUpdate.Name = "BtnResetUpdate";
            this.BtnResetUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.BtnResetUpdate.Size = new System.Drawing.Size(132, 44);
            this.BtnResetUpdate.TabIndex = 21;
            this.BtnResetUpdate.Text = "Reset";
            this.BtnResetUpdate.UseVisualStyleBackColor = false;
            this.BtnResetUpdate.Click += new System.EventHandler(this.BtnResetUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_DeptMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 730);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lb_DeptMaster
            // 
            this.lb_DeptMaster.AutoSize = true;
            this.lb_DeptMaster.BackColor = System.Drawing.Color.LightCoral;
            this.lb_DeptMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeptMaster.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_DeptMaster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_DeptMaster.Location = new System.Drawing.Point(3, 0);
            this.lb_DeptMaster.Name = "lb_DeptMaster";
            this.lb_DeptMaster.Size = new System.Drawing.Size(1002, 58);
            this.lb_DeptMaster.TabIndex = 1;
            this.lb_DeptMaster.Text = "Department";
            this.lb_DeptMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPageUpdate.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private TabControl tabControl1;
        private TabPage tabPageView;
        private TabPage tabPageAdd;
        private TabPage tabPageUpdate;
        private DataGridView DataGridViewDepartment;
        private Label lblName;
        private Label lblLocation;
        private TextBox TxtDeptLocation;
        private TextBox TxtDeptName;
        private TextBox TxtIDUpdate;
        private Label lblID;
        private TextBox TxtLocationUpdate;
        private TextBox TxtNameUpdate;
        private Label lblUpdateLocation;
        private Label lblUpdateName;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lb_DeptMaster;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnDelete;
        private Button BtnQuit;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnSave;
        private Button BtnReset;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSearch;
        private TableLayoutPanel tableLayoutPanel6;
        private Button BtnUpdate;
        private Button BtnResetUpdate;
    }
}