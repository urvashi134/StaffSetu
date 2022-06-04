﻿using Setu.Common.DTO;
using Setu.Entities;
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

                var val = RestAPIHelper.PostAsync<tbldepartment>("api/Department/InsertDepartment", objtbldepartment);

                if (val == null)
                {
                    MessageBox.Show("Addition Failed..");
                }
                else
                {
                    MessageBox.Show("Department Added Succesfully..");
                }

                ResetPage();
                ViewDepartments();
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals("staff", StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageAdd);
                tabControl1.TabPages.Remove(tabPageUpdate);
            }
            ViewDepartments();
          
        }
        private void ViewDepartments()
        {
            var val = RestAPIHelper.GetAsync<List<tbldepartment>>("api/Department/GetDepartment");
            DataGridViewDepartment.DataSource = val;
            foreach(DataGridViewColumn dataGridViewColumn in   DataGridViewDepartment.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                MessageBox.Show("Please Enter Department ID..");
                return;
            }
            int id = Convert.ToInt32(TxtIDUpdate.Text);
            var val = RestAPIHelper.GetAsync<tbldepartment>($"api/Department/GetDepartmentByID/{id}");

            if (val == null)
            {
                MessageBox.Show("No Department Found with Given ID..");
                ResetUpdatePage();
                return;
            }
            else
            {
                TxtNameUpdate.Text = val.Name.ToString();
                TxtLocationUpdate.Text = val.Location.ToString();
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                tbldepartment objtbldepartment = new tbldepartment();
                int id = Convert.ToInt32(TxtIDUpdate.Text);
                //var objtbldepartment = RestAPIHelper.GetAsync<tbldepartment>($"api/Department/GetDepartmentByID/{id}");
                objtbldepartment.ID = id;
                objtbldepartment.Name = TxtNameUpdate.Text.ToString();
                objtbldepartment.Location = TxtLocationUpdate.Text.ToString();

                var val = RestAPIHelper.PostAsync<tbldepartment>("api/Department/UpdateDepartment", objtbldepartment);

                if (val == null)
                {
                    MessageBox.Show("Update Failed..");
                }
                else
                {
                    MessageBox.Show("Updated Succesfully..");
                }
                ResetUpdatePage();
                ViewDepartments();
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
            var id = DataGridViewDepartment.SelectedRows[0].Cells["ID"].Value;

            var val = RestAPIHelper.DeleteAsync<ApiResponse<Boolean>>($"api/Department/DeleteDepartment/{id}");

            if (val.IsSuccessfull == true)
            {
                DisplayMessage(val.ErrorMessage, FORMNAME, MessageTypeEnum.SUCCESS);
                //MessageBox.Show("Deleted");
            }
            else
            {
                DisplayMessage(val.ErrorMessage, FORMNAME, MessageTypeEnum.ERROR);
                //MessageBox.Show(val.ErrorMessage);
            }
        }
    }
}
