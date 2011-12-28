using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace PointBlankServer.src.Services
{
    public static class AccountTestClass
    {
        public static byte password;
        public static byte login;
        public static string loginGet;
        public static string PasswordGet;
        //static byte[] accountTemp = new byte[59]
        // {



        //     0x37, 0x00, 0x03, 0x0a,         0x62, 0x77, 0x7a, 0x75, 0x31, 0x30, 0x35, 0x38, 0x34, 0x34, 0x31,          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,     0x4d, 0x54, 0x4b, 0x31, 0x6c, 0x43, 0x73, 0x49, 0x6a, 0x74, 0x45,      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xb2, 0x40, 0xb4, 0x58
        // };


        //public static void AccountTest()
        //{
        //    string logintText = "admin";
        //    string passwordText = "admin";

        //    byte[] ltemp;
        //    byte[] ptemp;

        //    ltemp = ASCIIEncoding.ASCII.GetBytes(logintText);
        //    ptemp = ASCIIEncoding.ASCII.GetBytes(passwordText);

        //    //int login;
        //    //int password;

        //    string ltemp2;
        //    string ptemp2;

        //    string oneFast;
        //    string twoFast;
        //    string treeFast;

        //    ltemp2 = BitConverter.ToString(ltemp,0);
        //    ptemp2 = BitConverter.ToString(ptemp, 0);

        //    //login = Convert.ToInt32(logintText);
        //    //password = Convert.ToInt32(passwordText);

        //    byte[] oneFastB = new byte[4] { 0x37, 0x00, 0x03, 0x0a };
        //    byte[] twoFastB = new byte[10] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        //    byte[] treeFastB = new byte[23] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xb2, 0x40, 0xb4, 0x58 };

        //    oneFast = BitConverter.ToString(oneFastB, 0);
        //    twoFast = BitConverter.ToString(twoFastB, 0);
        //    treeFast = BitConverter.ToString(treeFastB, 0);

        //    string complete;
        //    complete = oneFast + " " + ltemp2 + " " + twoFast + " " + ptemp2 + " " + treeFast;
        //    int completeL;
        //    completeL = complete.Length;
        //    Console.WriteLine(complete + " " + completeL);

        //}

        public static string[] packet;
        public static string[] packet2;

        public static void AccountTest(byte[] login, byte[] password)
        {
            byte[] loginReturn = new byte[12] { login[4], login[5], login[6], login[7], login[8], login[9], login[10], login[11], login[12], login[13], login[14], login[15] };
            byte[] PasswordReturn = new byte[11] { password[25], password[26], password[27], password[28], password[29], password[30], password[31], password[32], password[33], password[34], password[35] };
            loginGet = System.Text.Encoding.GetEncoding(1251).GetString(loginReturn);
            PasswordGet = System.Text.Encoding.GetEncoding(1251).GetString(PasswordReturn);
            packet = loginGet.Split(new Char[] { '+' });
            packet2 = PasswordGet.Split(new Char[] { '+' });

            int packetlenghtL = 0;
            int packetlenghtP = 0;

            packetlenghtL = packet.Length;
            packetlenghtP = packet2.Length;

            if (Services.PropertiesLoader.Debug == "true" || Services.PropertiesLoader.Debug == "True")
            {
                Console.WriteLine("Login: " + "|" + packet[0] + "|");
                LogLG.Debug.writelog("Login: " + "|" + packet[0] + "|" + " Lenght= " + packet[0], "test.log");
                Console.WriteLine("Password: " + "|" + packet2[0] + "|");
                LogLG.Debug.writelog("Password: " + "|" + packet2[0] + "|" + " Lenght= " + packet2[0], "test.log");
                
            }
        }
    }
}
