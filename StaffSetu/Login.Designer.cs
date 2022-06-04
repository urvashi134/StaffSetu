using System.Windows.Forms;

namespace Staff_Management
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcome.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(134, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.lblWelcome.Size = new System.Drawing.Size(483, 80);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To Staff Setu";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.BtnReset);
            this.grpBoxLogin.Controls.Add(this.TxtPassword);
            this.grpBoxLogin.Controls.Add(this.TxtUsername);
            this.grpBoxLogin.Controls.Add(this.BtnLogin);
            this.grpBoxLogin.Controls.Add(this.lblpassword);
            this.grpBoxLogin.Controls.Add(this.LblUsername);
            this.grpBoxLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpBoxLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBoxLogin.Location = new System.Drawing.Point(349, 114);
            this.grpBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxLogin.Size = new System.Drawing.Size(364, 256);
            this.grpBoxLogin.TabIndex = 1;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "LOGIN";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnReset.CausesValidation = false;
            this.BtnReset.Font = new System.Drawing.Font("Arial", 11F);
            this.BtnReset.Location = new System.Drawing.Point(176, 197);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(101, 37);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(141, 98);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(190, 32);
            this.TxtPassword.TabIndex = 10;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(141, 52);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(190, 32);
            this.TxtUsername.TabIndex = 5;
            this.TxtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsername_Validating);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.BtnLogin.Location = new System.Drawing.Point(47, 197);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(101, 37);
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "Submit";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblpassword.Location = new System.Drawing.Point(28, 101);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(93, 28);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblUsername.Location = new System.Drawing.Point(28, 54);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(59, 28);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 248);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBoxLogin);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Setu";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private GroupBox grpBoxLogin;
        private Label lblpassword;
        private Label LblUsername;
        private Button BtnLogin;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
        private Button BtnReset;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}
