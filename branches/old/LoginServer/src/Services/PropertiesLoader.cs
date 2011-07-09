using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using PointBlankServer.src;
using PointBlankServer.src.Services;

namespace PointBlankServer.src
{
   public class PropertiesLoader
    {
        //NetWorkSettings
        static public string port = null;
        static public string ip = null;
        static public string connector = null;

        static public string ConnectionDeny = null;
        static public string Debug = null;

        //DataBase Settings
        static public string dbhost = null;
        static public string dbport = null;
        static public string dbuser = null;
        static public string dbpass = null;
        static public string dbname = null;

        public static bool loader()
        {
            if (NetworkProperties() && DatabaseProperties()) return true;
            return false;

        }

        public static bool NetworkProperties()
        {
            if (!File.Exists("settings/NetworkSettings.xml"))
            {
                ConsoleUtil.consolerror("settings/NetworkSettings.xml NOT EXIST!!!");
                return false;
            }

            XmlReader reader = XmlReader.Create("settings/NetworkSettings.xml");
            while (reader.Read())
            {
                if (reader.Name == "ip")
                {
                    ip = reader.ReadInnerXml();
                }

                if (reader.Name == "port")
                {
                    port = reader.ReadInnerXml();
                }
                if (reader.Name == "connector")
                {
                    connector = reader.ReadInnerXml();
                }
                if (reader.Name == "ConnectionDeny")
                {
                   ConnectionDeny = reader.ReadInnerXml();
                }
                if (reader.Name == "Debug")
                {
                    Debug = reader.ReadInnerXml();
                }
            }
            if ( port.Length > 0 && ip.Length > 0 && connector.Length >0 )
            {
                ConsoleUtil.consoleinfo("settings/NetworkSettings.xml successfully loaded");
                ConsoleUtil.consoleinfo("Server use this ip: " + ip);
                ConsoleUtil.consoleinfo("Server use this port: " + port);
                ConsoleUtil.consoleinfo("Server enabled: " + connector);
                ConsoleUtil.consoleinfo("Connection Deny: " + ConnectionDeny);
                ConsoleUtil.consoleinfo("Debug: " + Debug);
                return true;
            }
            else
            {
                ConsoleUtil.consolerror("settings/NetworkSettings.xml ERROR WHEN LOADING");
                return false;
            }
        }

        public static bool DatabaseProperties()
        {
            if (!File.Exists("settings/DatabaseSettings.xml"))
            {
                ConsoleUtil.consolerror("settings/DatabaseSettings.xml NOT EXIST!!!");
                return false;
            }

            XmlReader reader = XmlReader.Create("settings/DatabaseSettings.xml");
            while (reader.Read())
            {
                if (reader.Name == "host")
                {
                    dbhost = reader.ReadInnerXml();
                }

                if (reader.Name == "port")
                {
                    dbport = reader.ReadInnerXml();
                }

                if (reader.Name == "user")
                {
                    dbuser = reader.ReadInnerXml();
                }

                if (reader.Name == "pass")
                {
                    dbpass = reader.ReadInnerXml();
                }

                if (reader.Name == "name")
                {
                    dbname = reader.ReadInnerXml();
                }
            }
            if (dbhost.Length > 0 && dbport.Length > 0 && dbuser.Length > 0 && dbname.Length > 0)
            {
                ConsoleUtil.consoleinfo("settings/DatabaseSettings.xml successfully loaded");
                ConsoleUtil.consoleinfo("DataBase host: " + dbhost);
                ConsoleUtil.consoleinfo("Database port: " + dbport);
                ConsoleUtil.consoleinfo("Database user: " + dbuser);
                ConsoleUtil.consoleinfo("Database name: " + dbname);
                return true;
            }
            else
            {
                ConsoleUtil.consolerror("settings/DatabaseSettings.xml ERROR WHEN LOADING");
                return false;
            }
        }

        public static string ipadd()
        {
            return ip;
        }

        public static string portadd()
        {
            return port;
        }

        public static string dbnamev()
        {
            return dbname;
        }

        public static string dbuserv()
        {
            return dbuser;
        }

        public static string dbhostv()
        {
            return dbhost;
        }

        public static string dbportv()
        {
            return dbport;
        }

        public static string dbpassv()
        {
            return dbpass;
        }

    }
}
