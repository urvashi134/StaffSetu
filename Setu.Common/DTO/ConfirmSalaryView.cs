using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class ConfirmSalaryView
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public float PresentDays { get; set; }
        public float AbsentDays { get; set; }
        public float LeaveDays { get; set; }
        public decimal MonthlySalary { get; set; }
        public float SalaryCalculated { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
