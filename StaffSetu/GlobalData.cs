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
        public static string token;
        public static MFS100 mfs100 = null;
        public static string SUCCESS = "SUCCESS";
        public static List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>()
        {
            new ComboBoxDataSources() { DisplayMember = "Jan", Value = "1" },
            new ComboBoxDataSources() { DisplayMember = "Feb", Value = "2" },
            new ComboBoxDataSources() { DisplayMember = "Mar", Value = "3" },
            new ComboBoxDataSources() { DisplayMember = "Apr", Value = "4" },
            new ComboBoxDataSources() { DisplayMember = "May", Value = "5" },
            new ComboBoxDataSources() { DisplayMember = "Jun", Value = "6" },
            new ComboBoxDataSources() { DisplayMember = "Jul", Value = "7" },
            new ComboBoxDataSources() { DisplayMember = "Aug", Value = "8" },
            new ComboBoxDataSources() { DisplayMember = "Sep", Value = "9" },
            new ComboBoxDataSources() { DisplayMember = "Oct", Value = "10" },
            new ComboBoxDataSources() { DisplayMember = "Nov", Value = "11" },
            new ComboBoxDataSources() { DisplayMember = "Dec", Value = "12" },
        };
    }
}
