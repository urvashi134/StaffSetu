using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Setu.Entities
{
    [Table("confirmedattendence")]
    public class tblConfirmedAttendence
    {
        [Key]
        public int Id { get; set; }
        public int StaffId { get; set; }
        public float PresentDays { get; set; }
        public float AbsentDays { get; set; }
        public float LeaveDays { get; set; }
        public float WorkingHrs { get; set; }
        public float SalaryCalculated { get; set; }
        public bool Isposted { get; set; }
        public string Error { get; set; }
        public DateTime PostedOn { get; set; }
        public int ConfirmedBy { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
}
