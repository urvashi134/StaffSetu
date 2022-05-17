using MANTRA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staff_Management
{
    public static class GlobalData
    {
        public static Dictionary<string, List<KeyValuePair<string, string>>> resourceDetail = new Dictionary<string, List<KeyValuePair<string, string>>>();
        public static string language = "en";
        public static string role = "admin";
        public static int ID;
        public static string loginName;
        public static MFS100 mfs100 = null;
        public static string SUCCESS = "SUCCESS";
    }
}
