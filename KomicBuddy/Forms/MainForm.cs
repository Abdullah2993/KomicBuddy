using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace KomicBuddy
{
    public partial class MainForm : Form
    {
        private const string MangaRegex =
            @"<tr class=""line record"">\s*<td><a href=""(?<link>.*?)"">(?<name>.*?)</a> \((?<rank>\d*?)\)( <img src=""themes/classic/images/icon-updated.png"" alt=""(?<updated>.*?)"" />)?</td>\s*<td class=""latest_column""><a href=""\<link>/chapter/(?<latest>\d*?)"" title=""\<name> \<latest>"">\<latest></a></td>\s*<td class=""updated_column"">(?<date>.*?)</td>\s*</tr>";

        private const string ChapterRegex =
            @"<tr class=""line record"">\s*<td><a href=""(?<link>.*?/.*?)"">(?<name>.*?)</a>( <img src=""themes/classic/images/icon-new.png"" alt=""(?<new>New!)"" />)?</td>\s*<td class=""scanlated_column"">(?<scanlated>.*?)</td>\s*<td class=""added_column"">(?<date>.*?)</td>\s*</tr>";


        public MainForm()
        {
            InitializeComponent();
            IsRunning = false;
            Comics = new List<Manga>();
        }

        private bool IsRunning { get; set; }
        private List<Manga> Comics { get; set; }

        private void comicPrefixCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            Application.DoEvents();
            comicSearchButton.PerformClick();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog() != DialogResult.OK)
                    return;

                if (!IsRunning)
                {
                    Log("Settings changed.");
                }
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
           using (var about = new AboutForm())
           {
               about.ShowDialog();
           }
        }

        private void Log(string messageFormat, params object[] args)
        {
            status.Text = string.Format(messageFormat, args);
        }

        private static string GetPrefixLink(object prefix)
        {
            return string.Format("http://www.mangahit.com/mangas/{0}", prefix);
        }

        private static string GetMangaLink(object name)
        {
            return string.Format("http://www.mangahit.com/{0}", name);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                return;

            if (Profile.Settings.MinimizeToTray)
            {
                Hide();
            }
        }

        private void DisplayMangaInformation(Manga manga)
        {
            comicInformationBox.Text = string.Format("Name: {0}\r\nRank: {1}\r\nLatest: {2}\r\nStatus: {3}", manga.Name,
                                                     manga.Rank, manga.Latest, manga.Status);
        }

        private void comicSearchButton_Click(object sender, EventArgs e)
        {
            if (IsRunning)
                return;

            if (comicPrefixCombo.Text.Length == 1)
            {
                IsRunning = true;
                Log("Searching for comics...");
                comicList.Items.Clear();
                Comics.Clear();
                comicInformationBox.Clear();
                var searchThread = new Thread(LoadComics) {IsBackground = true};
                searchThread.Start(comicPrefixCombo.Text);
            }
            else
            {
                Log("Select a valid prefix(A-Z).");
            }
        }

        private void LoadComics(object prefix)
        {
            try
            {
                string source;
                using (var client = new WebClient())
                {
                    source = client.DownloadString(GetPrefixLink(prefix));
                }
                var matches = Regex.Matches(source, MangaRegex);
                var mangas = (from Match match in matches
                                  let manga =
                                      new Manga(match.Groups["name"].Value, match.Groups["link"].Value,
                                                match.Groups["rank"].Value, match.Groups["updated"].Value,
                                                match.Groups["latest"].Value)
                                  select manga).ToArray();
                var names = (from Manga manga in mangas select manga.Name).ToArray<object>();

                Comics.AddRange(mangas);
                comicList.Invoke(new Action(() => comicList.Items.AddRange(names)));
                Log("Select a manga.");
            }
            catch (Exception ex)
            {
                Log("Error: {0}", ex.Message);
            }
            IsRunning = false;
        }

        private void comicPrefixCombo_TextChanged(object sender, EventArgs e)
        {
            if (comicPrefixCombo.Items.Contains(comicPrefixCombo.Text.ToUpper()))
            {
                comicPrefixCombo.SelectedItem = comicPrefixCombo.Text.ToUpper();
                Application.DoEvents();
                comicSearchButton.PerformClick();
            }
            else
            {
                comicPrefixCombo.ResetText();
            }
        }

        private void comicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMangaInformation(Comics[comicList.SelectedIndex]);
        }

        private void comicList_DoubleClick(object sender, EventArgs e)
        {
            if (IsRunning)
                return;

            IsRunning = true;
            Log("Loading chapters...");
            var chapterThread = new Thread(LoadChapters) {IsBackground = true};
            chapterThread.Start(Comics[comicList.SelectedIndex].Link);
        }

        private void LoadChapters(object name)
        {
            try
            {
                string source;
                using (var client = new WebClient())
                {
                    source = client.DownloadString(GetMangaLink(name));
                }

                var matches = Regex.Matches(source, ChapterRegex);

                var items = (from Match match in matches
                                            select
                                                new Chapter(match.Groups["name"].Value, match.Groups["scanlated"].Value,
                                                            match.Groups["date"].Value, match.Groups["link"].Value,
                                                            !string.IsNullOrEmpty(match.Groups["new"].Value.Trim()))
                                            into chapter select (ListViewItem) chapter).ToList();

                comicChapterList.Invoke(
                    new Action<List<ListViewItem>>(chapters => comicChapterList.Items.AddRange(chapters.ToArray())),
                    items);

                Log("Select a chapter");
            }
            catch (Exception ex)
            {
                Log("Error: {0}", ex.Message);
            }
            IsRunning = false;
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                return;

            Show();
            WindowState = FormWindowState.Normal;
        }

        private void comicChapterList_Click(object sender, EventArgs e)
        {
            var downloadForm = new DownloadForm((Chapter) comicChapterList.SelectedItems[0].Tag);
            downloadForm.Closing += downloadForm_Closing;
            downloadForm.SizeChanged +=downloadForm_SizeChanged;
            downloadForm.Show();
            
        }

        void downloadForm_SizeChanged(object sender, EventArgs e)
        {
            var form = (DownloadForm)sender;
            if (form.WindowState != FormWindowState.Minimized)
            { 
                if (downloadListMenu.Items.Contains(form.Tag))
                {
                    downloadListMenu.Items.Remove(form.Tag);
                }
                form.Show();
                form.WindowState=FormWindowState.Normal;
            }
            else
            {
                downloadListMenu.Items.Add(form.Tag);
                form.Hide();
            }

        }

        void downloadForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var form = (DownloadForm) sender;
            if (downloadListMenu.Items.Contains(form.Tag))
            {
                downloadListMenu.Items.Remove(form.Tag);
            }
            if (Profile.Settings.Notify)
            {
                trayIcon.ShowBalloonTip(300, "Download Completed",
                                        string.Format("{0} is completed.", form.CurrentChapter.Name), ToolTipIcon.Info);
            }
        }

        private void downloadListMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var form = (DownloadForm)(e.ClickedItem).Tag;
            if (downloadListMenu.Items.Contains(form.Tag))
            {
                downloadListMenu.Items.Remove(form.Tag);
            }
            form.Show();
            form.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var updateThreaded = new Thread(() =>
            {
                try
                {
                    using (var webclient = new WebClient())
                    {
                        var source = webclient.DownloadString(string.Format("http://app-update-system.appspot.com/kb.php?ver={0}",
                                                               Application.ProductVersion));
                        if (source == "1")
                        {
                            Invoke(new MethodInvoker(ShowUpdateMessage));
                        }
                    }
                }
                catch (Exception)
                {
                }
            });
            updateThreaded.Start();
        }

        private static void ShowUpdateMessage()
        {
            MessageBox.Show("A new version is available for download.", "Update Availabe", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}