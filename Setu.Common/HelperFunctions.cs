using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Setu.Common
{
    public static class HelperFunctions
    {
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
