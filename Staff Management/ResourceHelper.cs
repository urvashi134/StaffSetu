using Setu.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Linq;

namespace Staff_Management
{
    public static class ResourceHelper
    {
        public static string GetValue(string key)
        {
            string Language = GlobalData.language;
            LoadResource();
            var keyValuePair =  GlobalData.resourceDetail[Language].FirstOrDefault(x => x.Key == key);

            return keyValuePair.Value;
        }
        public static void SetLabel(Control form)
        {

            string Language = GlobalData.language;
            LoadResource();
            foreach (Control ctrl in form.Controls)
            {
                SetLabel(ctrl);
                var ctrllabel = GlobalData.resourceDetail[Language].FirstOrDefault(x => x.Key == ctrl.Name);
                if (ctrllabel.Value != null)
                {
                    ctrl.Text = ctrllabel.Value;
                }
            }
        }

        private static void LoadResource()
        {
            string Language = GlobalData.language;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Language);
            if (GlobalData.resourceDetail == null || !GlobalData.resourceDetail.ContainsKey(Language) || GlobalData.resourceDetail[Language].Count == 0)
            {
                List<KeyValuePair<string, string>> listResource = new List<KeyValuePair<string, string>>();
                using (ResXResourceReader resxReader = new ResXResourceReader($"Resource\\Resource_Label.{Language}.resx"))
                {
                    IDictionaryEnumerator oResource = resxReader.GetEnumerator();
                    while (oResource.MoveNext())
                    {
                        listResource.Add(new KeyValuePair<string, string>(oResource.Key.ToString(), oResource.Value.ToString()));
                    }
                    if (listResource.Count > 0)
                    {
                        GlobalData.resourceDetail[Language] = listResource;
                    }
                }
            }
        }

    }
}
