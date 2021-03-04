using System;

namespace File_Speed_Test_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInit init = args.Length switch
            {
                >= 2 => new AppInit(args[0], args[1]),
                1 => new AppInit(args[0]),
                _ => new AppInit()
            };

            string status = init.Init();

            switch (status)
            {
                case "GetHelp":
                {
                    GetHelp help = new GetHelp();
                    status = help.Print();
                    init.Exit(status);
                    break;
                }
                case "No Args":
                    status = init.Print();
                    init.Exit(status);
                    break;
                case "Normal":
                    
                    break;
                default:
                    Console.WriteLine(str.unknown_error);
                    init.Exit(status);
                    break;
            }
        }
    }
}