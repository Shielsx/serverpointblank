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
        public string packet_GameServer_text = "";
        //------------------------

        //packet to int
        //------------------------
        //public int packet_SeverList_int = 169017378;
        public int packet_SeverList_int = 169017371;
        //public int packet_SeverList_int = 169017359;
        public int packet_Unk1_int = 168755200;

        public int packet_Unk2_int = 168493056;

        public int packet_Unk3_int = 168624132;

        public int packet_Unk4_int = 184614912;

        public int packet_Unk5_int = 184745984;

        //Инвентарь???
        public int packet_Inventary_int = 201392128;
        //------------------------




        public TcpListener tcpListener;
        public Thread listenThread;

        
        public static NetworkStream clientStream;
        public static byte[] rc4_key = null;
        public static byte[] rc4_key_hashed = null;
        public static string account_name = null;
        public static Nullable<int> account_id = null;
        public static TcpClient tcpClient = null;

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
                Thread.Sleep(1000);
                clientThread.Start(client);
            }
        }

        public void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();


            try
            {
                clientStream.Write(LOGIN_REQUEST.packetbyte(), 0, LOGIN_REQUEST.packetlength());
                Console.WriteLine("Sending packet " + "LOGIN_REQUEST");
                Debug.writelog("Sending packet " + "LOGIN_REQUEST", "serverEmuPointBlank.log");
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            byte[] message = new byte[60];//60

            int bytesRead;

            bytesRead = 0;
            bool first = false;

            while (true)
            {
                bytesRead = 0;
                //string test;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 60);
                    //test = Convert.ToBase64String(message);
                    //Console.WriteLine(test);
                    get_Opcode(message);
                    Console.WriteLine("opcode: " + opcode);
                    Debug.writelog("opcode: " + opcode, "serverEmuPointBlank.log");

                    //Console.WriteLine(bytesRead.GetHashCode().ToString());


                    if (opcode == packet_SeverList_int)
                    {
                        clientStream.Write(LOGIN_PUZZLE4.packetbyte(), 0, LOGIN_PUZZLE4.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE4");
                        Console.WriteLine("Lenght " + LOGIN_PUZZLE4.packetlength().ToString());
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE4", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE5.packetbyte(), 0, LOGIN_PUZZLE5.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE5");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE5", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE6.packetbyte(), 0, LOGIN_PUZZLE6.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE6");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE6", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE7.packetbyte(), 0, LOGIN_PUZZLE7.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE7");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE7", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE8.packetbyte(), 0, LOGIN_PUZZLE8.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE8");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE8", "serverEmuPointBlank.log");
                    }
                   if (opcode == packet_Unk2_int)
                    {
                        clientStream.Write(LOGIN_PUZZLE5.packetbyte(), 0, LOGIN_PUZZLE5.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE5");
                        Console.WriteLine("Lenght " + LOGIN_PUZZLE5.packetlength().ToString());
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE5", "serverEmuPointBlank.log");
                        Thread.Sleep(500);
                    }

                   if (opcode == packet_Unk3_int)
                    {
                        clientStream.Write(LOGIN_PUZZLE6.packetbyte(), 0, LOGIN_PUZZLE6.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE6");
                        Console.WriteLine("Lenght " + LOGIN_PUZZLE6.packetlength().ToString());
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE6", "serverEmuPointBlank.log");
                        Thread.Sleep(500);
                    }
                   if (opcode == packet_Unk4_int)
                    {
                        clientStream.Write(LOGIN_PUZZLE7.packetbyte(), 0, LOGIN_PUZZLE7.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE7");
                        Console.WriteLine("Lenght " + LOGIN_PUZZLE7.packetlength().ToString());
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE7", "serverEmuPointBlank.log");
                        Thread.Sleep(500);
                    }
                   if (opcode == packet_Unk5_int)
                    {

                        if (first == false)
                        {
                            first = true;
                            clientStream.Write(LOGIN_PUZZLE8.packetbyte(), 0, LOGIN_PUZZLE8.packetlength());
                            Console.WriteLine("Sending packet " + "LOGIN_PUZZLE8");
                            Console.WriteLine("Lenght " + LOGIN_PUZZLE8.packetlength().ToString());
                            Debug.writelog("Sending packet " + "LOGIN_PUZZLE8", "serverEmuPointBlank.log");
                            Thread.Sleep(500);
                            clientStream.Write(LOGIN_PUZZLE9.packetbyte(), 0, LOGIN_PUZZLE9.packetlength());
                            Console.WriteLine("Sending packet " + "LOGIN_PUZZLE9");
                            Console.WriteLine("Lenght " + LOGIN_PUZZLE9.packetlength().ToString());
                            Debug.writelog("Sending packet " + "LOGIN_PUZZLE9", "serverEmuPointBlank.log");
                            Thread.Sleep(500);
                            if (opcode == 0)
                            {
                                clientStream.Write(LOGIN_PUZZLE11.packetbyte(), 0, LOGIN_PUZZLE11.packetlength());
                                Console.WriteLine("Sending packet " + "LOGIN_PUZZLE11");
                                Console.WriteLine("Lenght " + LOGIN_PUZZLE9.packetlength().ToString());
                                Debug.writelog("Sending packet " + "LOGIN_PUZZLE11", "serverEmuPointBlank.log");
                            }
                        }
                       //
                        //clientStream.Write(LOGIN_PUZZLE10.packetbyte(), 0, LOGIN_PUZZLE10.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE10");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE10", "serverEmuPointBlank.log");

                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE12.packetbyte(), 0, LOGIN_PUZZLE12.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE12");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE12", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE13.packetbyte(), 0, LOGIN_PUZZLE11.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE13");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE13", "serverEmuPointBlank.log");
                        //Thread.Sleep(500);
                        //clientStream.Write(LOGIN_PUZZLE14.packetbyte(), 0, LOGIN_PUZZLE14.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE14");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE14", "serverEmuPointBlank.log");
                        Thread.Sleep(500);
                        //clientStream.Write(src.network.ServerPackets.SM_Error_Static.packetbyte(), 0, src.network.ServerPackets.SM_Error_Static.packetlength());
                        //Console.WriteLine("Sending packet " + "SM_Error_Static");
                        //Debug.writelog("Sending packet " + "SM_Error_Static", "serverEmuPointBlank.log");
                        //clientStream.Write(LOGIN_PUZZLE10.packetbyte(), 0, LOGIN_PUZZLE10.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE10");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE10", "serverEmuPointBlank.log");
                        //clientStream.Write(LOGIN_PUZZLE10UNK.packetbyte(), 0, LOGIN_PUZZLE10UNK.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE10UNK");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE10UNK", "serverEmuPointBlank.log");
                    }

                    else
                    {
                        ConsoleUtil.hexdump(message, 0);

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect closed connection...");
                    Debug.writelog("Incorrect closed connection...", "serverEmuPointBlank.log");
                    Debug.writelog(e.ToString(), "serverEmuPointBlank.log");
                    bytesRead = 0;
                    break;
                }
                ASCIIEncoding encoder1 = new ASCIIEncoding();
                encoder1.GetString(message, 0, bytesRead);

                if (PropertiesLoader.connector == "true")
                {
                        //if (test == packet_GameServer_text)
                        //{
                        //    try
                        //    {
                                
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Console.WriteLine(e.ToString());
                        //    }

                        //}

                        if (bytesRead == 0)
                        {
                            break;
                        }
                }
                    

            }
            Console.WriteLine("Connection close.");
            Debug.writelog("Connection close.", "serverEmuPointBlank.log");
            bytesRead = 0;
            tcpClient.Close();
            Console.ReadKey();

        }
        public static int opcode;
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
