using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management;
using Staff_Management.DTO;
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

namespace Staff_Management
{
    public partial class AttendenceRules : BaseForm
    {
        public List<tblDesignation> listDesg = new List<tblDesignation>();
        public int idUpdate, desgIdUpdate;
        public AttendenceRules()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void Attendence_Rules_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals(RolesConstant.ROLE_ADMIN, StringComparison.InvariantCultureIgnoreCase))
            {
                listDesg = StaffHelper.FillDesignation();
                FillDesg();
                FillDesgUpdate();
            }
            else
            {
                tabControl1.TabPages.Remove(tabPageAdd);
                tabControl1.TabPages.Remove(tabPageUpdate);
            }
            ViewRules();
        }
        private void ViewRules()
        {
            var response = RestAPIHelper.GetAsync<ApiResponse<List<tblAttendenceRules>>>(ApiConstants.API_GET_ATTENDENCERULES_GET_RULES);

            if (response.IsSuccessfull == true)
            {
                var val = response.Data;
                List<AttendenceRulesView> tbls = new List<AttendenceRulesView>();

                for (int i = 0; i < val.Count; i++)
                {
                    tbls.Add(new AttendenceRulesView());
                    tbls[i].ID = val[i].ID;
                    tbls[i].RuleName = val[i].RuleName;
                    tbls[i].Designation = val[i].designation.Name;
                    tbls[i].IsWorkingHours = val[i].WorkingHourDay;
                    tbls[i].WorkingHours = val[i].WorkingHours;
                    tbls[i].IsDayWise = val[i].SalaryCalculation;
                    tbls[i].SalaryCalculationDays = val[i].SalaryCalculationDays;
                    tbls[i].LeavesAllowed = val[i].LeavesAllowed;

                }
                dataGridViewAttendenceRules.DataSource = tbls;
            }
        }
        private void FillDesg()
        {
            CmbDesg.DataSource = listDesg;
            CmbDesg.DisplayMember = "Name";
            CmbDesg.ValueMember = "ID";
        }
        private void FillDesgUpdate()
        {
            var val = listDesg;
            CmbDesgUpdate.DataSource = val;
            CmbDesgUpdate.DisplayMember = "Name";
            CmbDesgUpdate.ValueMember = "ID";
        }
        private void ResetAddPage()
        {
            TxtRuleName.Text = String.Empty;
            FillDesg();
            rdBtnDaysUpdate.Checked = false;
            rdBtnHours.Checked = false;
            numWorkingHours.Value = 0;
            rdBtnDaywise.Checked = false;
            rdBtnMonthly.Checked = false;
            TxtSalaryCalDays.Text = string.Empty;
            numLeaves.Value = 0;
        }
        private void ResetUpdatePage()
        {
            TxtRuleNameUpdate.Text = String.Empty;
            FillDesgUpdate();
            rdBtnDaysUpdate.Checked = false;
            rdBtnHoursUpdate.Checked = false;
            numWorkingHoursUpdate.Value = 0;
            rdBtnDaywiseUpdate.Checked = false;
            rdBtnMonthlyUpdate.Checked = false;
            TxtSalaryCalDaysUpdate.Text = string.Empty;
            numLeavesUpdate.Value = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && CheckDesg())
            {

                tblAttendenceRules tblAttendenceRules = new tblAttendenceRules();
                tblAttendenceRules.ID = 0;
                tblAttendenceRules.RuleName = TxtRuleName.Text;
                tblAttendenceRules.DesgId = Convert.ToInt32(CmbDesg.SelectedValue);
                if (rdBtnHours.Checked)
                    tblAttendenceRules.WorkingHourDay = true;
                else
                    tblAttendenceRules.WorkingHourDay = false;
                tblAttendenceRules.WorkingHours = Convert.ToInt32(numWorkingHours.Value);
                if (rdBtnDaywise.Checked)
                    tblAttendenceRules.SalaryCalculation = true;
                else
                    tblAttendenceRules.SalaryCalculation = false;
                    tblAttendenceRules.SalaryCalculationDays = TxtSalaryCalDays.Text.ToInt32();
                tblAttendenceRules.LeavesAllowed = Convert.ToInt32(numLeaves.Value);

                var response = RestAPIHelper.PostAsync<ApiResponse<tblAttendenceRules>>(ApiConstants.API_POST_ATTENDENCERULES_INSERT_RULES, tblAttendenceRules);
                if (response.IsSuccessfull == true)
                {
                    DisplayMessage(ResourceHelper.GetValue("SUCCESSFULL_ADDITION"), FORMNAME, MessageTypeEnum.SUCCESS);
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("UNSUCCESSFULL_ADDITION"), FORMNAME, MessageTypeEnum.ERROR);
                }
                ResetAddPage();
                ViewRules();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAddPage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!CheckDesg())
            {
                return;
            }
            int desgId = Convert.ToInt32(CmbDesgUpdate.SelectedValue);
            var response = RestAPIHelper.GetAsync<ApiResponse<tblAttendenceRules>>($"{ApiConstants.API_GET_ATTENDENCERULES_GET_RULES_BY_DESG}/{desgId}");

            if (response.IsSuccessfull == false)
            {
                DisplayMessage(ResourceHelper.GetValue("INVALID_SEARCH_VALUE"), FORMNAME, MessageTypeEnum.ERROR);
                return;
            }
            else
            {
                var val = response.Data;
                desgIdUpdate = desgId;
                idUpdate = val.ID;
                TxtRuleNameUpdate.Text = val.RuleName;
                if (val.WorkingHourDay == true)
                {
                    rdBtnHoursUpdate.Checked = true;
                    numWorkingHoursUpdate.Value = val.WorkingHours;
                }
                else
                    rdBtnDaysUpdate.Checked = true;
                if (val.SalaryCalculation == true)
                {
                    rdBtnDaywiseUpdate.Checked = true;
                    TxtSalaryCalDaysUpdate.Text = val.SalaryCalculationDays.ToString();
                }
                else
                    rdBtnMonthlyUpdate.Checked = true;
                numLeavesUpdate.Value = val.LeavesAllowed;
            }
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && CheckDesgUpdate())
            {
                /*if(desgIdUpdate != Convert.ToInt32(CmbDesgUpdate.SelectedValue))
                {
                    MessageBox.Show(ResourceHelper.GetValue("INVALID_UPDATE"));
                    return;
                }*/
                tblAttendenceRules objtblAttendenceRules = new tblAttendenceRules();

                objtblAttendenceRules.ID = idUpdate;
                objtblAttendenceRules.RuleName = TxtRuleNameUpdate.Text.ToString();
                objtblAttendenceRules.DesgId = Convert.ToInt32(CmbDesgUpdate.SelectedValue);
                objtblAttendenceRules.WorkingHourDay = rdBtnHoursUpdate.Checked;
                objtblAttendenceRules.WorkingHours = Convert.ToInt32(numWorkingHoursUpdate.Value);
                objtblAttendenceRules.SalaryCalculation = rdBtnDaywiseUpdate.Checked;
                objtblAttendenceRules.SalaryCalculationDays = Convert.ToInt32(TxtSalaryCalDaysUpdate.Text);
                objtblAttendenceRules.LeavesAllowed = Convert.ToInt32(numLeavesUpdate.Value);

                var response = RestAPIHelper.PostAsync<ApiResponse<tblAttendenceRules>>(ApiConstants.API_POST_ATTENDENCERULES_UPDATE_RULES, objtblAttendenceRules);
                if (response.IsSuccessfull == false)
                {
                    DisplayMessage(ResourceHelper.GetValue("UNSUCCESSFULL_UPDATE"), FORMNAME, MessageTypeEnum.ERROR);
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("SUCCESSFULL_UPDATE"), FORMNAME, MessageTypeEnum.SUCCESS);
                }
                ResetUpdatePage();
                ViewRules();
            }
        }

        private void BtnResetUpdate_Click(object sender, EventArgs e)
        {
            ResetUpdatePage();
        }

        private void TxtRuleName_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtRuleName.Text))
                {
                    if (Validators.IsValidText(TxtRuleName.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtRuleName, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtRuleName.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtRuleName, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtRuleName.Focus();
                    e.Cancel = true;
                }
            }
        }
        private bool CheckDesg()
        {
            if (Convert.ToInt32(CmbDesg.SelectedValue) == 0)
            {
                errorProvider1.SetError(CmbDesg, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                CmbDesg.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }

        }
        private bool CheckDesgUpdate()
        {
            if (Convert.ToInt32(CmbDesgUpdate.SelectedValue) == 0)
            {
                errorProvider1.SetError(CmbDesgUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                CmbDesgUpdate.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }

        }
        private void TxtSalaryCalDays_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd && rdBtnDaywise.Checked)
            {
                if (Validators.RequiredValidation(TxtSalaryCalDays.Text))
                {
                    if (Validators.IsNumeric(TxtSalaryCalDays.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtRuleName, ResourceHelper.GetValue("NUMERIC_VALIDATION_FAIL"));
                        TxtSalaryCalDays.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtSalaryCalDays, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtSalaryCalDays.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void rdBtnHoursUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnHoursUpdate.Checked)
                numWorkingHoursUpdate.Visible = true;
            else
                numWorkingHoursUpdate.Visible = false;
        }

        private void rdBtnHours_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnHours.Checked)
                numWorkingHours.Visible = true;
            else
                numWorkingHours.Visible = false;
        }

        private void rdBtnDaywise_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDaywise.Checked)
                TxtSalaryCalDays.Visible = true;
            else
                TxtSalaryCalDays.Visible = false;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DisplayMessage(ResourceHelper.GetValue("Msg_Quit"), FORMNAME, MessageTypeEnum.INPUTBOX);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void rdBtnDaywiseUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDaywiseUpdate.Checked)
                TxtSalaryCalDaysUpdate.Visible = true;
            else
                TxtSalaryCalDaysUpdate.Visible = false;
        }
    }
}
