using System;
using System.Collections.Generic;
using System.Text;

namespace Staff_Management.DTO
{
    public class AttendenceRulesDTO
    {
        public int ID { get; set; }
        public string RuleName { get; set; }
        public string Designation { get; set; }
        public bool IsWorkingHours { get; set; }
        public int WorkingHours { get; set; }
        public bool IsDayWise { get; set; }
        public int SalaryCalculationDays { get; set; }
        public int LeavesAllowed { get; set; }
    }
}
