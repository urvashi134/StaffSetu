using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management
{
    public static class ExtensionMethodHelper
    {
        public static bool IsStringNullOrEmpty(this object obj)
        {
            return string.IsNullOrEmpty(Convert.ToString(obj).Trim());
        }

        public static int ToInt32(this object obj)
        {
            string val = Convert.ToString(obj);
            if (string.IsNullOrEmpty(val))
            {
                return 0;
            }
            return int.Parse(val, (IFormatProvider)CultureInfo.CurrentCulture);
        }
        public static string ToStringMonth(this object obj)
        {
            int val = Convert.ToInt32(obj);
            switch(val)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Invalid";
            }
        }
    }
}
