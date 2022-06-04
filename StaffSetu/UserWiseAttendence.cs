using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffSetu
{
    public partial class UserWiseAttendence : BaseForm
    {
        public UserWiseAttendence()
        {
            InitializeComponent();
        }

        private void UserWiseAttendence_Load(object sender, EventArgs e)
        {
            //dataGridViewAttendence.DataSource = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            UserAttendenceReport obj = new UserAttendenceReport();
            obj.StaffId = Convert.ToInt32(TxtStaffId.Text);
            obj.AttendenceFrom = DtAttendenceFrom.Value;
            obj.AttendenceTill = DtAttendenceTill.Value;

            var val = RestAPIHelper.GetAsync<List<tblAttendence>>($"api/Attendence/GetAttendenceByStaffIdMonthYear/{obj}");

            if(val==null)
            {
                MessageBox.Show("Not Found");
                return;
            }
            List<UserAttendenceReportView> tbl = new List<UserAttendenceReportView>();

            for(int i=0;i<val.Count;i++)
            {
                tbl.Add(new UserAttendenceReportView());

                tbl[i].date = val[i].myDate;
                tbl[i].status = val[i].Status;
                tbl[i].StartTime = val[i].StartTime;
                tbl[i].EndTime = val[i].EndTime;
            }

            dataGridViewAttendence.DataSource = tbl;
        }

        private void DtAttendenceFrom_Validating(object sender, CancelEventArgs e)
        {
            if(Validators.IsValidDate(DtAttendenceFrom.Value))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(DtAttendenceFrom, ResourceHelper.GetValue(""));
                DtAttendenceFrom.Focus();
                e.Cancel = true;
            }
        }

        private void DtAttendenceTill_Validating(object sender, CancelEventArgs e)
        {
            if(DtAttendenceTill.Value <= DtAttendenceFrom.Value)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(DtAttendenceTill, ResourceHelper.GetValue(""));
                DtAttendenceTill.Focus();
                e.Cancel = true;
            }

        }
       
        private void TxtStaffId_Validating_1(object sender, CancelEventArgs e)
        {
            if (Validators.RequiredValidation(TxtStaffId.Text))
            {
                if (Validators.IsNumeric(TxtStaffId.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtStaffId, ResourceHelper.GetValue("NUMERIC_VALIDATION_FAIL"));
                    TxtStaffId.Focus();
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TxtStaffId, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtStaffId.Focus();
                e.Cancel = true;
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
