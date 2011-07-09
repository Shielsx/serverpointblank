using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using PointBlankServer.src;
using PointBlankServer.src.Services;

namespace PointBlankServer.src.Services
{
   public static class PropertiesLoader
    {
        //NetWorkSettings
        static public string port = null;
        static public string ip = null;
        static public string connector = null;

        static public string ConnectionDeny = null;
        static public string Debug = null;

       //packetloader xml
       //packet 1
        static public string packet_1_data;
        static public string packet_1_leght = "165";
        public static int packet_1_leghtINT = 165;

        //packet 2
        static public string packet_2_data;
        static public string packet_2_leght;
        //packet 3
        static public string packet_3_data;
        static public string packet_3_leght;
        //packet 4
        static public string packet_4_data;
        static public string packet_4_leght;
        //packet 5
        static public string packet_5_data;
        static public string packet_5_leght;
        //packet 6
        static public string packet_6_data;
        static public string packet_6_leght;
        //packet 7
        static public string packet_7_data;
        static public string packet_7_leght;
        //packet 8
        static public string packet_8_data;
        static public string packet_8_leght;
        //packet 9
        static public string packet_9_data;
        static public string packet_9_leght;
        //packet 10
        static public string packet_10_data;
        static public string packet_10_leght;
        //packet 11
        static public string packet_11_data;
        static public string packet_11_leght;

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


        public static bool PacketProperties()
        {
            if (!File.Exists("settings/PacketSettings.xml"))
            {
                ConsoleUtil.consolerror("settings/PacketSettings.xml NOT EXIST!!!");
                return false;
            }

            XmlReader reader = XmlReader.Create("settings/PacketSettings.xml");
            while (reader.Read())
            {
                if (reader.Name == "data_1")
                {
                    packet_1_data = reader.ReadInnerXml();
                    
                }

                if (reader.Name == "leght_1")
                {
                    packet_1_leght = reader.ReadInnerXml();
                    packet_1_leghtINT = Convert.ToInt32(packet_1_leght);
                }


                if (reader.Name == "data_2")
                {
                    packet_2_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_2")
                {
                    packet_2_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_3")
                {
                    packet_3_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_3")
                {
                    packet_3_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_4")
                {
                    packet_4_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_4")
                {
                    packet_4_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_5")
                {
                    packet_5_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_5")
                {
                    packet_5_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_6")
                {
                    packet_6_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_6")
                {
                    packet_6_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_7")
                {
                    packet_7_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_7")
                {
                    packet_7_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_8")
                {
                    packet_8_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_8")
                {
                    packet_8_leght = reader.ReadInnerXml();
                }


                if (reader.Name == "data_9")
                {
                    packet_9_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_9")
                {
                    packet_9_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_10")
                {
                    packet_10_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_10")
                {
                    packet_10_leght = reader.ReadInnerXml();
                }

                if (reader.Name == "data_11")
                {
                    packet_11_data = reader.ReadInnerXml();
                }

                if (reader.Name == "leght_11")
                {
                    packet_11_leght = reader.ReadInnerXml();
                }



                
            }
            if (port.Length > 0 && ip.Length > 0 && connector.Length > 0)
            {
                //ConsoleUtil.consoleinfo("settings/NetworkSettings.xml successfully loaded");
                //ConsoleUtil.consoleinfo("Server use this ip: " + ip);
                //ConsoleUtil.consoleinfo("Server use this port: " + port);
                //ConsoleUtil.consoleinfo("Server enabled: " + connector);
                //ConsoleUtil.consoleinfo("Connection Deny: " + ConnectionDeny);
                //ConsoleUtil.consoleinfo("Debug: " + Debug);
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
