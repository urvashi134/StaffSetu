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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDeptLocation = new System.Windows.Forms.TextBox();
            this.TxtDeptName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancelUpdate = new System.Windows.Forms.Button();
            this.BtnResetUpdate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtLocationUpdate = new System.Windows.Forms.TextBox();
            this.TxtNameUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtIDUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage1.Controls.Add(this.DataGridViewDepartment);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            // 
            // DataGridViewDepartment
            // 
            this.DataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewDepartment.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDepartment.Location = new System.Drawing.Point(25, 35);
            this.DataGridViewDepartment.Name = "DataGridViewDepartment";
            this.DataGridViewDepartment.ReadOnly = true;
            this.DataGridViewDepartment.RowHeadersWidth = 62;
            this.DataGridViewDepartment.RowTemplate.Height = 33;
            this.DataGridViewDepartment.Size = new System.Drawing.Size(851, 499);
            this.DataGridViewDepartment.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.BtnReset);
            this.tabPage2.Controls.Add(this.BtnSave);
            this.tabPage2.Controls.Add(this.TxtDeptLocation);
            this.tabPage2.Controls.Add(this.TxtDeptName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(375, 266);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
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
            // 
            // TxtDeptName
            // 
            this.TxtDeptName.Location = new System.Drawing.Point(137, 83);
            this.TxtDeptName.Name = "TxtDeptName";
            this.TxtDeptName.Size = new System.Drawing.Size(288, 32);
            this.TxtDeptName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.BtnSearch);
            this.tabPage3.Controls.Add(this.TxtIDUpdate);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1104, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCancelUpdate);
            this.groupBox1.Controls.Add(this.BtnResetUpdate);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.TxtLocationUpdate);
            this.groupBox1.Controls.Add(this.TxtNameUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 293);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // BtnCancelUpdate
            // 
            this.BtnCancelUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelUpdate.Location = new System.Drawing.Point(332, 204);
            this.BtnCancelUpdate.Name = "BtnCancelUpdate";
            this.BtnCancelUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelUpdate.Size = new System.Drawing.Size(112, 46);
            this.BtnCancelUpdate.TabIndex = 32;
            this.BtnCancelUpdate.Text = "Cancel";
            this.BtnCancelUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnResetUpdate
            // 
            this.BtnResetUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtnResetUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetUpdate.Location = new System.Drawing.Point(174, 204);
            this.BtnResetUpdate.Name = "BtnResetUpdate";
            this.BtnResetUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.BtnResetUpdate.Size = new System.Drawing.Size(112, 46);
            this.BtnResetUpdate.TabIndex = 31;
            this.BtnResetUpdate.Text = "Reset";
            this.BtnResetUpdate.UseVisualStyleBackColor = false;
            this.BtnResetUpdate.Click += new System.EventHandler(this.BtnResetUpdate_Click);
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
            // 
            // TxtNameUpdate
            // 
            this.TxtNameUpdate.Location = new System.Drawing.Point(126, 38);
            this.TxtNameUpdate.Name = "TxtNameUpdate";
            this.TxtNameUpdate.Size = new System.Drawing.Size(288, 32);
            this.TxtNameUpdate.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartment)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView DataGridViewDepartment;
        private Label label2;
        private Label label3;
        private TextBox TxtDeptLocation;
        private TextBox TxtDeptName;
        private Button BtnSave;
        private Button button1;
        private Button BtnReset;
        private TextBox TxtIDUpdate;
        private Label label4;
        private Button BtnSearch;
        private GroupBox groupBox1;
        private Button BtnCancelUpdate;
        private Button BtnResetUpdate;
        private Button BtnUpdate;
        private TextBox TxtLocationUpdate;
        private TextBox TxtNameUpdate;
        private Label label5;
        private Label label6;
    }
}