using System;
using System.Reflection;
using Microsoft.Extensions.Localization;

namespace Setu.Common
{
    public class LocalizeManager
    {
        private readonly IStringLocalizer localizer;

        public LocalizeManager()
        {
            //var type = typeof(SharedResource);
            //var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            //localizer = factory.Create("SharedResource", assemblyName.Name);

        }

        public LocalizedString this[string key]
        {
            get
            {
                return localizer[key];
            }
        }
    }
}
