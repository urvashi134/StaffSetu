using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Designation : BaseForm
    {
        public Designation()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void ViewDesg()
        {

            var response = RestAPIHelper.GetAsync<ApiResponse<List<tblDesignation>>>(ApiConstants.API_GET_DESIGNATION_GETDESIGNATION);
            
            if(response.IsSuccessfull == true)
            {
                DataGridViewDesg.DataSource = response.Data;
                foreach (DataGridViewColumn dataGridViewColumn in DataGridViewDesg.Columns)
                {
                    dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue(response.ErrorMessage), FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        private void BtnSaveDesg_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                tblDesignation objtblDesignation = new tblDesignation();
                objtblDesignation.ID = 0;
                objtblDesignation.Name = TxtDesg.Text.ToString();

                var response = RestAPIHelper.PostAsync<ApiResponse<tblDesignation>>(ApiConstants.API_POST_DESIGNATION_ADD_DESIGNATION, objtblDesignation);
                if(response.IsSuccessfull == true)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_ADD_DESIGNATION"), FORMNAME, MessageTypeEnum.SUCCESS);
                    ResetDesg();
                    ViewDesg();
                }              
                else
                {
                    // response.ErrorMessage ??
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ADD_DESIGNATION"), FORMNAME, MessageTypeEnum.ERROR);
                }
            }          
        }

        private void Designation_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            FORMNAME = this.Text;
            if (GlobalData.role.Equals(RolesConstant.ROLE_DEPT_ADMIN, StringComparison.InvariantCultureIgnoreCase) 
                || GlobalData.role.Equals(RolesConstant.ROLE_STAFF, StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageAdd);
            }
            ViewDesg();
        }
        private void ResetDesg()
        {
            TxtDesg.Text = string.Empty;
        }
        private void BtnResetDesg_Click(object sender, EventArgs e)
        {
            ResetDesg();
        }

        private void TxtDesg_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtDesg.Text))
                {
                    if (Validators.IsValidText(TxtDesg.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtDesg, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtDesg.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtDesg, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtDesg.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DisplayMessage(ResourceHelper.GetValue("Msg_Quit"), FORMNAME, MessageTypeEnum.INPUTBOX);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                object sender = new object();
                EventArgs eventArgs = new EventArgs();
                BtnQuit_Click(sender, eventArgs);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
