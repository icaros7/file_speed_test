using System;
using System.Reflection;
using log4net;

namespace File_Speed_Test_Core
{
    public class AppInit
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private string url;
        private string dir;
        private string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString();

        public AppInit(string _url, string _dir)
        {
            log.Info(@"");
            log.Info(@"==== App Start ====");
            url = _url;
            dir = _dir;
        }

        public AppInit(string args)
        {
            log.Info(@"");
            log.Info(@"==== App Start ====");
            url = args;
        }

        public AppInit()
        {
            log.Info(@"");
            log.Info(@"==== App Start ====");
        }
        
        public string Init()
        {
            // Application Init Process
            log.Info(@"> App Initializing");
            log.Info(@">> Version : " + version);
            log.Info(@">> StreamURL : " + url);
            log.Info(@">> Target Dir : " + dir);

            if (url == null)
            {
                log.Info(@">> Detected no argument");
                log.Info(@"> App Initialized");
                log.Info(@"");
                return "No Args";
            }
            else if (url == "help")
            {
                log.Info(">> Detected argument \"--help\"");
                log.Info(@"> App Initialized");
                log.Info(@"");
                return "GetHelp";
            }
            else
            {
                log.Info(@"> App Initialized");
                log.Info(@"");
                return "Normal";
            }
        }

        public string Print()
        {
            log.Info(@"> No Args");
            Console.WriteLine(str.no_args);
            return "Normal";
        }
        
        public void Exit(string status)
        {
            log.Info(@"> Call App Exit (Status : " + status + @")");
            Console.WriteLine(str.press_key_exit);
            Console.Read();
            log.Info(@"==== App Exit ====");
            log.Info(@"");
            Environment.Exit(0);
        }
    }
}