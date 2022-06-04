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
    public partial class Subject : BaseForm
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals("staff", StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageAdd);
            }
            else
            {
                FillDept();
            }
            ViewSubject();
        }
        private void ViewSubject()
        {
            var val = RestAPIHelper.GetAsync<List<tblSubject>>("api/Subject/GetSubject");
            DataGridViewSubject.DataSource = val;

            foreach(DataGridViewColumn dataGridViewColumn in DataGridViewSubject.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void FillDept()
        {
            var val = RestAPIHelper.GetAsync<List<tbldepartment>>("api/Department/GetDepartment");
            tbldepartment tblDept = new tbldepartment();
            tblDept.ID = 0;
            tblDept.Name = "-Select-";

            val.Insert(0, tblDept);
            CmbDept.DataSource = val;
            CmbDept.DisplayMember = "Name";
            CmbDept.ValueMember = "ID";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if (TxtSubject.Text == null)
                {
                    MessageBox.Show("Please Enter Subject name..");
                    return;
                }
                if (Convert.ToInt32(CmbDept.SelectedValue) == 0)
                {
                    MessageBox.Show("Please Select Department..");
                    return;
                }
                tblSubject objtblSubject = new tblSubject();
                objtblSubject.ID = 0;
                objtblSubject.SubjectName = TxtSubject.Text.ToString();
                objtblSubject.DeptID = Convert.ToInt32(CmbDept.SelectedValue);

                var val = RestAPIHelper.PostAsync<tblSubject>("api/Subject/InsertSubject", objtblSubject);
                if (val == null)
                {
                    MessageBox.Show("Addition Failed..");
                }
                else
                {
                    MessageBox.Show("Subject Added Succesfully..");
                }
                ResetPage();
                ViewSubject();
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
    }
}
