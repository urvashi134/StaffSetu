using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class UserAttendenceReport
    {
        public int StaffId { get; set; }
        public DateTime AttendenceFrom { get; set; }
        public DateTime AttendenceTill { get; set; }

    }
}
