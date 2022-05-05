using Setu.Common.DTO;
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
    public partial class Add_attendence : Form
    {
        public int id = 0;
        public Add_attendence()
        {
            InitializeComponent();
        }

        private void Add_attendence_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection id = new AutoCompleteStringCollection();
            id.Add("10");
            id.Add("11");
            id.Add("122");
            id.Add("1456");
            TxtStaffID.AutoCompleteMode = AutoCompleteMode.Suggest;
            TxtStaffID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtStaffID.AutoCompleteCustomSource = id;
        }
        private void GetStaffIDs()
        {
            AutoCompleteStringCollection id = new AutoCompleteStringCollection();
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                tblAttendence tblAttendence = new tblAttendence();
                tblAttendence.ID = id;
                tblAttendence.StaffID = Convert.ToInt32(TxtStaffID.Text);
                tblAttendence.myDate = DtToday.Value;
                if(rdBtnPresent.Checked)
                {
                    tblAttendence.Status = 'P';
                    tblAttendence.StartTime = timeStart.Value.ToString("HH:mm");
                    tblAttendence.EndTime = timeEnd.Value.ToString("HH:mm");
                    //string startTime = "08:00";
                    //string[] delim = { ":" };
                    //string[] start = startTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    //DateTime dt = new DateTime(0, 0, 0, Convert.ToInt32(start[0]), Convert.ToInt32(start[1]), 0);
                }
                else
                {
                    tblAttendence.StartTime = "00:00";
                    tblAttendence.EndTime = "00:00";
                    if (rdBtnAbsent.Checked)
                        tblAttendence.Status = 'A';
                    else
                        tblAttendence.Status = 'L';
                }
                if(id==0)
                {
                    var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/InsertAttendence", tblAttendence);
                    if (val == null)
                    {
                        // MessageBox.Show(ResourceHelper.GetValue("UNSUCCESSFULL_ATTENDENCE_ADDITION"));
                        MessageBox.Show("Not Successfull");
                    }
                    else
                    {
                        //MessageBox.Show(ResourceHelper.GetValue("SUCCESSFULL"));
                        MessageBox.Show("Successfull");
                    }
                }
                else
                {
                    var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/UpdateAttendence", tblAttendence);
                    if (val == null)
                    {
                        // MessageBox.Show(ResourceHelper.GetValue(""));
                        MessageBox.Show("Unsuccessfull");
                    }
                        
                    else
                    {
                        MessageBox.Show("Successfull");
                        //MessageBox.Show(ResourceHelper.GetValue(""));
                    }
                        
                }
                ResetPage();

            }
        }
        private void TxtStaffID_Validating(object sender, CancelEventArgs e)
        {
            if (Validators.RequiredValidation(TxtStaffID.Text))
            {
                if(Validators.IsNumeric(TxtStaffID.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtStaffID, ResourceHelper.GetValue("NUMERIC_VALIDATION_FAIL"));
                    TxtStaffID.Focus();
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TxtStaffID, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtStaffID.Focus();
                e.Cancel = true;
            }
        }

        private void rdBtnPresent_CheckedChanged(object sender, EventArgs e)
        {
            if(rdBtnPresent.Checked)
            {
                timeStart.Enabled = true;
                timeEnd.Enabled = true;
            }
            else
            {
                timeStart.Enabled = false;
                timeEnd.Enabled = false;
            }
        }
        private void ResetPage()
        {
            try
            {
                TxtStaffID.Text = string.Empty;
                DtToday.Value = DateTime.Today;
                rdBtnPresent.Checked = true;
                DateTime dt = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
                timeStart.Value = dt;
                timeEnd.Value = dt;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private void TxtStaffID_Leave(object sender, EventArgs e)
        {
            try
            {
                int staffId = Convert.ToInt32(TxtStaffID.Text);
                DateTime date = DtToday.Value.Date;
                AttendenceRules obj = new AttendenceRules();
                obj.staffId = staffId;
                obj.date = date;
                var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/GetAttendenceByStaffIdDate", obj);
                if (val != null)
                {
                    id = val.ID;
                    if (val.Status == 'P')
                        rdBtnPresent.Checked = true;
                    else if (val.Status == 'A')
                        rdBtnAbsent.Checked = true;
                    else
                        rdBtnLeave.Checked = true;

                    string[] delim = { ":" };
                    string[] start = val.StartTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    DateTime dt1 = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(start[0]), Convert.ToInt32(start[1]), 0);
                    timeStart.Value = dt1;
                    string[] end = val.EndTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    DateTime dt2 = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(end[0]), Convert.ToInt32(end[1]), 0);
                    timeEnd.Value = dt2;
                }
            }
            catch(Exception)
            {

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }
    }
}
