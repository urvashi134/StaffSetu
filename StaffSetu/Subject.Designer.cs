namespace Staff_Management
{
    partial class Subject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.CmbDept = new System.Windows.Forms.ComboBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SubjectMaster = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubject)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.tabControl1.Location = new System.Drawing.Point(3, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 668);
            this.tabControl1.TabIndex = 1;
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
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewSubject, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnQuit, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 623);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DataGridViewSubject
            // 
            this.DataGridViewSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.DataGridViewSubject, 4);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSubject.Location = new System.Drawing.Point(3, 2);
            this.DataGridViewSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewSubject.Name = "DataGridViewSubject";
            this.DataGridViewSubject.ReadOnly = true;
            this.DataGridViewSubject.RowHeadersWidth = 62;
            this.DataGridViewSubject.RowTemplate.Height = 33;
            this.DataGridViewSubject.Size = new System.Drawing.Size(982, 575);
            this.DataGridViewSubject.TabIndex = 0;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Azure;
            this.BtnQuit.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnQuit.Location = new System.Drawing.Point(891, 581);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Padding = new System.Windows.Forms.Padding(4);
            this.BtnQuit.Size = new System.Drawing.Size(94, 40);
            this.BtnQuit.TabIndex = 22;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Azure;
            this.BtnDelete.Font = new System.Drawing.Font("Merriweather Black", 8F);
            this.BtnDelete.Location = new System.Drawing.Point(771, 581);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Size = new System.Drawing.Size(94, 40);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel3.Controls.Add(this.LblName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CmbDept, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtSubject, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDepartment, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(988, 623);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.LblName.Location = new System.Drawing.Point(23, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(187, 54);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbDept
            // 
            this.CmbDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbDept.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.CmbDept.FormattingEnabled = true;
            this.CmbDept.Location = new System.Drawing.Point(216, 76);
            this.CmbDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDept.Name = "CmbDept";
            this.CmbDept.Size = new System.Drawing.Size(284, 33);
            this.CmbDept.TabIndex = 20;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSubject.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.TxtSubject.Location = new System.Drawing.Point(216, 22);
            this.TxtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(284, 32);
            this.TxtSubject.TabIndex = 4;
            this.TxtSubject.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSubject_Validating);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Font = new System.Drawing.Font("Merriweather", 9.749999F);
            this.lblDepartment.Location = new System.Drawing.Point(23, 74);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(187, 54);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnReset, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSave, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(216, 185);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 48);
            this.tableLayoutPanel4.TabIndex = 21;
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
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
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
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.lb_SubjectMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 730);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lb_SubjectMaster
            // 
            this.lb_SubjectMaster.AutoSize = true;
            this.lb_SubjectMaster.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lb_SubjectMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SubjectMaster.Font = new System.Drawing.Font("Merriweather", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_SubjectMaster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_SubjectMaster.Location = new System.Drawing.Point(3, 0);
            this.lb_SubjectMaster.Name = "lb_SubjectMaster";
            this.lb_SubjectMaster.Size = new System.Drawing.Size(1002, 58);
            this.lb_SubjectMaster.TabIndex = 2;
            this.lb_SubjectMaster.Text = "Subjects";
            this.lb_SubjectMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubject)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.DataGridView DataGridViewSubject;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox CmbDept;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_SubjectMaster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}