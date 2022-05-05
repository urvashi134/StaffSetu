using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Setu.Entities
{
    [Table("attendenceRules")]
    public class tblAttendenceRules
    {
        public int ID { get; set; }
        public string RuleName { get; set; }
        public int DesgId { get; set; }

        [ForeignKey("DesgId")]
        public tblDesignation designation { get; set; }
        public bool WorkingHourDay { get; set; }
        public int WorkingHours { get; set; }
        public bool SalaryCalculation { get; set; }
        public int SalaryCalculationDays { get; set; }
        public int LeavesAllowed { get; set; }
    }
}
