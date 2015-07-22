using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace KomicBuddy
{
    [Serializable]
    public class Settings
    {
        public Settings()
        {
            MinimizeToTray = true;
            CreatePdf = true;
            DeleteImages = true;
            DownloadLocation = Application.StartupPath;
            Timeout = 60;
            Retries = 3;
            OpenPdf = false;
            DoNothing = false;
            Notify = true;
            Resume = true;
            LogErrors = true;
        }

        public bool MinimizeToTray { get; set; }
        public bool CreatePdf { get; set; }
        public bool DeleteImages { get; set; }
        public string DownloadLocation { get; set; }
        public int Timeout { get; set; }
        public int Retries { get; set; }
        public bool OpenPdf { get; set; }
        public bool DoNothing { get; set; }
        public bool Notify { get; set; }
        public bool Resume { get; set; }
        public bool LogErrors { get; set; }

        public static void Save()
        {
            Save(Profile.SettingsPath, Profile.Settings);
        }

        public static void Load()
        {
            if (File.Exists(Profile.SettingsPath))
            {
                Profile.Settings = Load(Profile.SettingsPath);
            }
            else
            {
                Profile.Settings = new Settings();
                Save();
            }
        }

        public static void Save(string path, Settings settings)
        {
            using (var newSettings = new FileStream(Profile.SettingsPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(newSettings, Profile.Settings);
            }
        }

        public static Settings Load(string path)
        {
            if (!File.Exists(Profile.SettingsPath))
                throw new FileNotFoundException();

            using (var settings = new FileStream(Profile.SettingsPath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                var serializer = new BinaryFormatter();
                return (Settings) serializer.Deserialize(settings);
            }
        }
    }
}