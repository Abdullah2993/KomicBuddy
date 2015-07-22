using System.IO;
using System.Windows.Forms;

namespace KomicBuddy
{
    public static class Profile
    {
        static Profile()
        {
            SettingsPath = Path.Combine(Application.StartupPath, "settings.dat");
            Settings.Load();
        }

        public static Settings Settings { get; set; }
        public static string SettingsPath { get; private set; }
    }
}