using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Setu.Entities
{
    [Table("attendence")]
    public class tblAttendence
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        [ForeignKey("StaffID")]
        public tblStaff staff { get; set; }
        public DateTime myDate { get; set; }
        public char Status { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
