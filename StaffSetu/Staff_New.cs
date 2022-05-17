using MANTRA;
using Setu.Entities;
using Staff_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Staff_New : BaseForm
    {
        public bool isFormLoaded = false;
        string key = string.Empty;
        public int deptId = 0, deptIdUpdate;

        bool bInitFlag = false;
        Bitmap bmp = null;
        int quality = Convert.ToInt32(ConfigurationManager.AppSettings["FingerPrintQuality"]);
        byte[] byteANSI = null;
        public List<tblSubject> subjectsByDeptId = new List<tblSubject>();
        public List<tblSubject> subjectsByDeptIdUpdate = new List<tblSubject>();
        public Staff_New()
        {
            InitializeComponent();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            ResourceHelper.SetLabel(this);
            if (GlobalData.role.Equals("staff", StringComparison.InvariantCultureIgnoreCase))
            {
                tabControl1.TabPages.Remove(tabPageView);
                tabControl1.TabPages.Remove(tabPageAdd);
                TxtIDUpdate.Text = GlobalData.ID.ToString();
                TxtIDUpdate.Enabled = false;
                SearchUserById();
                TxtIDUpdate.Enabled = false;
                CmbRoleUpdate.Enabled = false;
                CmbDesgUpdate.Enabled = false;
                TxtSalaryUpdate.Enabled = false;
                CmbDeptUpdate.Enabled = false;
                CmbSubject1Update.Enabled = false;
                CmbSubject2Update.Enabled = false;
                CmbSubject3Update.Enabled = false;
                DtJoiningDateUpdate.Enabled = false;
                BtnResetUpdatePage.Enabled = false;
            }
            else
            {

                ViewStaff();
                FillCmbsAdd();
            }
            ConfigureFingerPrintDevice();
            FillCmbsUpdate();
            isFormLoaded = true;
            ActiveControl = tabControl1;
        }
        private void ViewStaff()
        {
            var val = RestAPIHelper.GetAsync<List<tblStaff>>("api/Staff/GetStaff");
            List<entityStaffView> tbl = new List<entityStaffView>();

            for (int i = 0; i < val.Count; i++)
            {
                tbl.Add(new entityStaffView());

                tbl[i].ID = val[i].ID;
                tbl[i].StaffName = val[i].StaffName;
                tbl[i].FatherName = val[i].FatherName;
                tbl[i].MotherName = val[i].MotherName;
                tbl[i].Gender = val[i].Gender;
                tbl[i].Dob = val[i].Dob;
                tbl[i].Category = val[i].Category;
                if (val[i].state != null)
                    tbl[i].StateName = val[i].state.StateName;
                if (val[i].city != null)
                    tbl[i].CityName = val[i].city.CityName;
                tbl[i].Address = val[i].Address;
                tbl[i].EmailID = val[i].EmailID;
                tbl[i].Password = val[i].Password;
                tbl[i].MobileNo = val[i].MobileNo;
                // if(val[i].OtherContactNo != null)
                tbl[i].OtherContactNo = val[i].OtherContactNo;
                tbl[i].Qualification = val[i].Qualification;
                tbl[i].Role = val[i].Role;
                tbl[i].DesignationName = val[i].designation.Name;
                tbl[i].DepartmentName = val[i].department.Name;
                tbl[i].Subject1Name = val[i].subject1.SubjectName;
                if (val[i].subject2 != null)
                    tbl[i].Subject2Name = val[i].subject2.SubjectName;
                if (val[i].subject3 != null)
                    tbl[i].Subject3Name = val[i].subject3.SubjectName;
                tbl[i].Salary = val[i].Salary;
                tbl[i].JoiningDate = val[i].JoiningDate;
                tbl[i].Experience = val[i].Experience;
                tbl[i].AccountNo = val[i].AccountNo;
                tbl[i].AccountName = val[i].AccountName;
                tbl[i].IfscCode = val[i].IfscCode;
                tbl[i].UpiId = val[i].UpiId;

            }
            DataGridViewStaff.DataSource = tbl;
        }
        private void FillCmbsAdd()
        {
            FillGenderAdd();
            FillCategoryAdd();
            FillStateAdd();
            FillQualAdd();
            FillRoleAdd();
            FillDesgAdd();
            FillDeptAdd();
            FillCityAdd();
            FillSubjectsAdd();
        }
        private void FillCmbsUpdate()
        {
            FillGenderUpdate();
            FillCategoryUpdate();
            FillStateUpdate();
            FillQualUpdate();
            FillRoleUpdate();
            FillDesgUpdate();
            FillDeptUpdate();
            FillCityUpdate();
            FillSubjectsUpdate();
        }
        private void FillGenderAdd()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillGender();
            CmbGender.DataSource = comboBoxDataSources;
            CmbGender.DisplayMember = "DisplayMember";
            CmbGender.ValueMember = "Value";
        }
        private void FillGenderUpdate()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillGender();
            CmbGenderUpdate.DataSource = comboBoxDataSources;
            CmbGenderUpdate.DisplayMember = "DisplayMember";
            CmbGenderUpdate.ValueMember = "Value";
        }
        private void FillCategoryAdd()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillCategory();

            CmbCategory.DataSource = comboBoxDataSources;
            CmbCategory.DisplayMember = "DisplayMember";
            CmbCategory.ValueMember = "Value";
        }
        private void FillCategoryUpdate()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillCategory();
            CmbCategoryUpdate.DataSource = comboBoxDataSources;
            CmbCategoryUpdate.DisplayMember = "DisplayMember";
            CmbCategoryUpdate.ValueMember = "Value";
        }
        private void FillStateAdd()
        {
            var val = StaffHelper.FillState();

            CmbState.DataSource = val;
            CmbState.DisplayMember = "StateName";
            CmbState.ValueMember = "ID";
        }
        private void FillStateUpdate()
        {
            var val = StaffHelper.FillState();
            CmbStateUpdate.DataSource = val;
            CmbStateUpdate.DisplayMember = "StateName";
            CmbStateUpdate.ValueMember = "ID";
        }
        private void FillQualAdd()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillQual();
            CmbQual.DataSource = comboBoxDataSources;
            CmbQual.DisplayMember = "DisplayMember";
            CmbQual.ValueMember = "Value";
        }
        private void FillQualUpdate()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillQual();
            CmbQualUpdate.DataSource = comboBoxDataSources;
            CmbQualUpdate.DisplayMember = "DisplayMember";
            CmbQualUpdate.ValueMember = "Value";
        }
        private void FillRoleAdd()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillRole();
            CmbRole.DataSource = comboBoxDataSources;
            CmbRole.DisplayMember = "DisplayMember";
            CmbRole.ValueMember = "Value";

        }
        private void FillRoleUpdate()
        {
            List<ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillRole();
            CmbRoleUpdate.DataSource = comboBoxDataSources;
            CmbRoleUpdate.DisplayMember = "DisplayMember";
            CmbRoleUpdate.ValueMember = "Value";
        }
        private void FillDesgAdd()
        {
            var val = StaffHelper.FillDesignation();
            CmbDesg.DataSource = val;
            CmbDesg.DisplayMember = "Name";
            CmbDesg.ValueMember = "ID";
        }
        private void FillDesgUpdate()
        {
            var val = StaffHelper.FillDesignation();
            CmbDesgUpdate.DataSource = val;
            CmbDesgUpdate.DisplayMember = "Name";
            CmbDesgUpdate.ValueMember = "ID";
        }
        private void FillCityAdd()
        {
            var id = Convert.ToInt32(CmbState.SelectedValue);
            var val = StaffHelper.FillCityByStateID(id);

            CmbCity.DataSource = val;
            CmbCity.DisplayMember = "CityName";
            CmbCity.ValueMember = "ID";
        }
        private void FillCityUpdate()
        {
            var id = Convert.ToInt32(CmbStateUpdate.SelectedValue);
            var val = StaffHelper.FillCityByStateID(id);

            CmbCityUpdate.DataSource = val;
            CmbCityUpdate.DisplayMember = "CityName";
            CmbCityUpdate.ValueMember = "ID";
        }

        private void FillDeptAdd()
        {
            var val = StaffHelper.FillDepartment();
            CmbDept.DataSource = val;
            CmbDept.DisplayMember = "Name";
            CmbDept.ValueMember = "ID";
        }
        private void FillDeptUpdate()
        {
            var val = StaffHelper.FillDepartment();
            CmbDeptUpdate.DataSource = val;
            CmbDeptUpdate.DisplayMember = "Name";
            CmbDeptUpdate.ValueMember = "ID";
        }
        private void FillSubjectsAdd()
        {
            deptId = Convert.ToInt32(CmbDept.SelectedValue);
            subjectsByDeptId = RestAPIHelper.GetAsync<List<tblSubject>>($"api/Subject/GetSubjectByDepartmentID/{deptId}");


            FillSubject1Add();
            FillSubject2Add();
            FillSubject3Add();
        }
        private void FillSubjectsUpdate()
        {
            deptIdUpdate = Convert.ToInt32(CmbDeptUpdate.SelectedValue);
            subjectsByDeptIdUpdate = RestAPIHelper.GetAsync<List<tblSubject>>($"api/Subject/GetSubjectByDepartmentID/{deptIdUpdate}");


            FillSubject1Update();
            FillSubject2Update();
            FillSubject3Update();
        }
        private void FillSubject1Add()
        {
            List<tblSubject> subjects1 = new List<tblSubject>(subjectsByDeptId);
            StaffHelper.FillSubject1(subjects1);

            CmbSubject1.DataSource = subjects1;
            CmbSubject1.DisplayMember = "SubjectName";
            CmbSubject1.ValueMember = "ID";
        }
        private void FillSubject2Add()
        {
            List<tblSubject> subjects2 = new List<tblSubject>(subjectsByDeptId);

            int idSub1 = Convert.ToInt32(CmbSubject1.SelectedValue);
            StaffHelper.FillSubject2(subjects2, idSub1);

            CmbSubject2.DataSource = subjects2;
            CmbSubject2.DisplayMember = "SubjectName";
            CmbSubject2.ValueMember = "ID";

            CmbSubject2.SelectedIndex = 0;

        }
        private void FillSubject3Add()
        {
            List<tblSubject> subjects3 = new List<tblSubject>(subjectsByDeptId);
            int idSub1 = Convert.ToInt32(CmbSubject1.SelectedValue);
            int idSub2 = Convert.ToInt32(CmbSubject2.SelectedValue);
            StaffHelper.FillSubject3(subjects3, idSub1, idSub2);

            CmbSubject3.DataSource = subjects3;
            CmbSubject3.DisplayMember = "SubjectName";
            CmbSubject3.ValueMember = "ID";

            CmbSubject3.SelectedIndex = 0;
        }
        private void FillSubject1Update()
        {
            List<tblSubject> subjects1 = new List<tblSubject>(subjectsByDeptIdUpdate);
            StaffHelper.FillSubject1(subjects1);

            CmbSubject1Update.DataSource = subjects1;
            CmbSubject1Update.DisplayMember = "SubjectName";
            CmbSubject1Update.ValueMember = "ID";
        }
        private void FillSubject2Update()
        {
            List<tblSubject> subjects2 = new List<tblSubject>(subjectsByDeptIdUpdate);
            int idSub1 = Convert.ToInt32(CmbSubject1Update.SelectedValue);

            StaffHelper.FillSubject2(subjects2, idSub1);

            CmbSubject2Update.DataSource = subjects2;
            CmbSubject2Update.DisplayMember = "SubjectName";
            CmbSubject2Update.ValueMember = "ID";

            CmbSubject2Update.SelectedIndex = 0;
        }
        private void FillSubject3Update()
        {
            List<tblSubject> subjects3 = new List<tblSubject>(subjectsByDeptIdUpdate);
            int idSub1 = Convert.ToInt32(CmbSubject1Update.SelectedValue);
            int idSub2 = Convert.ToInt32(CmbSubject2Update.SelectedValue);

            StaffHelper.FillSubject3(subjects3, idSub1, idSub2);

            CmbSubject3Update.DataSource = subjects3;
            CmbSubject3Update.DisplayMember = "SubjectName";
            CmbSubject3Update.ValueMember = "ID";

            CmbSubject3Update.SelectedIndex = 0;
        }
        private void ResetAddPage()
        {
            FillCmbsAdd();
            TxtStaffID.Text = string.Empty;
            TxtStaffName.Text = string.Empty;
            TxtFatherName.Text = string.Empty;
            TxtMotherName.Text = string.Empty;
            DtDOB.Value = DateTime.Now;
            TxtEmail.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtMobNo.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtSalary.Text = string.Empty;
            DtJoiningDate.Value = DateTime.Now;
            TxtExp.Text = string.Empty;
            TxtAccNo.Text = string.Empty;
            TxtAccName.Text = string.Empty;
            TxtIfscCode.Text = string.Empty;
            TxtUpiId.Text = string.Empty;
        }
        private void ResetUpdatePage()
        {
            FillCmbsUpdate();
            TxtIDUpdate.Text = string.Empty;
            TxtStaffNameUpdate.Text = string.Empty;
            TxtFatherNameUpdate.Text = string.Empty;
            TxtMotherNameUpdate.Text = string.Empty;
            DtDOBUpdate.Value = DateTime.Now;
            TxtEmailUpdate.Text = string.Empty;
            TxtPasswordUpdate.Text = string.Empty;
            TxtMobNoUpdate.Text = string.Empty;
            TxtAddressUpdate.Text = string.Empty;
            TxtSalaryUpdate.Text = string.Empty;
            DtJoiningDateUpdate.Value = DateTime.Now;
            TxtExpUpdate.Text = string.Empty;
            TxtAccNoUpdate.Text = string.Empty;
            TxtAccNameUpdate.Text = string.Empty;
            TxtIfscCodeUpdate.Text = string.Empty;
            TxtUpiIdUpdate.Text = string.Empty;
        }
        private void BtnSaveStaff_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int desgId = Convert.ToInt32(CmbDesg.SelectedValue);
                if (desgId == 0)
                {
                    MessageBox.Show("Please Select Designation..");
                    return;
                }
                if (deptId == 0)
                {
                    MessageBox.Show("Please Select Department..");
                    return;
                }
                int subId = Convert.ToInt32(CmbSubject1.SelectedValue);
                if (subId == 0)
                {
                    MessageBox.Show("Please Select atleast 1 subject..");
                    return;
                }
                tblStaff objtblStaff = new tblStaff();
                objtblStaff.ID = Convert.ToInt32(TxtStaffID.Text.ToString());
                objtblStaff.StaffName = TxtStaffName.Text.ToString();
                objtblStaff.FatherName = TxtFatherName.Text.ToString();
                objtblStaff.MotherName = TxtMotherName.Text.ToString();
                objtblStaff.Gender = Convert.ToChar(CmbGender.SelectedValue);
                objtblStaff.Dob = DtDOB.Value;
                objtblStaff.Category = CmbCategory.Text.ToString();

                int stateId = Convert.ToInt32(CmbState.SelectedValue);
                if (stateId == 0)
                    objtblStaff.StateID = null;
                else
                    objtblStaff.StateID = stateId;
                int cityId = Convert.ToInt32(CmbCity.SelectedValue);
                if (cityId == 0)
                    objtblStaff.CityID = null;
                else
                    objtblStaff.CityID = stateId;

                objtblStaff.EmailID = TxtEmail.Text.ToString();
                objtblStaff.Password = TxtPassword.Text.ToString();

                objtblStaff.MobileNo = Convert.ToInt64(TxtMobNo.Text);

                //if (string.IsNullOrEmpty(TxtOtherConNo.Text))
                //    objtblStaff.OtherContactNo = null;
                //else
                //    objtblStaff.OtherContactNo = Convert.ToInt64(TxtOtherConNo.Text);

                objtblStaff.Address = TxtAddress.Text.ToString();

                objtblStaff.Role = CmbRole.Text.ToString();
                objtblStaff.Qualification = CmbQual.Text.ToString();
                objtblStaff.DesignationID = desgId;
                objtblStaff.DepartmentID = deptId;
                objtblStaff.Salary = Convert.ToDecimal(TxtSalary.Text.ToString());
                objtblStaff.Subject1ID = subId;
                int sub2Id = Convert.ToInt32(CmbSubject2.SelectedValue);
                if (sub2Id == 0)
                    objtblStaff.Subject2ID = null;
                else
                    objtblStaff.Subject2ID = sub2Id;
                int sub3Id = Convert.ToInt32(CmbSubject3.SelectedValue);
                if (sub3Id == 0)
                    objtblStaff.Subject3ID = null;
                else
                    objtblStaff.Subject3ID = sub3Id;

                objtblStaff.JoiningDate = DtJoiningDate.Value;
                objtblStaff.Experience = TxtExp.Text.ToString();
                objtblStaff.FingerPrintdata = GetFingerPrint();
                objtblStaff.FingerPrintANSI = GetFingerPrintANSI();
                objtblStaff.AccountNo = TxtAccNo.Text.ToString();
                objtblStaff.AccountName = TxtAccName.Text.ToString();
                objtblStaff.IfscCode = TxtIfscCode.Text.ToString();
                objtblStaff.UpiId = TxtUpiId.Text.ToString();
                var val = RestAPIHelper.PostAsync<tblStaff>("api/Staff/InsertStaff", objtblStaff);

                if (val == null)
                {
                    MessageBox.Show("Addition Failed..");
                }
                else
                {
                    MessageBox.Show("Staff Added Successfully..");
                }
                ResetAddPage();
                ViewStaff();
            }
        }

        private void BtnResetStaff_Click(object sender, EventArgs e)
        {
            ResetAddPage();
        }

        private void CmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillCityAdd();
        }

        private void SearchUserById()
        {

            int id = Convert.ToInt32(TxtIDUpdate.Text);
            var val = RestAPIHelper.GetAsync<tblStaff>($"api/Staff/GetStaffByID/{id}");

            if (val == null)
            {
                MessageBox.Show("No Staff Found with Given ID..");
                ResetUpdatePage();
                return;
            }

            TxtStaffNameUpdate.Text = val.StaffName;
            TxtFatherNameUpdate.Text = val.FatherName;
            TxtMotherNameUpdate.Text = val.MotherName;
            CmbGenderUpdate.SelectedValue = val.Gender.ToString();
            DtDOBUpdate.Value = val.Dob;
            CmbCategoryUpdate.Text = val.Category;
            if (val.StateID == null)
                CmbStateUpdate.SelectedValue = val.StateID.ToString();
            else
                CmbStateUpdate.SelectedValue = val.StateID;
            if (val.CityID == null)
                CmbCityUpdate.SelectedValue = val.CityID.ToString();
            else
                CmbCityUpdate.SelectedValue = val.CityID;

            TxtEmailUpdate.Text = val.EmailID;
            TxtPasswordUpdate.Text = val.Password;
            TxtMobNoUpdate.Text = val.MobileNo.ToString();
            //TxtOtherConNoUpdate.Text = val.OtherContactNo.ToString();
            TxtAddressUpdate.Text = val.Address;
            CmbQualUpdate.Text = val.Qualification;
            CmbRole.Text = val.Role;
            CmbDesgUpdate.SelectedValue = val.DesignationID;
            CmbDeptUpdate.SelectedValue = val.DepartmentID;
            deptIdUpdate = val.DepartmentID;

            TxtSalaryUpdate.Text = val.Salary.ToString();
            DtJoiningDateUpdate.Value = val.JoiningDate;
            CmbSubject1Update.SelectedValue = val.Subject1ID;
            if (val.Subject2ID == null)
                CmbSubject2Update.SelectedValue = val.Subject2ID.ToString();
            else
                CmbSubject2Update.SelectedValue = val.Subject2ID;
            if (val.Subject3ID == null)
                CmbSubject3Update.SelectedValue = val.Subject3ID.ToString();
            else
                CmbSubject3Update.SelectedValue = val.Subject3ID;

            TxtExpUpdate.Text = val.Experience;
            TxtAccNoUpdate.Text = val.AccountNo;
            TxtAccNameUpdate.Text = val.AccountName;
            TxtIfscCodeUpdate.Text = val.IfscCode;
            TxtUpiIdUpdate.Text = val.UpiId;

        }

        private void BtnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int desgId = Convert.ToInt32(CmbDesgUpdate.SelectedValue);
                if (desgId == 0)
                {
                    MessageBox.Show("Please Select Designation..");
                    return;
                }
                if (deptIdUpdate == 0)
                {
                    MessageBox.Show("Please Select Department..");
                    return;
                }
                int subId = Convert.ToInt32(CmbSubject1Update.SelectedValue);
                if (subId == 0)
                {
                    MessageBox.Show("Please Select atleast 1 subject..");
                    return;
                }
                int staffid = Convert.ToInt32(TxtIDUpdate.Text);
                tblStaff objtblStaff = new tblStaff();

                objtblStaff.ID = staffid;
                objtblStaff.StaffName = TxtStaffNameUpdate.Text.ToString();
                objtblStaff.FatherName = TxtFatherNameUpdate.Text.ToString();
                objtblStaff.MotherName = TxtMotherNameUpdate.Text.ToString();
                objtblStaff.Gender = Convert.ToChar(CmbGenderUpdate.SelectedValue);
                objtblStaff.Dob = DtDOBUpdate.Value;
                objtblStaff.Category = CmbCategoryUpdate.Text.ToString();

                int stateId = Convert.ToInt32(CmbStateUpdate.SelectedValue);
                if (stateId == 0)
                    objtblStaff.StateID = null;
                else
                    objtblStaff.StateID = stateId;
                int cityId = Convert.ToInt32(CmbCityUpdate.SelectedValue);
                if (cityId == 0)
                    objtblStaff.CityID = null;
                else
                    objtblStaff.CityID = stateId;

                objtblStaff.EmailID = TxtEmailUpdate.Text.ToString();
                objtblStaff.Password = TxtPasswordUpdate.Text.ToString();

                objtblStaff.MobileNo = Convert.ToInt64(TxtMobNoUpdate.Text);

                //if (string.IsNullOrEmpty(TxtOtherConNoUpdate.Text))
                //    objtblStaff.OtherContactNo = null;
                //else
                //    objtblStaff.OtherContactNo = Convert.ToInt64(TxtOtherConNoUpdate.Text);

                objtblStaff.Address = TxtAddressUpdate.Text.ToString();

                objtblStaff.Qualification = CmbQualUpdate.Text.ToString();
                objtblStaff.Role = CmbRoleUpdate.Text.ToString();
                objtblStaff.DesignationID = desgId;
                objtblStaff.DepartmentID = Convert.ToInt32(CmbDeptUpdate.SelectedValue);
                objtblStaff.Salary = Convert.ToDecimal(TxtSalaryUpdate.Text.ToString());
                objtblStaff.Subject1ID = subId;
                int sub2Id = Convert.ToInt32(CmbSubject2Update.SelectedValue);
                if (sub2Id == 0)
                    objtblStaff.Subject2ID = null;
                else
                    objtblStaff.Subject2ID = sub2Id;
                int sub3Id = Convert.ToInt32(CmbSubject3Update.SelectedValue);
                if (sub3Id == 0)
                    objtblStaff.Subject3ID = null;
                else
                    objtblStaff.Subject3ID = sub3Id;

                objtblStaff.JoiningDate = DtJoiningDateUpdate.Value;
                objtblStaff.Experience = TxtExpUpdate.Text.ToString();
                string fingerPrintANSI = GetFingerPrintANSI();
                string fingerPrintData = GetFingerPrint();
                if (!string.IsNullOrEmpty(fingerPrintData))
                {
                    objtblStaff.FingerPrintdata = fingerPrintData;
                }
                if (!string.IsNullOrEmpty(fingerPrintANSI))
                {
                    objtblStaff.FingerPrintANSI = fingerPrintANSI;
                }

                objtblStaff.AccountNo = TxtAccNoUpdate.Text.ToString();
                objtblStaff.AccountName = TxtAccNameUpdate.Text.ToString();
                objtblStaff.IfscCode = TxtIfscCodeUpdate.Text.ToString();
                objtblStaff.UpiId = TxtUpiIdUpdate.Text.ToString();

                var val = RestAPIHelper.PostAsync<tblStaff>("api/Staff/UpdateStaff", objtblStaff);
                if (val == null)
                {
                    MessageBox.Show("Update Failed..");
                }
                else
                {
                    MessageBox.Show("Updated Succesfully..");
                }
                ResetUpdatePage();
                ViewStaff();
            }

        }

        private void BtnResetUpdatePage_Click(object sender, EventArgs e)
        {
            ResetUpdatePage();
        }

        private void CmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                FillSubjectsAdd();
            }
        }

        private void CmbSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                FillSubject2Add();
            }
        }

        private void CmbSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillSubject3Add();
        }
        private void CmbStateUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillCityUpdate();
        }

        private void CmbDeptUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillSubjectsUpdate();
        }

        private void CmbSubject1Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillSubject2Update();
        }

        private void CmbSubject2Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                FillSubject3Update();
        }
        private void TxtStaffID_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtStaffID.Text))
                {
                    if (Validators.IsNumeric(TxtStaffID.Text))
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
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtEmail.Text))
                {
                    if (Validators.IsValidEmail(TxtEmail.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtEmail, ResourceHelper.GetValue("EMAIL_VALIDATION_FAIL"));
                        TxtEmail.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtEmail, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtEmail.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void TxtStaffName_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtStaffName.Text))
                {
                    if (Validators.IsValidText(TxtStaffName.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtStaffName, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtStaffName.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtStaffName, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtStaffName.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtPassword.Text))
                {
                    if (Validators.IsValidPassword(TxtPassword.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtPassword, ResourceHelper.GetValue("INVALID_PASSWORD"));
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtPassword, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtPassword.Focus();
                }
            }
        }

        private void TxtMobNo_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtMobNo.Text))
                {
                    if (Validators.IsValidMobile(TxtMobNo.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtMobNo, ResourceHelper.GetValue("INVALID_MOBILE"));
                        TxtMobNo.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtMobNo, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtMobNo.Focus();
                    e.Cancel = true;
                }
            }
        }

        //private void TxtOtherConNo_Validating(object sender, CancelEventArgs e)
        //{
        //    if (tabControl1.SelectedTab == tabPageAdd)
        //    {
        //        if (!string.IsNullOrEmpty(TxtOtherConNo.Text))
        //        {
        //            if (Validators.IsValidMobile(TxtOtherConNo.Text))
        //            {
        //                errorProvider1.Clear();
        //            }
        //            else
        //            {
        //                errorProvider1.SetError(TxtOtherConNo, ResourceHelper.GetValue("INVALID_MOBILE"));
        //                TxtOtherConNo.Focus();
        //                e.Cancel = true;
        //            }
        //        }
        //    }
        //}
        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageAdd)
            {
                if (Validators.RequiredValidation(TxtSalary.Text))
                {
                    if (Validators.IsDouble(TxtSalary.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtSalary, ResourceHelper.GetValue("INVALID_SALARY"));
                        TxtSalary.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtSalary, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtSalary.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void TxtIDUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
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
        private void TxtStaffNameUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtStaffNameUpdate.Text))
                {
                    if (Validators.IsValidText(TxtStaffNameUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtStaffNameUpdate, ResourceHelper.GetValue("INVALID_CHARACTER"));
                        TxtStaffNameUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtStaffNameUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtStaffNameUpdate.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void TxtEmailUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtEmailUpdate.Text))
                {
                    if (Validators.IsValidEmail(TxtEmailUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtEmailUpdate, ResourceHelper.GetValue("EMAIL_VALIDATION_FAIL"));
                        TxtEmailUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtEmailUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtEmailUpdate.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void TxtPasswordUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtPasswordUpdate.Text))
                {
                    if (Validators.IsValidPassword(TxtPasswordUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtPasswordUpdate, ResourceHelper.GetValue("INVALID PASSWORD"));
                        TxtPasswordUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtPasswordUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtPasswordUpdate.Focus();
                    e.Cancel = true;
                }
            }
        }
        private void TxtSalaryUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtSalaryUpdate.Text))
                {
                    if (Validators.IsDouble(TxtSalaryUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtSalaryUpdate, ResourceHelper.GetValue("INVALID_SALARY"));
                        TxtSalaryUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtSalaryUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtSalaryUpdate.Focus();
                    e.Cancel = true;
                }
            }
        }
        private void TxtMobNoUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUpdate)
            {
                if (Validators.RequiredValidation(TxtMobNoUpdate.Text))
                {
                    if (Validators.IsValidMobile(TxtMobNoUpdate.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtMobNoUpdate, ResourceHelper.GetValue("INVALID_MOBILE"));
                        TxtMobNoUpdate.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtMobNoUpdate, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtMobNoUpdate.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DisplayMessage(ResourceHelper.GetValue("Msg_Quit"), FORMNAME, MessageTypeEnum.INPUTBOX);
            if (dialogResult == DialogResult.Yes)
            {
                //isValidationCheck = false;
                Close();
                try
                {
                    GlobalData.mfs100.OnCaptureCompleted -= OnCaptureCompleted;
                    GlobalData.mfs100.OnCaptureCompleted += OnCaptureCompleted_End;
                    int iRet = GlobalData.mfs100.StartCapture(9999, 1, false);
                    GlobalData.mfs100.Dispose();
                }
                catch (Exception)
                {

                }
            }
        }

        private void Staff_New_Load(object sender, EventArgs e)
        {
            Staff_Load(sender, e);
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
        //private void TxtOtherConNoUpdate_Validating(object sender, CancelEventArgs e)
        //{
        //    if (tabControl1.SelectedTab == tabPageUpdate)
        //    {
        //        if (string.IsNullOrEmpty(TxtOtherConNoUpdate.Text))
        //        {
        //            if (Validators.IsValidMobile(TxtOtherConNoUpdate.Text))
        //            {
        //                errorProvider1.Clear();
        //            }
        //            else
        //            {
        //                errorProvider1.SetError(TxtOtherConNoUpdate, ResourceHelper.GetValue("INVALID_MOBILE"));
        //                TxtOtherConNoUpdate.Focus();
        //                e.Cancel = true;
        //            }
        //        }
        //    }
        //}

        private void ConfigureFingerPrintDevice()
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                GlobalData.mfs100 = new MFS100(key);
                GlobalData.mfs100.Init();
                GlobalData.mfs100.StartCapture();
                GlobalData.mfs100.OnMFS100Attached += OnMFS100Attached;
                GlobalData.mfs100.OnMFS100Detached += OnMFS100Detached;
                GlobalData.mfs100.OnPreview += OnPreview;
                GlobalData.mfs100.OnCaptureCompleted += OnCaptureCompleted;

            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }

        void OnMFS100Attached()
        {
            try
            {
                if (bInitFlag == false)
                {
                    int ret = GlobalData.mfs100.Init();
                    if (ret != 0)
                    {
                        DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_INITIATE") + ":" + GlobalData.mfs100.GetErrorMsg(ret), FORMNAME, MessageTypeEnum.ERROR);
                    }
                    else
                    {
                        bInitFlag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_NOT_CONNECTED") + ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        void OnMFS100Detached()
        {
            try
            {
                bInitFlag = false;
                DisplayMessage(ResourceHelper.GetValue("MSG_DEVICE_REMOVED"), FORMNAME, MessageTypeEnum.INFO);
                int ret = GlobalData.mfs100.Uninit();
            }
            catch (Exception ex)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_NOT_CONNECTED") + ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        void OnPreview(FingerData fingerprintData)
        {
            Thread trd = new Thread(() =>
            {
                try
                {
                    if (fingerprintData != null)
                    {
                        PictureBx_AddUserReg_FingerprintImpression.Image = fingerprintData.FingerImage;
                        PictureBx_AddUserReg_FingerprintImpression.Refresh();
                    }
                }
                catch (Exception)
                {
                }
            });
            trd.Start();

        }
        void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (status)
                {

                    fingerprintData.FingerImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

                    if (bmp != null)
                        bmp.Dispose();

                    PictureBox pictureBox = PictureBx_AddUserReg_FingerprintImpression;
                    if (tabControl1.SelectedTab == tabPageUpdate)
                    {
                        pictureBox = PictureBx_ModifyUserReg_FingerprintImpression;
                    }

                    bmp = new Bitmap(pictureBox.Width, pictureBox.Height, pictureBox.CreateGraphics());
                    var graph = Graphics.FromImage(bmp);
                    graph.DrawImage(fingerprintData.FingerImage, 0, 0, pictureBox.Width, pictureBox.Height);
                    pictureBox.Image = bmp;
                    pictureBox.Refresh();

                    byteANSI = fingerprintData.ANSITemplate;
                    bmp = fingerprintData.FingerImage;
                    DisplayMessage(ResourceHelper.GetValue("MSG_FINGERPRINT_CAPTURE_SUCCESS"), FORMNAME, MessageTypeEnum.SUCCESS);
                    GlobalData.mfs100.Init();
                    GlobalData.mfs100.StartCapture(quality);
                }
                else
                {
                    GlobalData.mfs100.Init();
                    GlobalData.mfs100.StartCapture(quality);
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
            finally
            {
                GC.Collect();
            }
        }

        private string GetFingerPrint()
        {
            try
            {
                byte[] fingerPrintData = GlobalData.mfs100.BitmapToBytes(bmp);
                string encryptedData = Convert.ToBase64String(fingerPrintData);
                return encryptedData;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public void OnCaptureCompleted_End(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
        }
        private void TxtIDUpdate_Leave(object sender, EventArgs e)
        {
            FillCmbsUpdate();
            SearchUserById();
        }

        private void CmbDeptUpdate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    
        private string GetFingerPrintANSI()
        {
            try
            {
                string encryptedAnsi = Convert.ToBase64String(byteANSI);
                return encryptedAnsi;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
