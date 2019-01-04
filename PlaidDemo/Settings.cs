using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PlaidDemo
{
    public class Settings
    {
        private static string userSettings = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Plaid Demo");
        private static string settingsPath = Path.Combine(userSettings, "Settings.xml");

        #region Singleton
        public static Settings Instance = new Settings();
        #endregion Singleton

        #region Settings
        public bool ReverseTransactionAmounts { get; set; }
        public List<Institution> SandboxInstitutions { get; set; }
        public List<Institution> DevelopmentInstitutions { get; set; }
        public PlaidSettings PlaidSettings { get; set; }

        private static Settings GetDefaultValues()
        {
            Settings defaultSettings = new Settings();

            defaultSettings.ReverseTransactionAmounts = false;
            defaultSettings.SandboxInstitutions = new List<Institution>();
            defaultSettings.DevelopmentInstitutions = new List<Institution>();

            defaultSettings.PlaidSettings = PlaidSettings.Instance;

            return defaultSettings;
        }
        #endregion Settings

        public static List<Institution> GetCurrentInstitutions()
        {
            if (Instance.PlaidSettings.Environment == Enums.Environment.Sandbox)
                return Instance.SandboxInstitutions;
            else
                return Instance.DevelopmentInstitutions;
        }

        #region Save Settings
        public static void SaveSettings()
        {
            if (!Directory.Exists(userSettings))
                Directory.CreateDirectory(userSettings);

            TextWriter writer = new StreamWriter(settingsPath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
            xmlSerializer.Serialize(writer, Instance);
            writer.Close();
        }
        #endregion Save Settings

        #region Read Settings
        public static void ReadSettings()
        {
            try
            {
                XDocument document = XDocument.Load(settingsPath);
                using (FileStream fileStream = new FileStream(settingsPath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
                    Instance = (Settings)xmlSerializer.Deserialize(fileStream);
                }

                foreach (PropertyInfo prop in typeof(Settings).GetProperties())
                {
                    if (prop.GetValue(Instance) == null) //Check to see if any of the properties are null
                        prop.SetValue(Instance, prop.GetValue(GetDefaultValues())); //Replace that value with the default value
                }
            }
            catch
            {
                Instance = GetDefaultValues();
            }
        }
        #endregion Read Settings
    }
}
