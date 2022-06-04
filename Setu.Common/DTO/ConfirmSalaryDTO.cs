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
    }
}
