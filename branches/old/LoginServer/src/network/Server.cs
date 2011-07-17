using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using PointBlankServer.src.network.ServerPackets;
using PointBlankServer.src;
using LogLG;
using PointBlankServer.services.crypt;
using PointBlankServer.src.services.consolemessages;
using PointBlankServer.src.Services;
using MySql.Data.MySqlClient;

namespace PointBlankServer.src.network
{
    class Server
    {
        //packet to byte
        //------------------------
        byte[] login = new byte[1] { 0x37 };
        //------------------------

        //packet to string
        //------------------------
        public string packet_login_text = "NwADCi1sb2dpbj1kYXJrU2tlbGV0b24AAC1wYXNzPTEyMzEyMwAAAAAAAAAAAAAAAAAAAAAAAG1phkgA";
        public string packet_login2_text = "AAAFCi1sb2dpbj1kYXJrU2tlbGV0b24AAC1wYXNzPTEyMzEyMwAAAAAAAAAAAAAAAAAAAAAAAG1phkgA";
        public string packet_test_text = "AAAHCi1sb2dpbj1kYXJrU2tlbGV0b24AAC1wYXNzPTEyMzEyMwAAAAAAAAAAAAAAAAAAAAAAAG1phkgA";
        public string packet_test0_text = "AABXCi1sb2dpbj1kYXJrU2tlbGV0b24AAC1wYXNzPTEyMzEyMwAAAAAAAAAAAAAAAAAAAAAAAG1phkgA";
        public string packet_test1_text = "AAARCi1sb2dpbj1kYXJrU2tlbGV0b24AAC1wYXNzPTEyMzEyMwAAAAAAAAAAAAAAAAAAAAAAAG1phkgA";
        //------------------------

        //packet to int
        //------------------------
        public int packet_login_int = 167968823;
        public int packet_login2_int = 168099840;
        public int packet_test_int = 168230912;
        public int packet_test0_int = 168755200;
        public int packet_test1_int = 168886272;
        
        //------------------------


        public TcpListener tcpListener;
        public Thread listenThread;

        public int nextpacket = 0;
        
        public static NetworkStream clientStream;
        public static byte[] rc4_key = null;
        public static byte[] rc4_key_hashed = null;
        public static string account_name = null;
        public static Nullable<int> account_id = null;
        public static TcpClient tcpClient = null;
        public int autorizeClientFIX = 0;

        public Server(string ip, int port)
        {
            IPAddress ipAddress = Dns.Resolve(ip).AddressList[0];
            tcpListener = new TcpListener(ipAddress, port);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }



        public void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {

                
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("Client connected.");
                Debug.writelog("Client connected.", "serverEmuPointBlank.log");
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                Thread.Sleep(3000);
                clientThread.Start(client);
            }
        }

        public void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            int firstpacket = 0;

            try
            {
                if(firstpacket == 0)
                {
                Thread.Sleep(2000);
                clientStream.Write(LOGIN_REQUEST.packetbyte(), 0, LOGIN_REQUEST.packetlength());
                Console.WriteLine("Sending packet " + "LOGIN_REQUEST");
                Debug.writelog("Sending packet " + "LOGIN_REQUEST", "serverEmuPointBlank.log");
                Thread.Sleep(6000);
                }
            }
            catch (Exception e)
            {
                firstpacket = 0;
                if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                {
                    Console.WriteLine("Error: " + e);
                }
            }
            byte[] message = new byte[60];

            

            ////byte[] message2 = new byte[100];

            //int bytesReadTest;
            ////int bytesReadTest2;
            int bytesRead;


            //byte[] Message = new byte[1];
            



            //byte[] bytes = BitConverter.GetBytes(201805978);
            //Console.WriteLine("byte array: " + BitConverter.ToString(bytes));

            //bytesReadTest = 0;
            ////bytesReadTest2 = 0;
            bytesRead = 0;
            

