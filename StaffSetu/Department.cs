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
    public partial class Department : BaseForm
    {
        public Department()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                tbldepartment objtbldepartment = new tbldepartment();
                objtbldepartment.ID = 0;
                objtbldepartment.Name = TxtDeptName.Text;
                objtbldepartment.Location = TxtDeptLocation.Text;
         
                var response = RestAPIHelper.PostAsync<ApiResponse<tbldepartment>>(ApiConstants.API_GET_DEPARTMENT_INSERTDEPARTMENT, objtbldepartment);
                if (response.IsSuccessfull == true)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_ADD_DEPARTMENT"), FORMNAME, MessageTypeEnum.SUCCESS);
                    ResetPage();
                    ViewDepartments();
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ADD_DEPARTMENT"), FORMNAME, MessageTypeEnum.ERROR);
                    return;
                }              
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals(RolesConstant.ROLE_STAFF, StringComparison.InvariantCultureIgnoreCase) ||
                GlobalData.role.Equals(RolesConstant.ROLE_DEPT_ADMIN, StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageAdd);
                tabControl1.TabPages.Remove(tabPageUpdate);
            }
            ViewDepartments();
          
        }
        private void ViewDepartments()
        {
            var response = RestAPIHelper.GetAsync<ApiResponse<List<tbldepartment>>>(ApiConstants.API_GET_DEPARTMENT_GETDEPARTMENT);
            if (response.IsSuccessfull == true)
            {
                DataGridViewDepartment.DataSource = response.Data;
                foreach (DataGridViewColumn dataGridViewColumn in DataGridViewDepartment.Columns)
                {
                    dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue(response.ErrorMessage), FORMNAME, MessageTypeEnum.ERROR);
            }                     
        }
        private void ResetPage()
        {
            TxtDeptName.Text = string.Empty;
            TxtDeptLocation.Text = string.Empty;
        }
        private void ResetUpdatePage()
        {
            TxtIDUpdate.Text = string.Empty;
            TxtNameUpdate.Text = string.Empty;
            TxtLocationUpdate.Text = string.Empty;
        }
      
        private void TxtDeptName_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtDeptName.Text))
                {
                    if (Validators.IsValidText(TxtDeptName.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtDeptName, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtDeptName.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtDeptName, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtDeptName.Focus();
                    e.Cancel = true;
                }
            }            
        }

        private void TxtDeptLocation_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtDeptLocation.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtDeptLocation, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtDeptLocation.Focus();
                    e.Cancel = true;
                }
            }           
        }

        private void TxtIDUpdate_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtIDUpdate.Text))
                {
                    if (Validators.IsNumeric(TxtIDUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtIDUpdate, ResourceHelper.GetValue("NUMERIC_VALIDATION_FAIL"));
                        TxtIDUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtIDUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtIDUpdate.Focus();
                    e.Cancel = true;
                }
            }   
        }
        private void TxtNameUpdate_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtNameUpdate.Text))
                {
                    if (Validators.IsValidText(TxtNameUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtNameUpdate, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtNameUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtNameUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtNameUpdate.Focus();
                    e.Cancel = true;
                }
            }
            
        }
        private void TxtLocationUpdate_Validating(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedTab==tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtLocationUpdate.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtLocationUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtLocationUpdate.Focus();
                    e.Cancel = true;
                }
            }           
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDUpdate.Text))
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ENTER_DEPT_ID"), FORMNAME, MessageTypeEnum.ERROR);
                return;
            }

            int id;
            if (!int.TryParse(TxtIDUpdate.Text, out id))
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ENTER_DEPT_ID"), FORMNAME, MessageTypeEnum.ERROR);
                TxtIDUpdate.Text = String.Empty;
                return;
            }

            var response = RestAPIHelper.GetAsync<ApiResponse<tbldepartment>>($"{ApiConstants.API_GET_DEPARTMENT_GETDEPARTMENTBYID}/{id}");
            if(response.IsSuccessfull== true)
            {
                TxtNameUpdate.Text = response.Data.Name.ToString();
                TxtLocationUpdate.Text = response.Data.Location.ToString();
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_NO_DEPARTMENT"), FORMNAME, MessageTypeEnum.ERROR);
                ResetUpdatePage();
                return;
            }
           
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                tbldepartment objtbldepartment = new tbldepartment();
                int id = Convert.ToInt32(TxtIDUpdate.Text);
                
                objtbldepartment.ID = id;
                objtbldepartment.Name = TxtNameUpdate.Text.ToString();
                objtbldepartment.Location = TxtLocationUpdate.Text.ToString();
                objtbldepartment.IsActive = true;

                var response = RestAPIHelper.PostAsync<ApiResponse<tbldepartment>>(ApiConstants.API_GET_DEPARTMENT_UPDATEDEPARTMENT, objtbldepartment);
                if(response.IsSuccessfull == true)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_UPDATING_DEPARTMENT"), FORMNAME, MessageTypeEnum.SUCCESS);
                    ResetUpdatePage();
                    ViewDepartments();
                }
                else
                {
                    DisplayMessage(response.ErrorMessage, FORMNAME, MessageTypeEnum.ERROR);
                }
                
            }
        }

        private void BtnResetUpdate_Click(object sender, EventArgs e)
        {
            ResetUpdatePage();
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
            var id = DataGridViewDepartment.CurrentRow.Cells["ID"].Value;

            var val = RestAPIHelper.DeleteAsync<ApiResponse<Boolean>>($"{ApiConstants.API_DELETE_DEPARTMENT_DELETEDEPARTMENT}/{id}");
            if (val.IsSuccessfull == true)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_DELETE_DEPARTMENT"), FORMNAME, MessageTypeEnum.SUCCESS);
                //MessageBox.Show("Deleted");
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DELETE_DEPARTMENT"), FORMNAME, MessageTypeEnum.ERROR);
                //MessageBox.Show(val.ErrorMessage);
            }
            ViewDepartments();
        }
    }
}
