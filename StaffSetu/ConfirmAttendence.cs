using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class ConfirmAttendence : BaseForm
    {
        public List<YearMonthDTO> yearMonthDTOs = new List<YearMonthDTO>();
        public List<ComboBoxDataSources> yearMonth =    new List<ComboBoxDataSources>();
        public ConfirmAttendence()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void ConfirmAttendence_Load(object sender, EventArgs e)
        {
            yearMonthDTOs = RestAPIHelper.GetAsync<List<YearMonthDTO>>("api/Common/GetYearMonthForConfirmAttendance");
            cmbYear.DataSource = yearMonthDTOs;
            cmbYear.DisplayMember = "Year";
            cmbYear.ValueMember = "Year";

            var monthDetails=  yearMonthDTOs[0];
            yearMonth = GlobalData.comboBoxDataSources.Where(x => monthDetails.Months.Contains(Convert.ToInt32(x.Value))).ToList();
            cmbMonth.DataSource = yearMonth;
            cmbMonth.DisplayMember = "DisplayMember";
            cmbMonth.ValueMember  = "Value";
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = cmbYear.SelectedValue;
            var monthDetails = yearMonthDTOs.FirstOrDefault(x => x.Year == ((YearMonthDTO)selectedYear).Year);
            yearMonth = GlobalData.comboBoxDataSources.Where(x => monthDetails.Months.Contains(Convert.ToInt32(x.Value))).ToList();
            cmbMonth.DataSource = yearMonth;
            cmbMonth.DisplayMember = "DisplayMember";
            cmbMonth.ValueMember = "Value";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedYear = cmbYear.SelectedValue;
            var selectedMonth = cmbMonth.SelectedValue;
            List<ConfirmSalaryView> confirmSalaryViews  = RestAPIHelper.GetAsync<List<ConfirmSalaryView>>($"api/Salary/CalculateSalry/{selectedMonth}/{selectedYear}");
            dgvConfirmAttendence.DataSource = confirmSalaryViews;
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<ConfirmSalaryDTO> confirmSalaries = new List<ConfirmSalaryDTO>();
            foreach (DataGridViewRow dataGridViewRow in dgvConfirmAttendence.Rows)
            {
                if (Convert.ToBoolean(dataGridViewRow.Cells["IsSelected"].Value) && Convert.ToSingle(dataGridViewRow.Cells["SalaryCalculated"].Value) > 0)
                {
                    ConfirmSalaryDTO confirmSalaryDTO = new ConfirmSalaryDTO();
                    confirmSalaryDTO.beneId = Convert.ToInt32(dataGridViewRow.Cells["ID"].Value);
                    confirmSalaryDTO.amount = Convert.ToSingle(dataGridViewRow.Cells["SalaryCalculated"].Value);
                    confirmSalaryDTO.month = Convert.ToInt32(cmbMonth.SelectedValue);
                    confirmSalaryDTO.year = Convert.ToInt32(cmbYear.SelectedValue);
                    confirmSalaryDTO.PresentDays = Convert.ToSingle(dataGridViewRow.Cells["PresentDays"].Value);
                    confirmSalaryDTO.AbsentDays = Convert.ToSingle(dataGridViewRow.Cells["AbsentDays"].Value);
                    confirmSalaryDTO.LeaveDays = Convert.ToSingle(dataGridViewRow.Cells["LeaveDays"].Value);
                    confirmSalaryDTO.MonthlySalary = Convert.ToDecimal(dataGridViewRow.Cells["MonthlySalary"].Value);
                    confirmSalaries.Add(confirmSalaryDTO);
                }
            }
            if (confirmSalaries.Count > 0)
            {
                var result = RestAPIHelper.PostAsync<bool>("api/Salary/ConfirmSalary", confirmSalaries);
                btnSearch_Click(sender, e);
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("ERROR_NO_VALID_RECORD_SELECTED"), FORMNAME, MessageTypeEnum.ERROR);
            }

        }

        private void dgvConfirmAttendence_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvConfirmAttendence.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsConfirmed"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.Cells["IsSelected"].ReadOnly = true;
                }
            }
        }
    }
}
