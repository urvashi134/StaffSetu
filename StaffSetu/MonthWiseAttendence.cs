using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management;
using Staff_Management.Helper;
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

            DateTime dt1 = new DateTime(year, month, 1, 0, 0, 0);
            int days = 30;
            if (month == 2)
                days = 28;
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                days = 31;
            DateTime dt2 = new DateTime(year, month, days, 0, 0, 0);

            UserAttendenceReport obj = new UserAttendenceReport();
            obj.StaffId = GlobalData.ID;
            obj.AttendenceFrom = dt1;
            obj.AttendenceTill = dt2;

            var response = RestAPIHelper.GetAsync<ApiResponse<List<tblAttendence>>>($"{ApiConstants.API_GET_ATTENDENCE_GET_ATTENDENCE_ALL_MONTH_WISE}/{obj}");
            if(response.IsSuccessfull == true)
            {
                List<MonthlyAttendenceReportView> tbl = new List<MonthlyAttendenceReportView>();
                var val = response.Data;

                for (int i = 0; i < val.Count; i++)
                {
                    tbl.Add(new MonthlyAttendenceReportView());
                    
                }
            }
            else
            {
                MessageBox.Show("Not Found");
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
