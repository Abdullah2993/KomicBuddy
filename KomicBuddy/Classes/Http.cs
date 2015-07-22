using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace KomicBuddy
{
    public static class Http
    {
        public static Image Download(string url)
        {
            byte[] buffer = DownloadBytes(url);
            return Image.FromStream(new MemoryStream(buffer));
        }

        public static void Download(string url, string path)
        {
            byte[] buffer = DownloadBytes(url);
            using (var fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }

        private static HttpWebResponse GetResponse(string url, int range = 0)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0";
            request.Accept = "image/png,image/*;q=0.8,*/*;q=0.5";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.KeepAlive = true;
            request.Timeout = Profile.Settings.Timeout*1000;
            if (range > 0)
            {
                request.AddRange(range);
            }
            return (HttpWebResponse) request.GetResponse();
        }

        private static byte[] DownloadBytes(string url)
        {
            HttpWebResponse response = GetResponse(url);
            var length = (int) response.ContentLength;
            var buffer = new byte[length];
            int readIndex = 0;
            using (Stream stream = response.GetResponseStream())
            {
                if (stream != null)
                {
                    int read;
                    while ((read = stream.Read(buffer, readIndex, length - readIndex)) > 0)
                    {
                        readIndex += read;
                    }
                }
            }
            response.Close();
            if (readIndex < length &&
                string.Equals(response.Headers["Accept-Ranges"], "bytes", StringComparison.InvariantCultureIgnoreCase))
            {
                DownloadEx(url, buffer, readIndex, length);
            }
            return buffer;
        }

        private static void DownloadEx(string url, byte[] buffer, int readIndex, int length)
        {
            using (HttpWebResponse response = GetResponse(url, readIndex))
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        int read;
                        while ((read = stream.Read(buffer, readIndex, length - readIndex)) > 0)
                        {
                            readIndex += read;
                        }
                    }
                }
            }
            if (readIndex < length)
            {
                DownloadEx(url, buffer, readIndex, length);
            }
        }
    }
}