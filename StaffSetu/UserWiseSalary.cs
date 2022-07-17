using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management;
using Staff_Management.Helper;
using StaffSetu.DTO;
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
    public partial class UserWiseSalary : BaseForm
    {
        public UserWiseSalary()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void UserWiseSalary_Load(object sender, EventArgs e)
        {          
            if(GlobalData.role.Equals(RolesConstant.ROLE_STAFF, StringComparison.InvariantCultureIgnoreCase))
            {
                TxtStaffId.Text = GlobalData.ID.ToString();
                TxtStaffId.Enabled = false;
            }
            FillYear();
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
            GetSalary();
            
        }
        private void GetSalary()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int id = Convert.ToInt32(TxtStaffId.Text);
                int year = Convert.ToInt32(CmbYear.SelectedValue);

                var response = RestAPIHelper.GetAsync<ApiResponse<List<tblConfirmedAttendence>>>($"{ApiConstants.API_GET_SALARY_GETSALARY_BY_ID_DATE}/{id}/{year}");
                if (response.IsSuccessfull == true)
                {
                    var val = response.Data;
                    List<UserwiseSalaryView> tbl = new List<UserwiseSalaryView>();

                    for (int i = 0; i < val.Count; i++)
                    {
                        tbl.Add(new UserwiseSalaryView());
                        tbl[i].Month = val[i].month.ToStringMonth();
                        tbl[i].PresentDays = val[i].PresentDays;
                        tbl[i].AbsentDays = val[i].AbsentDays;
                        tbl[i].WorkingHrs = val[i].WorkingHrs;
                        tbl[i].SalaryCalculated = val[i].SalaryCalculated;
                    }

                    dataGridViewSalary.DataSource = tbl;
                }
                else
                {
                    DisplayMessage(response.ErrorMessage, FORMNAME, MessageTypeEnum.ERROR);
                }

            }
        }
        private void TxtStaffId_Validating(object sender, CancelEventArgs e)
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
