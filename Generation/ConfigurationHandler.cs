using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SKRandomCharGenerator.Generation
{
    public static class ConfigurationHandler
    {
        public static Dictionary<string, string> ReadAllSettings()
        {
            var output = new Dictionary<string, string>();
           
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
                return output;
            else
                foreach (var key in appSettings.AllKeys)
                    output.Add(key, appSettings[key]);

            return output;
        }
        
        public static string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings[key];
        }

        public static void AddUpdateSetting(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (settings[key] == null)
                settings.Add(key, value);
            else
                settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static void UpdateBoolSetting(string key, bool value)
        {
            if (value == true)
                AddUpdateSetting(key, "true");
            else
                AddUpdateSetting(key, "false");
        }

        public static int AsInt(this string value)
        {
            int output;

            if (!int.TryParse(value, out output))
                throw new ArgumentException($"Invalid int value");

            return output;
        }

        public static decimal AsDecimal(this string value)
        {
            decimal output;

            if (!decimal.TryParse(value, out output))
                throw new ArgumentException($"Invalid int value");

            return output;
        }

        public static float AsFloat(this string value)
        {
            float output;

            if (!float.TryParse(value, out output))
                throw new ArgumentException($"Invalid float value");

            return output;
        }

        public static double AsDouble(this string value)
        {
            double output;

            if (!double.TryParse(value, out output))
                throw new ArgumentException($"Invalid double value");

            return output;
        }

        public static bool AsBool(this string value)
        {
            if (value.Equals("true"))
                return true;
            else if (value.Equals("false"))
                return false;
            else
                throw new ArgumentException($"Invalid bool value");
        }
    }
}
