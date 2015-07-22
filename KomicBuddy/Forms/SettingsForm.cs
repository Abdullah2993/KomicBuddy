using System;
using System.Windows.Forms;

namespace KomicBuddy
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            trayCheck.Checked = Profile.Settings.MinimizeToTray;
            pdfCheck.Checked = Profile.Settings.CreatePdf;
            deleteCheck.Checked = Profile.Settings.DeleteImages;
            locationText.Text = Profile.Settings.DownloadLocation;
            retriesNumber.Value = Profile.Settings.Retries;
            timeoutNumber.Value = Profile.Settings.Timeout;
            openPdfCheck.Checked = Profile.Settings.OpenPdf;
            nothingOption.Checked = Profile.Settings.DoNothing;
            notifyOption.Checked = Profile.Settings.Notify;
            errorLogCheck.Checked = Profile.Settings.LogErrors;
            resumeCheck.Checked = Profile.Settings.Resume;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Profile.Settings.MinimizeToTray = trayCheck.Checked;
            Profile.Settings.CreatePdf = pdfCheck.Checked;
            Profile.Settings.DeleteImages = deleteCheck.Checked;
            Profile.Settings.DownloadLocation = locationText.Text;
            Profile.Settings.Retries = (int) retriesNumber.Value;
            Profile.Settings.Timeout = (int) timeoutNumber.Value;
            Profile.Settings.OpenPdf = openPdfCheck.Checked;
            Profile.Settings.DoNothing = nothingOption.Checked;
            Profile.Settings.Notify = notifyOption.Checked;
            Profile.Settings.LogErrors = errorLogCheck.Checked;
            Profile.Settings.Resume = resumeCheck.Checked;
            Settings.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog {ShowNewFolderButton = true})
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    locationText.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}