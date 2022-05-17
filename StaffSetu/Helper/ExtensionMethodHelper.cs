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
    }
}
