using log4net;
using System;
using System.Net;
using System.Threading.Tasks;

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

        public async Task<string> Init(string _url, string _dir)
        {
            url = _url;
            dir = _dir;
            
            log.Info(@">> Main Initializing");
            
            //TODO: Main Part.
            await DownloadTask();

            return "Exception";
        }

        private async Task<double> DownloadTask()
        {
            Uri uri = new Uri(url);
            WebClient web = new WebClient();
            double startt = Environment.TickCount;
            log.Info(@">>> Start Download at " + startt);
            try
            {
                web.DownloadFile(uri, dir);
            }
            catch (Exception e)
            {
                log.Error(@">>>> Expcetion : " + e);
            }

            double endt = Environment.TickCount;
            double sec = Math.Floor(endt - startt) / 1000;
            double secs = Math.Round(sec, 0);
            double kbs = Math.Round(1024 / secs);
            log.Info(@">>> Ended Download at " + endt);
            log.Info(@">>> Speed : " + kbs + @"KB/s");

            return kbs;
        }
    }
}