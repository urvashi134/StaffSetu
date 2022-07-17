using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Staff_Management
{
    public class ConvertTime
    {
        public string Hour;
        public string Minute;
        public string Second;
        public string type;
        public ConvertTime()
        {
            Hour = "00";
            Minute = "00";
            Second = "00";
        }
        public void settime(string Time, bool isType = false)
        {
            Time = Regex.Replace(Time, "[A-Za-z ]", "");
            string[] A = Time.ToString().Split(':');
            if (A.Length > 0)
            {
                if (A[0].IsStringNullOrEmpty())
                {
                    A[0] = "00";
                }
                Hour = Convert.ToString((A[0]));
                if (Hour.Length > 2)
                {
                    Hour = Hour.Substring(Hour.Length - 2);
                }
                else if (Hour.Length < 2)
                {
                    Hour = "0" + Hour;
                }

            }
            if (A.Length > 1)
            {
                if (A[1].IsStringNullOrEmpty())
                {
                    A[1] = "00";
                }
                Minute = Convert.ToString((A[1]));
                if (Minute.Length > 2)
                {
                    Minute = Minute.Substring(Minute.Length - 2);
                }
                else if (Minute.Length < 2)
                {
                    Minute = "0" + Minute;
                }
            }
            if (isType)

            {
                if (Minute.ToInt32() >= 60)
                {
                    Hour = (Hour.ToInt32() - Minute.ToInt32() / 60).ToString();
                    Minute = (Minute.ToInt32() % 60).ToString();
                }
                if (Hour.ToInt32() > 12)
                {
                    Hour = (Hour.ToInt32() % 12).ToString();
                    type = ResourceHelper.GetValue(TimeTypeEnum.PM.ToString());
                    if(type == null)
                    {
                        type = TimeTypeEnum.PM.ToString();
                    }
                }

                else
                {
                    type = ResourceHelper.GetValue(TimeTypeEnum.AM.ToString());
                    if (type == null)
                    {
                        type = TimeTypeEnum.AM.ToString();
                    }
                }
            }

        }

    }
}
