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
    public partial class Staff : Form
    {
        public bool isFormLoaded = false;
        public int deptId = 0,deptIdUpdate;
        public List<tblSubject> subjectsByDeptId = new List<tblSubject>();
        public List<tblSubject> subjectsByDeptIdUpdate = new List<tblSubject>();
        public Staff()
        {
            InitializeComponent();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            ViewStaff();
            FillCmbsAdd();
            FillCmbsUpdate();
            isFormLoaded = true;
        }
        private void ViewStaff()
        {
            var val = RestAPIHelper.GetAsync<List<tblStaff>>("api/Staff/GetStaff");
            List<entityStaffView> tbl = new List<entityStaffView>();

            for(int i = 0; i < val.Count; i++)
            {
                tbl.Add(new entityStaffView());

                tbl[i].ID = val[i].ID;
                tbl[i].StaffName = val[i].StaffName;
                tbl[i].FatherName = val[i].FatherName;
                tbl[i].MotherName = val[i].MotherName;
                tbl[i].Gender = val[i].Gender;
                tbl[i].Dob = val[i].Dob;
                tbl[i].Category = val[i].Category;
                if(val[i].state !=null)
                    tbl[i].StateName = val[i].state.StateName;
                if(val[i].city !=null)
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
                if(val[i].subject2 != null)
                    tbl[i].Subject2Name = val[i].subject2.SubjectName;
                if( val[i].subject3 !=null )
                    tbl[i].Subject3Name = val[i].subject3.SubjectName;
                tbl[i].Salary = val[i].Salary;
                tbl[i].JoiningDate = val[i].JoiningDate;
                tbl[i].Experience = val[i].Experience;
                
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
            List <ComboBoxDataSources> comboBoxDataSources = StaffHelper.FillCategory();

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

        }
        private void FillRoleUpdate()
        {

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
            StaffHelper.FillSubject2(subjects2,idSub1);
           
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
        }
        private void BtnSaveStaff_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(TxtStaffID.Text))
            {
                MessageBox.Show("Please Enter Staff ID..");
                return;
            }
           if (string.IsNullOrEmpty(TxtStaffName.Text))
            {
                MessageBox.Show("Please Enter Staff Name..");
                return;
            }
            if (TxtEmail.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Email..");
                return;
            }
            if (!TxtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Please check your Email..");
                return;
            }
            if(TxtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if(TxtPassword.Text.Length < 8 || TxtPassword.Text.Length >15)
            {
                MessageBox.Show("Password must have 8-15 letters..");
                return;
            }
            if(TxtMobNo.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Mobile Number..");
                return;
            }
            if (!long.TryParse(TxtMobNo.Text, out long mobile))
            {
                MessageBox.Show("Please check your Mobile Number..");
                return;
            }
            if (TxtMobNo.Text.Length != 10)
            {
                MessageBox.Show("Please check length of Mobile Number..");
                return;
            }
           
            if (TxtOtherConNo.Text.Length != 0)
            {
                if (TxtOtherConNo.Text.Length > 11 || TxtOtherConNo.Text.Length < 10)
                {
                    MessageBox.Show("Please check length of Alternate Contact Number..");
                    return;
                }
            }
            
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

            if (string.IsNullOrEmpty(TxtOtherConNo.Text))
                objtblStaff.OtherContactNo = null;
            else
                objtblStaff.OtherContactNo = Convert.ToInt64(TxtOtherConNo.Text);
            
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

            var val = RestAPIHelper.PostAsync<tblStaff>("api/Staff/InsertStaff", objtblStaff);

            if(val == null)
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

        private void BtnResetStaff_Click(object sender, EventArgs e)
        {
            ResetAddPage();
        }

        private void CmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
                FillCityAdd();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtIDUpdate.Text))
            {
                MessageBox.Show("Please Enter Staff ID..");
                return;
            }
            int id = Convert.ToInt32(TxtIDUpdate.Text);
            var val = RestAPIHelper.GetAsync<tblStaff>($"api/Staff/GetStaffByID/{id}");

            if (val == null)
            {
                MessageBox.Show("No Staff Found with Given ID..");
                ResetUpdatePage();
                return;
            }
            else
            {
                TxtStaffNameUpdate.Text = val.StaffName;
                TxtFatherNameUpdate.Text = val.FatherName;
                TxtMotherNameUpdate.Text =val.MotherName;   
                CmbGenderUpdate.SelectedValue = val.Gender.ToString();
                DtDOBUpdate.Value = val.Dob;
                CmbCategoryUpdate.Text = val.Category;
                if(val.StateID == null)
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
                TxtOtherConNoUpdate.Text = val.OtherContactNo.ToString();
                TxtAddressUpdate.Text = val.Address;
                CmbQualUpdate.Text = val.Qualification;
                CmbRole.Text = val.Role;
                CmbDesgUpdate.SelectedValue = val.DesignationID;
                CmbDeptUpdate.SelectedValue = val.DepartmentID;
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

            }
        }

        private void BtnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDUpdate.Text))
            {
                MessageBox.Show("Please Enter Staff ID..");
                return;
            }
            if(string.IsNullOrEmpty(TxtStaffNameUpdate.Text))
            {
                MessageBox.Show("Please Enter Staff Name..");
                return;
            }
            if (TxtEmailUpdate.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Email..");
                return;
            }
            if (!TxtEmailUpdate.Text.Contains('@'))
            {
                MessageBox.Show("Please check your Email..");
                return;
            }
            if (TxtPasswordUpdate.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if (TxtPasswordUpdate.Text.Length < 8 || TxtPasswordUpdate.Text.Length > 15)
            {
                MessageBox.Show("Password must have 8-15 letters..");
                return;
            }
            if (TxtMobNoUpdate.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Mobile Number..");
                return;
            }
            if (!long.TryParse(TxtMobNoUpdate.Text, out long mobile))
            {
                MessageBox.Show("Please check your Mobile Number..");
                return;
            }
            if (TxtMobNoUpdate.Text.Length != 10)
            {
                MessageBox.Show("Please check length of Mobile Number..");
                return;
            }

            if (TxtOtherConNoUpdate.Text.Length != 0)
            {
                if (TxtOtherConNoUpdate.Text.Length > 11 || TxtOtherConNoUpdate.Text.Length < 10)
                {
                    MessageBox.Show("Please check length of Alternate Contact Number..");
                    return;
                }
            }

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

            if (string.IsNullOrEmpty(TxtOtherConNoUpdate.Text))
                objtblStaff.OtherContactNo = null;
            else
                objtblStaff.OtherContactNo = Convert.ToInt64(TxtOtherConNoUpdate.Text);

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

            var val = RestAPIHelper.PostAsync<tblStaff>("api/Staff/UpdateStaff",objtblStaff);
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

        private void BtnResetUpdatePage_Click(object sender, EventArgs e)
        {
            ResetUpdatePage();
        }

        private void CmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
            {
                FillSubjectsAdd();
            }
        }

        private void CmbSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
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
            if(isFormLoaded)
                FillCityUpdate();   
        }

        private void CmbDeptUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
                FillSubjectsUpdate();   
        }

        private void CmbSubject1Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
                FillSubject2Update();
        }

        private void CmbSubject2Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFormLoaded)
                FillSubject3Update();   
        }

    }
}
