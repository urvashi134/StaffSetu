using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class ConfirmSalaryDTO
    {
        public int beneId { get; set; }
        public float amount { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public float PresentDays { get; set; }
        public float AbsentDays { get; set; }
        public float LeaveDays { get; set; }
        public float WorkingHrs { get; set; }
        public decimal MonthlySalary { get; set; }
    }
}
