using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PointBlankServer.src.Services;


//using СlientandserverTest.src.services.encrypt.encryptservice;

namespace PointBlankServer.src.services.consolemessages
{
    class consolemessages
    {
        public static string message = null;

        public static bool consolemessagesstart()
        {
            Console.WriteLine("Console commands:");
            Console.WriteLine("shutdown - this command shutdown LoginServer");
            return true;
        }

        public static void run()
        {

            do
            {
                message = Console.ReadLine();
                if (message != null)
                {
                    switch (message)
                    {
                        case "shutdown":
                            ConsoleUtil.consoleinfo("SERVER IS SHUTTING DOWN!");
                            ShutDown.ShutDownAll();
                            break;
                    }
                }
            }
            while (message != null);
        }
    }
}