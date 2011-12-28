using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointBlankServer.src.Services;
using PointBlankServer.src.network;
using PointBlankServer.src;
using System.Threading;
using PointBlankServer.src.services.consolemessages;
using LogLG;

namespace PointBlankServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtil.consoleinfo("STARTING Point Blank SERVER");
            ConsoleUtil.consoleinfo("Server by DarkTeam");
            ConsoleUtil.consoleinfo("Revision: 70");
            ConsoleUtil.cwrite("Properties");
            if (!PropertiesLoader.loader())
            {
            }
            else
            
            {
                ConsoleUtil.cwrite("Started");
                Console.WriteLine("Creating server...");
                Server Serv = new Server(PropertiesLoader.ipadd(), Convert.ToInt32(PropertiesLoader.portadd()));
                Thread consolemessagesthread = new Thread(new ThreadStart(consolemessages.run));
                consolemessagesthread.Priority = ThreadPriority.Lowest;
                consolemessagesthread.Start();
            }
            
        }
        }



    }
