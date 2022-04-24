using System;
using System.Collections.Generic;
using System.Text;

namespace Staff_Management
{
    public static class GlobalData
    {
        public static Dictionary<string, List<KeyValuePair<string, string>>> resourceDetail = new Dictionary<string, List<KeyValuePair<string, string>>>();
        public static string language = "en";
        public static string role;
        public static int ID;
    }
}
