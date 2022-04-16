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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnCancelDesg = new System.Windows.Forms.Button();
            this.BtnResetDesg = new System.Windows.Forms.Button();
            this.BtnSaveDesg = new System.Windows.Forms.Button();
            this.TxtDesg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridViewDesg = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDesg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage2.Controls.Add(this.BtnCancelDesg);
            this.tabPage2.Controls.Add(this.BtnResetDesg);
            this.tabPage2.Controls.Add(this.BtnSaveDesg);
            this.tabPage2.Controls.Add(this.TxtDesg);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            // 
            // BtnCancelDesg
            // 
            this.BtnCancelDesg.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelDesg.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelDesg.Location = new System.Drawing.Point(346, 156);
            this.BtnCancelDesg.Name = "BtnCancelDesg";
            this.BtnCancelDesg.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelDesg.Size = new System.Drawing.Size(112, 46);
            this.BtnCancelDesg.TabIndex = 19;
            this.BtnCancelDesg.Text = "Cancel";
            this.BtnCancelDesg.UseVisualStyleBackColor = false;
            // 
            // BtnResetDesg
            // 
            this.BtnResetDesg.BackColor = System.Drawing.Color.Azure;
            this.BtnResetDesg.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetDesg.Location = new System.Drawing.Point(188, 156);
            this.BtnResetDesg.Name = "BtnResetDesg";
            this.BtnResetDesg.Padding = new System.Windows.Forms.Padding(5);
            this.BtnResetDesg.Size = new System.Drawing.Size(112, 46);
            this.BtnResetDesg.TabIndex = 18;
            this.BtnResetDesg.Text = "Reset";
            this.BtnResetDesg.UseVisualStyleBackColor = false;
            this.BtnResetDesg.Click += new System.EventHandler(this.BtnResetDesg_Click);
            // 
            // BtnSaveDesg
            // 
            this.BtnSaveDesg.BackColor = System.Drawing.Color.Azure;
            this.BtnSaveDesg.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveDesg.Location = new System.Drawing.Point(32, 156);
            this.BtnSaveDesg.Name = "BtnSaveDesg";
            this.BtnSaveDesg.Padding = new System.Windows.Forms.Padding(5);
            this.BtnSaveDesg.Size = new System.Drawing.Size(112, 46);
            this.BtnSaveDesg.TabIndex = 17;
            this.BtnSaveDesg.Text = "Save";
            this.BtnSaveDesg.UseVisualStyleBackColor = false;
            this.BtnSaveDesg.Click += new System.EventHandler(this.BtnSaveDesg_Click);
            // 
            // TxtDesg
            // 
            this.TxtDesg.Location = new System.Drawing.Point(137, 83);
            this.TxtDesg.Name = "TxtDesg";
            this.TxtDesg.Size = new System.Drawing.Size(288, 32);
            this.TxtDesg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage1.Controls.Add(this.DataGridViewDesg);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 684);
            this.tabControl1.TabIndex = 1;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDesg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private Button BtnCancelDesg;
        private Button BtnResetDesg;
        private Button BtnSaveDesg;
        private TextBox TxtDesg;
        private Label label2;
        private TabPage tabPage1;
        private DataGridView DataGridViewDesg;
        private TabControl tabControl1;
    }
}