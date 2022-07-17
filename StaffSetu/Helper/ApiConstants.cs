using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management.Helper
{
    public static class ApiConstants
    {
        #region Login API
        public static string API_POST_LOGIN_AUTHENTICATE = "api/Authentication/authenticate";
        #endregion

        #region Attendence API
        public static string API_POST_ATTENDENCE_INSERT_UPDATE = "api/Attendence/Insert_Update_Attendence";
        public static string API_POST_ATTENDENCE_GET_ATTENDENCE_BY_DATE = "api/Attendence/GetAttendenceByDate";
        public static string API_GET_ATTENDENCE_GET_ATTENDENCE_ID_MONTH_WISE = "api/Attendence/GetAttendenceByStaffIdMonthYear";
       // public static string API_GET_ATTENDENCE_GET_ATTENDENCE_ID_DATE = "api/Attendence/GetAttendenceByStaffIdMonthYear";
        public static string API_POST_ATTENDENCE_INSERT_ATTENDENCE = "api/Attendence/InsertAttendence";
        public static string API_POST_ATTENDENCE_UPDATE_ATTENDENCE = "api/Attendence/UpdateAttendence";
        public static string API_POST_ATTENDENCE_GET_DAILYATTENDENCE_ID_DATE = "api/Attendence/GetAttendenceByStaffIdDate";
        public static string API_GET_ATTENDENCE_GET_ATTENDENCE_ALL_MONTH_WISE = "api/Attendence/GetAttendenceByMonthYear";
        #endregion

        #region Attendence Rules API
        public static string API_GET_ATTENDENCERULES_GET_RULES = "api/AttendenceRules/GetAttendenceRules";
        public static string API_POST_ATTENDENCERULES_INSERT_RULES = "api/AttendenceRules/InsertAttendenceRules";
        public static string API_GET_ATTENDENCERULES_GET_RULES_BY_DESG = "api/AttendenceRules/GetAttendenceRulesByDesg";
        public static string API_POST_ATTENDENCERULES_UPDATE_RULES = "api/AttendenceRules/UpdateAttendenceRules";
        #endregion

        #region Department API
        public static string API_GET_DEPARTMENT_GETDEPARTMENT = "api/Department/GetDepartment";
        public static string API_GET_DEPARTMENT_GETDEPARTMENTBYID = "api/Department/GetDepartmentByID";
        public static string API_GET_DEPARTMENT_INSERTDEPARTMENT = "api/Department/InsertDepartment";
        public static string API_GET_DEPARTMENT_UPDATEDEPARTMENT = "api/Department/UpdateDepartment";
        public static string API_DELETE_DEPARTMENT_DELETEDEPARTMENT = "api/Department/DeleteDepartment";
        #endregion

        #region Staff API
        public static string API_GET_STAFF_GETSTAFF = "api/Staff/GetStaff";
        public static string API_GET_STAFF_GETSTAFFFORLOGIN = "api/Staff/GetStaffForLogin";
        public static string API_POST_STAFF_INSERTSTAFF = "api/Staff/InsertStaff";
        public static string API_GET_STAFF_GETSTAFFBYID = "api/Staff/GetStaffByID";
        public static string API_POST_STAFF_UPDATESTAFF = "api/Staff/UpdateStaff";
        public static string API_DELETE_STAFF_DELETESTAFF = "api/Staff/DeleteStaff";
        #endregion

        #region Designation API
        public static string API_GET_DESIGNATION_GETDESIGNATION = "api/Designation/GetDesignation";
        public static string API_POST_DESIGNATION_ADD_DESIGNATION = "api/Designation/InsertDesignation";
        #endregion

        #region Subject API
        public static string API_GET_SUBJECT_GETSUBJECT = "api/Subject/GetSubject";
        public static string API_POST_SUBJECT_ADD_SUBJECT = "api/Subject/InsertSubject";
        public static string API_GET_SUBJECT_GETSUBJECTBYDEPT = "api/Subject/GetSubjectByDepartmentID";
        public static string API_DELETE_SUBJECT_DELETESUBJECT = "api/Subject/DeleteSubject";
        #endregion

        #region State API
        public static string API_GET_STATE_GETSTATE = "api/State/GetState";
        #endregion

        #region City API
        public static string API_GET_CITY_GETCITY_BY_STATE = "api/City/GetCityByStateID";
        #endregion

        #region 
        public static string API_GET_SALARY_GETSALARY_BY_ID_DATE = "api/Salary/GetSalaryByStaffIdYear";
        #endregion
    }
}
