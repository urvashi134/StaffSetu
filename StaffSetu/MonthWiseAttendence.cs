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
    public partial class MonthWiseAttendence : BaseForm
    {
        public MonthWiseAttendence()
        {
            InitializeComponent();
        }

        private void MonthWiseAttendence_Load(object sender, EventArgs e)
        {
            FillMonth();
            FillYear();
        }
        private void FillMonth()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillMonth();
            CmbMonth.DataSource = comboBoxDataSources;
            CmbMonth.DisplayMember = "DisplayMember";
            CmbMonth.ValueMember = "Value";
        }
        private void FillYear()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillYear();
            CmbYear.DataSource = comboBoxDataSources;
            CmbYear.DisplayMember = "DisplayMember";
            CmbYear.ValueMember = "Value";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(CmbMonth.SelectedValue);
            int year = Convert.ToInt32(CmbYear.SelectedValue);

            DateTime dt1 = new DateTime(01, month, year, 0, 0, 0);
            int days = 30;
            if (month == 2)
                days = 28;
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                days = 31;
            DateTime dt2 = new DateTime(days, month, year, 0, 0, 0);

            UserAttendenceReport obj = new UserAttendenceReport();
            obj.StaffId = 0;
            obj.AttendenceFrom = dt1;
            obj.AttendenceTill = dt2;
            var val = RestAPIHelper.GetAsync<List<tblAttendence>>($"api/Attendence/GetAttendenceByMonthYear/{obj}");

            if(val==null)
            {
                MessageBox.Show("Not Found");
                return;
            }
            List<MonthlyAttendenceReportView> tbl = new List<MonthlyAttendenceReportView>();

            for(int i=0;i<val.Count;i++)
            {
                
                //if()
                //{

                //}
                //else
                //{
                //    tbl.Add(new MonthlyAttendenceReportView());
                //}
                

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
