using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class ConfirmSalaryView
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int PresentDays { get; set; }
        public int AbsentDays { get; set; }
        public int LeaveDays { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal SalaryCalculated { get; set; }
    }
}
