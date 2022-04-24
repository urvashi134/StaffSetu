using System.Windows.Forms;

namespace Staff_Management
{
    partial class Designation
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
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDesg = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.DataGridViewDesg = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPageAdd.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDesg)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageAdd.Controls.Add(this.BtnReset);
            this.tabPageAdd.Controls.Add(this.BtnSave);
            this.tabPageAdd.Controls.Add(this.TxtDesg);
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
            this.BtnReset.Location = new System.Drawing.Point(188, 156);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Padding = new System.Windows.Forms.Padding(5);
            this.BtnReset.Size = new System.Drawing.Size(112, 46);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnResetDesg_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Azure;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(32, 156);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5);
            this.BtnSave.Size = new System.Drawing.Size(112, 46);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveDesg_Click);
            // 
            // TxtDesg
            // 
            this.TxtDesg.Location = new System.Drawing.Point(137, 83);
            this.TxtDesg.Name = "TxtDesg";
            this.TxtDesg.Size = new System.Drawing.Size(288, 32);
            this.TxtDesg.TabIndex = 4;
            this.TxtDesg.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDesg_Validating);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(32, 86);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(69, 28);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // tabPageView
            // 
            this.tabPageView.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageView.Controls.Add(this.DataGridViewDesg);
            this.tabPageView.Location = new System.Drawing.Point(4, 37);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1104, 643);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "View";
            // 
            // DataGridViewDesg
            // 
            this.DataGridViewDesg.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DataGridViewDesg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDesg.Location = new System.Drawing.Point(25, 35);
            this.DataGridViewDesg.Name = "DataGridViewDesg";
            this.DataGridViewDesg.ReadOnly = true;
            this.DataGridViewDesg.RowHeadersWidth = 62;
            this.DataGridViewDesg.RowTemplate.Height = 33;
            this.DataGridViewDesg.Size = new System.Drawing.Size(851, 499);
            this.DataGridViewDesg.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 684);
            this.tabControl1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Designation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1362, 892);
            this.Controls.Add(this.tabControl1);
            this.Name = "Designation";
            this.Text = "Designation";
            this.Load += new System.EventHandler(this.Designation_Load);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDesg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPageAdd;
        private Button BtnReset;
        private Button BtnSave;
        private TextBox TxtDesg;
        private Label LblName;
        private TabPage tabPageView;
        private DataGridView DataGridViewDesg;
        private TabControl tabControl1;
        private ErrorProvider errorProvider1;
    }
}