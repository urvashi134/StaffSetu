﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class MonthlyAttendenceReportView
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int Leaves { get; set; }
        public int WorkingHours {get; set;}
    }
}
