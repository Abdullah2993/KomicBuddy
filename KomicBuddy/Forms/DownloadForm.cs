using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using sharpPDF;

namespace KomicBuddy
{
    public partial class DownloadForm : Form
    {
        private const string ProgressFormat = "{0}  - ({1}%)";
        private const string TotalRegex = @"<option value=""(?<pages>\d*?)"" >(?<pages>\1)</option></select>";
        private const string LinkRegex = @"(?<link>http://img.mangahit.com/manga/\d*?/\d*?/)\d*?\.jpg";
        private readonly string _directory;
        private string _link;
        private Thread _mainThread;

        private int _pages;


        public DownloadForm(Chapter chapter)
        {
            InitializeComponent();
            CurrentChapter = chapter;
            Tag = new ToolStripMenuItem {Text = string.Format(ProgressFormat, chapter.Name, 0), Tag = this};
            _pages = 0;
            _link = string.Empty;
            _directory = Path.Combine(Profile.Settings.DownloadLocation, CurrentChapter.Name);
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
        }

        public Chapter CurrentChapter { get; }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            Text = string.Format(ProgressFormat, CurrentChapter.Name, 0);
            _mainThread = new Thread(Main) {IsBackground = true};
            _mainThread.Start();
        }

        private string GetLink(int page)
        {
            return $"{_link}{page.ToString("00")}.jpg";
        }

        private string GetPath(int page)
        {
            return Path.Combine(_directory, $"{page.ToString("00")}.jpg");
        }

        private void LogError(string errorPosition, string error)
        {
            if (Profile.Settings.LogErrors)
            {
                File.AppendAllText(Path.Combine(_directory, "log.txt"),
                    $"[{DateTime.Now.ToShortTimeString()}]\r\n{errorPosition}\r\nError: {error}\r\n-----------------\r\n");
            }
        }

        private void Main()
        {
            try
            {
                string source;
                using (var client = new WebClient())
                {
                    source = client.DownloadString("http://www.mangahit.com/" + CurrentChapter.Link);
                }
                _pages = int.Parse(Regex.Match(source, TotalRegex).Groups["pages"].Value);
                _link = Regex.Match(source, LinkRegex).Groups["link"].Value;
            }
            catch (Exception ex)
            {
                LogError("Error occured while gathering information.", ex.Message);
                goto DONE;
            }

            for (var page = 1; page <= _pages; page++)
            {
                download.Invoke(
                    new Action<int, int>(
                        (current, total) => { download.Text = $"Downloading {current} of {total}"; }),
                    page, _pages);
                var rTime = 0;
                RETRY:
                try
                {
                    if (!(Profile.Settings.Resume && File.Exists(GetPath(page))))
                    {
                        if (rTime <= Profile.Settings.Retries)
                        {
                            Http.Download(GetLink(page), GetPath(page));
                        }
                        else
                        {
                            LogError("Error occured while downloading the image",
                                "Unable to download within given number of retries.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError("Error occured while downloading the image", ex.Message);
                    rTime++;
                    goto RETRY;
                }

                Invoke(new Action<int>(progress =>
                {
                    Tag.Text = string.Format(ProgressFormat, CurrentChapter.Name, progress);
                    Text = string.Format(ProgressFormat, CurrentChapter.Name, progress);
                    progressBar.Value = progress;
                }), (int) ((double) page/_pages*100));
            }

            if (Profile.Settings.CreatePdf)
            {
                try
                {
                    using (var pdf = new pdfDocument(CurrentChapter.Name, "Abdullah Saleem"))
                    {
                        for (var page = 1; page <= _pages; page++)
                        {
                            var file = GetPath(page);

                            if (!File.Exists(file))
                            {
                                LogError("Error occured while creating the PDF", "File not found.");
                                continue;
                            }

                            try
                            {
                                pdf.addImageReference(file, page.ToString("00"));
                                var refrenceImage = pdf.getImageReference(page.ToString("00"));
                                var currentPage = pdf.addPage(refrenceImage.height, refrenceImage.width);
                                currentPage.addImage(refrenceImage, 0, 0, refrenceImage.height, refrenceImage.width);
                            }
                            catch (Exception ex)
                            {
                                LogError("Error occured while creating the PDF[Internal]", ex.Message);
                            }
                        }
                        var pdfPath = Path.Combine(_directory, CurrentChapter.Name + ".pdf");
                        pdf.createPDF(pdfPath);
                        if (Profile.Settings.OpenPdf)
                        {
                            Process.Start(pdfPath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError("Error occured while creating the PDF", ex.Message);
                }
            }

            if (Profile.Settings.DeleteImages)
            {
                for (var page = 1; page <= _pages; page++)
                {
                    var file = GetPath(page);

                    if (!File.Exists(file))
                    {
                        LogError("Error occured while deleting the images", "Image not found.");
                        continue;
                    }

                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        LogError("Error occured while deleting the images", ex.Message);
                    }
                }
            }
            DONE:
            Invoke(new MethodInvoker(Close));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (_mainThread.IsAlive)
            {
                _mainThread.Abort();
            }
            Close();
        }
    }
}