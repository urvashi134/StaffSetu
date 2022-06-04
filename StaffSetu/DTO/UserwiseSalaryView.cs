using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffSetu.DTO
{
    public class UserwiseSalaryView
    {
        public string Month{ get; set; }
        public float PresentDays { get; set; }
        public float AbsentDays { get; set; }
        public float LeaveDays { get; set; }
        public float WorkingHrs { get; set; }
        public float SalaryCalculated { get; set; }
    }
}