            while (true)
            {
                bytesRead = 0;
                string test;
                


                //ConsoleUtil.hexdump(Message);
                //ConsoleUtil.hexdump(login);
                
                //ConsoleUtil.hexdump(message2);
                
                try
                {
                    //bytesReadTest = clientStream.Read(Message, 0, 1);
                    bytesRead = clientStream.Read(message, 0, 60);
                    test = Convert.ToBase64String(message);
                    Console.WriteLine(test);
                    ConsoleUtil.hexdump(message, 0);
                    get_Opcode(message);
                    
                    Console.WriteLine("OPCODE: " + opcode.ToString());
                    //Console.WriteLine(bytesRead.GetHashCode().ToString());
                    //Console.WriteLine(bytesRead.ToString());

                    //if (Message == login)
                    //{
                    //    Console.WriteLine(
                    //    "true");
                    //}
                    //else if(Message != login)
                    //{
                    //    Console.WriteLine(Message.ToArray().ToString() );
                    //}
                    
                    //Console.WriteLine(sr.ToString());
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect closed connection...");
                    if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                    {
                        Console.WriteLine("Error: " + e);
                    }
                    bytesRead = 0;
                    break;
                }
                ASCIIEncoding encoder1 = new ASCIIEncoding();
                encoder1.GetString(message, 0, bytesRead);
                //Console.WriteLine(bytesRead.GetHashCode().ToString());
                //Debug.writelog(bytesRead.GetHashCode().ToString(), "serverEmuPointBlank.log");


                //ASCIIEncoding encoder2 = new ASCIIEncoding();
                //encoder2.GetString(Message, 0, bytesReadTest);
                //Console.WriteLine(bytesReadTest.GetHashCode().ToString());
                //Debug.writelog(bytesReadTest.GetHashCode().ToString(), "serverEmuPointBlank.log");

                if (PropertiesLoader.connector == "true")
                {
                    if (PropertiesLoader.ConnectionDeny == "false")
                    {
                        //if (bytesRead.ToString() == "59")
                        //if (bytesRead.ToString())
                        //if (Message.ToString() == login.ToString)
                        if (opcode == packet_login_int)
                        {
                            string _loginANDpasswordTEST = "SERVER=" + "localhost" + ";" + "DATABASE=" + "PointBlankEmu" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "root1" + ";";
                            MySqlConnection connection_test2 = new MySqlConnection(_loginANDpasswordTEST);
                            MySqlCommand command_test2 = connection_test2.CreateCommand();
                            MySqlDataReader Reader2;

                            AccountTestClass.AccountTest(message, message);
                            //Console.WriteLine("==");

                            string strSQL = "SELECT * FROM `accounts` WHERE `login` = '" + AccountTestClass.packet[0] + "' AND `password` = '" + AccountTestClass.packet2[0] + "';";
                            //test2(data);
                            //WriteToolText.TextServiceWrite(strSQL, 1);
                            command_test2.CommandText = strSQL;
                            connection_test2.Open();
                            Reader2 = command_test2.ExecuteReader();

                            //src.networks.AuthManager.wrireMysql(IpClient, dateTimeNow, " ", ServerHost, ServerDatabase, ServerUID, ServerPassword);
                            string login = null;
                            string password;
                            int _accesslevel = 0;

                            while (Reader2.Read())
                            {
                                login = (string)Reader2["login"];
                                password = (string)Reader2["password"];

                                if (login == AccountTestClass.packet[0])
                                {
                                    Console.WriteLine(login + " == " + AccountTestClass.packet);
                                    try
                                    {
                                        //packet = datapacket.Split(new Char[] { ' ' });
                                        autorizeClientFIX = 1;
                                        clientStream.Write(LOGIN_PUZZLE2.packetbyte(), 0, LOGIN_PUZZLE2.packetlength());
                                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE2");
                                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE2", "serverEmuPointBlank.log");


                                    }
                                    catch (Exception e)
                                    {
                                        if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                                        {
                                            Console.WriteLine("Error: " + e);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(login + " != " + AccountTestClass.packet[0]);
                                }

                            }






                            //if (autorizeClientFIX == 0)
                            //{

                            

                            }
                        //}
                        //else
                        //{
                        //    if (autorizeClientFIX == 0)
                        //    {
                        //        autorizeClientFIX = 1;
                        //        Thread.Sleep(3000);
                        //        clientStream.Write(src.network.ServerPackets.SMDeniedAutorize_Static.packetbyte(), 0, src.network.ServerPackets.SMDeniedAutorize_Static.packetlength());
                        //        Console.WriteLine("Sending packet " + "SMDeniedAutorize_Static");
                        //        Debug.writelog("Sending packet " + "SMDeniedAutorize_Static", "serverEmuPointBlank.log");
                        //    }
                        //}

                        //if (bytesRead.GetHashCode().ToString() == "4")
                        if (opcode == packet_test0_int)
                        {
                            try
                            {
                                clientStream.Write(LOGIN_REQUEST.packetbyte(), 0, LOGIN_REQUEST.packetlength());
                                Console.WriteLine("Sending packet " + "LOGIN_REQUEST");
                                Debug.writelog("Sending packet " + "LOGIN_REQUEST", "serverEmuPointBlank.log");
                            }
                            catch (Exception e)
                            {
                                if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                                {
                                    Console.WriteLine("Error: " + e);
                                }
                            }
                        }

                        if (opcode == packet_login2_int)
                        {
                            try
                            {
                                clientStream.Write(LOGIN_PUZZLE3.packetbyte(), 0, LOGIN_PUZZLE3.packetlength());
                                Console.WriteLine("Sending packet " + "LOGIN_PUZZLE3");
                                Debug.writelog("Sending packet " + "LOGIN_PUZZLE3", "serverEmuPointBlank.log");
                                nextpacket = 2;
                            }
                            catch (Exception e)
                            {
                                if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                                {
                                    Console.WriteLine("Error: " + e);
                                }
                            }
                            //clientStream.Write(LOGIN_PUZZLE3.packetbyte(), 0, LOGIN_PUZZLE3.packetlength());
                            //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE3");
                            //Debug.writelog("Sending packet " + "LOGIN_PUZZLE3", "serverEmuPointBlank.log");

                        }

                        //if (bytesRead.GetHashCode().ToString() == "4" && nextpacket == 2)
                        if (opcode == packet_test_int)
                        {
                            //Thread.Sleep(1000);

                            clientStream.Write(LOGIN_PUZZLE4.packetbyte(), 0, LOGIN_PUZZLE4.packetlength());
                            Console.WriteLine("Sending packet " + "LOGIN_PUZZLE4");
                            Debug.writelog("Sending packet " + "LOGIN_PUZZLE4", "serverEmuPointBlank.log");
                        }

                        if (opcode == packet_test1_int)
                        {
                            //Thread.Sleep(1000);
                            try
                            {
                                clientStream.Write(LOGIN_PUZZLE5.packetbyte(), 0, LOGIN_PUZZLE5.packetlength());
                                Console.WriteLine("Sending packet " + "LOGIN_PUZZLE5");
                                Debug.writelog("Sending packet " + "LOGIN_PUZZLE5", "serverEmuPointBlank.log");
                                if (bytesRead > 0)
                                {
                                    Thread.Sleep(1000);
                                    clientStream.Write(LOGIN_PUZZLE6.packetbyte(), 0, LOGIN_PUZZLE6.packetlength());
                                    Console.WriteLine("Sending packet " + "LOGIN_PUZZLE6");
                                    Debug.writelog("Sending packet " + "LOGIN_PUZZLE6", "serverEmuPointBlank.log");
                                    Thread.Sleep(1000);
                                    clientStream.Write(LOGIN_PUZZLE7.packetbyte(), 0, LOGIN_PUZZLE7.packetlength());
                                    Console.WriteLine("Sending packet " + "LOGIN_PUZZLE7");
                                    Debug.writelog("Sending packet " + "LOGIN_PUZZLE7", "serverEmuPointBlank.log");
                                }
                            }
                            catch (Exception e)
                            {
                                if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                                {
                                    Console.WriteLine("Error: " + e);
                                }
                            }
                        }

                        if (bytesRead == 0)
                        {
                            break;
                        }
                    }
                    else if(PropertiesLoader.connector == "true")
                    {
                        Debug.writelog(bytesRead.GetHashCode().ToString(), "serverEmuPointBlank.log");
                        Debug.writelog(bytesRead.ToString(), "serverEmuPointBlank.log");
                        bool den = false;
                        try
                        {
                            if (den == true)
                            {
                                clientStream.Write(SMDeniedAutorize_Static.packetbyte(), 0, SMDeniedAutorize_Static.packetlength());
                                den = true;
                                Console.WriteLine("Sending packet " + "SMDeniedAutorize_Static");
                                Debug.writelog("Sending packet " + "SMDeniedAutorize_Static", "serverEmuPointBlank.log");

                            }
                        }
                        catch (Exception e)
                        {
                            if (PointBlankServer.src.Services.PropertiesLoader.Debug == "true")
                            {
                                Console.WriteLine("Error: " + e);
                            }
                        }
                    }

                }

            }

            Console.WriteLine("Connection close.");
            autorizeClientFIX = 0;
            Debug.writelog("Connection close.", "serverEmuPointBlank.log");
            bytesRead = 0;
            tcpClient.Close();
            Console.ReadKey();

        }
        public static int opcode;
       //public static long opcodelong;
        public static int get_Opcode(byte[] packetopcoder)
        {
            byte[] opcoder = new byte[4] { packetopcoder[0], packetopcoder[1], packetopcoder[2], packetopcoder[3] };
            opcode = BitConverter.ToInt32(opcoder, 0);
            //opcodelong = BitConverter.ToInt64(opcoder, 0);
            //Console.WriteLine("OPCODE: " + opcode.ToString());
            //Console.WriteLine("OPCODE long: " + opcodelong.ToString());
            return opcode;

        }
    }
}
