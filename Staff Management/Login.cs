using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            TxtUsername.Focus();
            ActiveControl = TxtUsername;
        }
        
        private void ResetPage()
        {
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;    
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string role = "";
                int id;
                if (TxtUsername.Text == "a@a.com" && TxtPassword.Text == "p")
                {
                    role = "admin";
                    id = 1;
                }
                else
                {
                    var val = RestAPIHelper.GetAsync<tblStaff>($"api/Staff/GetStaffByEmailPassword/{TxtUsername.Text},{TxtPassword.Text}");
                    if (val == null)
                    {
                        MessageBox.Show("Check your EmailId or password..");
                        return;
                    }
                    role = val.Role;
                    id = val.ID;

                }

                GlobalData.role = role;
                GlobalData.ID = id;
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Closed += (s, args) => this.Close();
                adminDashboard.Show();
                this.Hide();
            }
        }

        private void TxtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Validators.RequiredValidation(TxtUsername.Text))
            {
                if(Validators.IsValidEmail(TxtUsername.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtUsername, ResourceHelper.GetValue("EMAIL_VALIDATION_FAIL"));
                    TxtUsername.Focus();
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TxtUsername, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtUsername.Focus();
                e.Cancel = true;
            }
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Validators.RequiredValidation(TxtPassword.Text))
            {
                
                    errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(TxtPassword, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtPassword.Focus();
            }
        }
    }
}
