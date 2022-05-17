using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Setu.Entities
{
    [Table("staff")]
    public class tblStaff
    {
        // primary key
        [Key]
        public int ID { get; set; }
        public string StaffName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public char Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Category { get; set; }
        public int? StateID { get; set; }  //fk
        [ForeignKey("StateID")]
        public tblState state { get; set; }
        public int? CityID { get; set; }   //fk
        [ForeignKey("CityID")]
        public tblCity city { get; set; }   
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public long MobileNo { get; set; }
        public long? OtherContactNo { get; set; }
        public string Qualification { get; set; }
        public string Role { get; set; }
        public int DesignationID { get; set; }  //fk

        [ForeignKey("DesignationID")]
        public tblDesignation designation { get; set; }
        public int DepartmentID { get; set; }   //fk
        [ForeignKey("DepartmentID")]
        public tbldepartment department { get; set; }
        public int Subject1ID { get; set; }
        [ForeignKey("Subject1ID")]
        public tblSubject subject1 { get; set; }
        public int? Subject2ID { get; set; }
        [ForeignKey("Subject2ID")]
        public tblSubject subject2 { get; set; }

        public int? Subject3ID { get; set; }
        [ForeignKey("Subject3ID")]
        public tblSubject subject3 { get; set; }
        public decimal Salary   { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Experience { get; set; }
        public string FingerPrintdata { get; set; }
        public string FingerPrintANSI { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string IfscCode { get; set; }
        public string UpiId { get; set; }
    }
}
