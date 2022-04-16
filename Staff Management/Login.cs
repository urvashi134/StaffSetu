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
            FillType();
        }

        private void FillType()
        {
            List<ComboBoxDataSources> comboBoxDataSource = new List<ComboBoxDataSources>();

            comboBoxDataSource.Add(new ComboBoxDataSources()
            {
                Value = "1",
                DisplayMember = "Admin"
            });
            comboBoxDataSource.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = "Staff"
            });
        }
        public void CheckLogin()
        {
            if(TxtUsername.Text == null)
            {
                MessageBox.Show("Please Enter Username..");
                return;
            }
            if(TxtPassword.Text == null)
            {
                MessageBox.Show("Please Enter Password..");
                return;
            }

        }
        private void ResetPage()
        {
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;    
            FillType();
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {  

        }
       
    }
}
