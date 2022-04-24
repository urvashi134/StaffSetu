using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staff_Management
{
    public class StaffHelper
    {
        public static List<ComboBoxDataSources> FillGender()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();

            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "M",
                DisplayMember = "Male"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "F",
                DisplayMember = "Female"
            });

            return comboBoxDataSources;
        }
        public static List<ComboBoxDataSources> FillCategory()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "1",
                DisplayMember = "General"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = "OBC"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "3",
                DisplayMember = "BC(A)"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "4",
                DisplayMember = "BC(B)"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "5",
                DisplayMember = "SC"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "6",
                DisplayMember = "ST"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "7",
                DisplayMember = "SBC"
            });
            return comboBoxDataSources;
        }
        public static List<ComboBoxDataSources> FillQual()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "1",
                DisplayMember = "M.tech"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = "M.ed"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "3",
                DisplayMember = "B.ed"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "4",
                DisplayMember = "M.A"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "5",
                DisplayMember = "M.com"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "6",
                DisplayMember = "B.A"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "7",
                DisplayMember = "B.tech"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "8",
                DisplayMember = "B.com"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "9",
                DisplayMember = "12th"
            });
            return comboBoxDataSources;
        }
        public static List<ComboBoxDataSources> FillRole()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "1",
                DisplayMember = "Admin"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = "Staff"
            });
            return comboBoxDataSources;
        }
       public static List<tblState> FillState()
        {
            var val = RestAPIHelper.GetAsync<List<tblState>>("api/State/GetState");
            tblState tblState = new tblState();
            tblState.ID = 0;
            tblState.StateName = "-Select-";

            val.Insert(0, tblState);
            return val;
        }
        public static List<tblDesignation> FillDesignation()
        {
            var val = RestAPIHelper.GetAsync<List<tblDesignation>>("api/Designation/GetDesignation");
            tblDesignation tblDesg = new tblDesignation();
            tblDesg.ID = 0;
            tblDesg.Name = "-Select-";
            val.Insert(0, tblDesg);
            return val;
        }
        public static List<tblCity> FillCityByStateID(int id)
        {
            var val = RestAPIHelper.GetAsync<List<tblCity>>($"api/City/GetCityByStateID/{id}");
            tblCity tblCity = new tblCity();
            tblCity.ID = 0;
            tblCity.CityName = "-Select-";
            tblCity.StateID = 0;
            if (val == null)
            {
                // List<tblCity> lstCity = new List<tblCity>();
                // lstCity.Add(tblCity);
                // CmbCity.DataSource = lstCity;
                val.Add(tblCity);
            }
            else
            {
                val.Insert(0, tblCity);
            }
            return val;
        }
        public static List<tbldepartment> FillDepartment()
        {
            var val = RestAPIHelper.GetAsync<List<tbldepartment>>("api/Department/GetDepartment");
            tbldepartment tblDept = new tbldepartment();
            tblDept.ID = 0;
            tblDept.Name = "-Select-";

            val.Insert(0, tblDept);
            return val;
        }
        public static List<tblSubject> FillSubject1(List<tblSubject> subjects1)
        {
           //List<tblSubject> subjects1 = new List<tblSubject>(subjectsByDeptId);

            tblSubject tblSubject = new tblSubject();
            tblSubject.ID = 0;
            tblSubject.SubjectName = "-Select-";
            tblSubject.DeptID = 0;

            if (subjects1 == null)
            {
                subjects1.Add(tblSubject);
            }
            else
            {
                subjects1.Insert(0, tblSubject);
            }
            return subjects1;
        }
        public static List<tblSubject> FillSubject2(List<tblSubject> subjects2,int idSub1)
        {
            if (idSub1 != 0)
            {
                // subjects2 = new List<tblSubject>(subjectsByDeptId);
                subjects2.RemoveAll(r => r.ID == idSub1);
            }
            else
            {
                subjects2.Clear();

            }
            tblSubject tblSubject = new tblSubject();
            tblSubject.ID = 0;
            tblSubject.SubjectName = "-Select-";
            tblSubject.DeptID = 0;

            if (subjects2 == null)
            {
                subjects2.Add(tblSubject);
            }
            else
            {
                subjects2.Insert(0, tblSubject);
            }
            return subjects2;
        }
        public static List<tblSubject> FillSubject3(List<tblSubject> subjects3, int idSub1,int idSub2)
        {
            if (idSub2 != 0)
            {
                subjects3.RemoveAll(r => r.ID == idSub1);
                subjects3.RemoveAll(r => r.ID == idSub2);
            }
            else
            {
                subjects3.Clear();
            }
            tblSubject tblSubject = new tblSubject();
            tblSubject.ID = 0;
            tblSubject.SubjectName = "-Select-";
            tblSubject.DeptID = 0;

            if (subjects3 == null)
            {
                subjects3.Add(tblSubject);
            }
            else
            {
                subjects3.Insert(0, tblSubject);
            }
            return subjects3;
        }
    }
}
