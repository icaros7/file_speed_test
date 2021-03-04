using log4net;

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

            return "Exception";
        }
    }
}