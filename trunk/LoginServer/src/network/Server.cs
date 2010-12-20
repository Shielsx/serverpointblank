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
        public TcpListener tcpListener;
        public Thread listenThread;

        public int nextpacket = 0;
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
                clientThread.Start(client);
            }
        }

        public void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            clientStream.Write(LOGIN_PUZZLE.packetbyte(), 0, LOGIN_PUZZLE.packetlength());
            Console.WriteLine("Sending packet " + "LOGIN_PUZZLE");
            Debug.writelog("Sending packet " + "LOGIN_PUZZLE", "serverEmuPointBlank.log");

            byte[] message = new byte[200];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                ConsoleUtil.hexdump(message);
                bytesRead = clientStream.Read(message, 0, 200);
                ASCIIEncoding encoder1 = new ASCIIEncoding();
                encoder1.GetString(message, 0, bytesRead);
                Console.WriteLine(bytesRead.GetHashCode().ToString());
                Debug.writelog(bytesRead.GetHashCode().ToString(), "serverEmuPointBlank.log");
                
                if (PropertiesLoader.connector == "true")
                {

                    if (bytesRead.GetHashCode().ToString() == "59")
                    {
                        clientStream.Write(LOGIN_PUZZLE2.packetbyte(), 0, LOGIN_PUZZLE2.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE2");
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE2", "serverEmuPointBlank.log");

                        //clientStream.Write(LOGIN_PUZZLE3.packetbyte(), 0, LOGIN_PUZZLE3.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE3");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE3", "serverEmuPointBlank.log");

                        //clientStream.Write(LOGIN_PUZZLE4.packetbyte(), 0, LOGIN_PUZZLE4.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE4");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE4", "serverEmuPointBlank.log");

                        //clientStream.Write(LOGIN_PUZZLE5.packetbyte(), 0, LOGIN_PUZZLE5.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE5");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE5", "serverEmuPointBlank.log");
                    }

                    if (bytesRead.GetHashCode().ToString() == "4")
                    {
                        clientStream.Write(LOGIN_PUZZLE3.packetbyte(), 0, LOGIN_PUZZLE3.packetlength());
                        Console.WriteLine("Sending packet " + "LOGIN_PUZZLE3");
                        Debug.writelog("Sending packet " + "LOGIN_PUZZLE3", "serverEmuPointBlank.log");

                        //clientStream.Write(LOGIN_PUZZLE3.packetbyte(), 0, LOGIN_PUZZLE3.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE3");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE3", "serverEmuPointBlank.log");
                        nextpacket = 2;
                    }

                    if (bytesRead.GetHashCode().ToString() == "4" && nextpacket == 2)
                    {
                        //Thread.Sleep(1000);

                        //clientStream.Write(LOGIN_PUZZLE4.packetbyte(), 0, LOGIN_PUZZLE4.packetlength());
                        //Console.WriteLine("Sending packet " + "LOGIN_PUZZLE4");
                        //Debug.writelog("Sending packet " + "LOGIN_PUZZLE4", "serverEmuPointBlank.log");
                    }

                    if (bytesRead == 0)
                    {
                        Debug.writelog(bytesRead.GetHashCode().ToString(), "serverEmuPointBlank.log");
                        Debug.writelog(bytesRead.ToString(), "serverEmuPointBlank.log");
                        break;
                    }

                }

            }

            Console.WriteLine("Connection close.");
            Debug.writelog("Connection close.", "serverEmuPointBlank.log");
            tcpClient.Close();

        }
    }
}
