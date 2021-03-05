using log4net;
using System;
using System.Net;

namespace File_Speed_Test_Core
{
    public class Main
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private string url;
        private string dir;

        public Main()
        {
            log.Info(@"> Call Main");
        }

        public string Init(string _url, string _dir)
        {
            url = _url;
            dir = _dir;
            
            log.Info(@">> Main Initializing");
            
            //TODO: Main Part.

            return "Exception";
        }

        public double DownloadTask()
        {
            Uri uri = new Uri(url);
            WebClient web = new WebClient();
            double startt = Environment.TickCount;
            web.DownloadFile(uri, dir);

            double endt = Environment.TickCount;
            double sec = Math.Floor(endt - startt) / 1000;
            double secs = Math.Round(sec, 0);
            double kbs = Math.Round(1024 / secs);

            return kbs;
        }
    }
}