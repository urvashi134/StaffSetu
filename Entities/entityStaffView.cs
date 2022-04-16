using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Entities
{
    public class entityStaffView
    {
        public int ID;
        public string StaffName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public char Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Category { get; set; }
        public string? StateName { get; set; }
        public string? CityName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public long MobileNo { get; set; }
        public long? OtherContactNo { get; set; }
        public string Qualification { get; set; }
        public string Role { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
        public string Subject1Name { get; set; }
        public string? Subject2Name { get; set; }
        public string? Subject3Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Experience { get; set; }

    }
}
