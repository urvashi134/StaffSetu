using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffSetu.DTO
{
    public class StaffView
    {
        public int ID { get; set; }
        public string StaffName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Category { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        //public string Password { get; set; }
        public long MobileNo { get; set; }
        public long? OtherContactNo { get; set; }
        public string Qualification { get; set; }
        public string Role { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
        public string Subject1Name { get; set; }
        public string Subject2Name { get; set; }
        public string Subject3Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Experience { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string IfscCode { get; set; }
        public string UpiId { get; set; }
    }
}
