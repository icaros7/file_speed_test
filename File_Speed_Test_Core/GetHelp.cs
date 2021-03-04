using System;
using log4net;

namespace File_Speed_Test_Core
{
    public class GetHelp
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        public GetHelp()
        {
            log.Info(@"> Call GetHelp");
        }

        public string Print()
        {
            //TODO: GetHelp Part.
            
            log.Info(@">> GetHelp Print Success");
            log.Info(@"");

            return "Normal";
        }
    }
}