using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Subject : BaseForm
    {
        private bool isValidate = true;
        public Subject()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals(RolesConstant.ROLE_STAFF, StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageAdd);
              //  this.Controls.Remove(BtnDelete);
            }
            else
            {
               
                FillDept();
            }
            
            ViewSubject();
        }
        private void ViewSubject()
        {         

            var response = RestAPIHelper.GetAsync<ApiResponse<List<SubjectView>>>(ApiConstants.API_GET_SUBJECT_GETSUBJECT);

            if(response.IsSuccessfull == false)
            {
                return;
            }
            else
            {
                DataGridViewSubject.DataSource = response.Data;

                foreach (DataGridViewColumn dataGridViewColumn in DataGridViewSubject.Columns)
                {
                    dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            
        }
        private void FillDept()
        {
            List<tbldepartment> tbldepartments = StaffHelper.FillDepartment();
           
            CmbDept.DataSource = tbldepartments;
            CmbDept.DisplayMember = "Name";
            CmbDept.ValueMember = "ID";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                /*if (TxtSubject.Text == null)
                {
                    MessageBox.Show("Please Enter Subject name..");
                    return;
                }*/
                if (Convert.ToInt32(CmbDept.SelectedValue) == 0)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ADD_DEPARTMENT"), FORMNAME, MessageTypeEnum.ERROR);
                    return;
                }
                tblSubject objtblSubject = new tblSubject();
                objtblSubject.ID = 0;
                objtblSubject.SubjectName = TxtSubject.Text.ToString();
                objtblSubject.DeptID = Convert.ToInt32(CmbDept.SelectedValue);

                var response = RestAPIHelper.PostAsync<ApiResponse<tblSubject>>(ApiConstants.API_POST_SUBJECT_ADD_SUBJECT, objtblSubject);
                
                if (response.IsSuccessfull == false)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_ADD_SUBJECT"), FORMNAME, MessageTypeEnum.ERROR);
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_ADD_SUBJECT"), FORMNAME, MessageTypeEnum.SUCCESS);

                    ResetPage();
                    ViewSubject();
                }
            }           
        }
        private void ResetPage()
        {
            TxtSubject.Text = string.Empty;
            FillDept();
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void TxtSubject_Validating(object sender, CancelEventArgs e)
        {
            if (isValidate)
            {
                if (tabControl1.SelectedTab == tabPageAdd)
                {
                    if (Validators.RequiredValidation(TxtSubject.Text))
                    {
                        if (Validators.IsValidText(TxtSubject.Text))
                        {
                            errorProvider1.Clear();
                        }
                        else
                        {
                            errorProvider1.SetError(TxtSubject, ResourceHelper.GetValue("INVALID_CHARACTER"));
                            TxtSubject.Focus();
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(TxtSubject, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                        TxtSubject.Focus();
                        e.Cancel = true;
                    }
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DisplayMessage(ResourceHelper.GetValue("Msg_Quit"), FORMNAME, MessageTypeEnum.INPUTBOX);
            if (dialogResult == DialogResult.Yes)
            {
                isValidate = false;
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
            var id = DataGridViewSubject.CurrentRow.Cells["ID"].Value;

            var response = RestAPIHelper.DeleteAsync<ApiResponse<Boolean>>($"{ApiConstants.API_DELETE_SUBJECT_DELETESUBJECT}/{id}");

            if (response.IsSuccessfull == true)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_DELETE_SUBJECT"), FORMNAME, MessageTypeEnum.SUCCESS);
                //MessageBox.Show("Deleted");
                ViewSubject();
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DELETE_SUBJECT"), FORMNAME, MessageTypeEnum.ERROR);
                //MessageBox.Show(val.ErrorMessage);
            }
        }
    }
}
