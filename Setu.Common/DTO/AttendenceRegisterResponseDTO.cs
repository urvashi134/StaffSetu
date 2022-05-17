using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class AttendenceRegisterResponseDTO
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Status { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
