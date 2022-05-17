using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class UserAttendenceReportView
    {
        public DateTime date { get; set; }
        public char status { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
