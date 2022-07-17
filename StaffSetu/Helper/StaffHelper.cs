using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management.Helper;
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
                DisplayMember = RolesConstant.ROLE_ADMIN
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = RolesConstant.ROLE_DEPT_ADMIN
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "3",
                DisplayMember = RolesConstant.ROLE_STAFF
            });

            return comboBoxDataSources;
        }
       public static List<tblState> FillState()
        {
            var val = RestAPIHelper.GetAsync<List<tblState>>(ApiConstants.API_GET_STATE_GETSTATE);

            List<tblState> tbl = new List<tblState>();
            tblState tblState = new tblState();
            tblState.ID = 0;
            tblState.StateName = "-Select-";

            if (val == null)
                tbl.Add(tblState);
            else
            {
                tbl = val;
                tbl.Insert(0, tblState);
            }
                
            return tbl;
        }
        public static List<tblCity> FillCityByStateID(int id)
        {
            //var val = RestAPIHelper.GetAsync<List<tblCity>>($"api/City/GetCityByStateID/{id}");
            var val = RestAPIHelper.GetAsync<List<tblCity>>($"{ApiConstants.API_GET_CITY_GETCITY_BY_STATE}/{id}");
            tblCity tblCity = new tblCity();
            tblCity.ID = 0;
            tblCity.CityName = "-Select-";
            tblCity.StateID = 0;
            if (val == null)
            {
                val.Add(tblCity);
            }
            else
            {
                val.Insert(0, tblCity);
            }
            return val;
        }
        public static List<tblDesignation> FillDesignation()
        {
            var response = RestAPIHelper.GetAsync<ApiResponse<List<tblDesignation>>>(ApiConstants.API_GET_DESIGNATION_GETDESIGNATION);
            List<tblDesignation> tbl = new List<tblDesignation>();
            tblDesignation tblDesg = new tblDesignation();
            tblDesg.ID = 0;
            tblDesg.Name = "-Select-";

            if (response.IsSuccessfull == true)
            {
                tbl = response.Data;
                tbl.Insert(0, tblDesg);
            }
            else
            {
                tbl.Add(tblDesg);
            }
           
            return tbl;
        }
        
        public static List<tbldepartment> FillDepartment()
        {
          //  var val = RestAPIHelper.GetAsync<List<tbldepartment>>(ApiConstants.API_GET_DEPARTMENT_GETDEPARTMENT);
            var response = RestAPIHelper.GetAsync<ApiResponse<List<tbldepartment>>>(ApiConstants.API_GET_DEPARTMENT_GETDEPARTMENT);
            List<tbldepartment> tbl = new List<tbldepartment>();
            tbldepartment tblDept = new tbldepartment();
            tblDept.ID = 0;
            tblDept.Name = "-Select-";

            if (response.IsSuccessfull == true)
            {
                tbl = response.Data;
                tbl.Insert(0, tblDept);
            }
            else
            {
                tbl.Add(tblDept);
            }

            return tbl;
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
        public static List<ComboBoxDataSources> FillMonth()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();

            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "1",
                DisplayMember = "January"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2",
                DisplayMember = "February"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "3",
                DisplayMember = "March"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "4",
                DisplayMember = "April"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "5",
                DisplayMember = "May"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "6",
                DisplayMember = "June"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "7",
                DisplayMember = "July"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "8",
                DisplayMember = "August"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "9",
                DisplayMember = "September"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "10",
                DisplayMember = "October"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "11",
                DisplayMember = "November"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "12",
                DisplayMember = "December"
            });

            return comboBoxDataSources;
        }

        public static List<ComboBoxDataSources> FillYear()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();

            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2022",
                DisplayMember = "2022"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "2023",
                DisplayMember = "2023"
            });
            return comboBoxDataSources;
        }
    }
}
