using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationHelpers
{
    static class ConfigurationHelper
    {
        public static void UpdateKey(string key, string val)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings[key].Value = val;
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetValue(string key)
        {
            string val;
            val = ConfigurationManager.AppSettings[key];
            return val;
        }
    }
}
