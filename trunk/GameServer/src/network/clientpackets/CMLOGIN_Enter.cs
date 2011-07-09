using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.clientpackets
{
    class CMLOGIN_Enter
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        public static byte[] CMLogin_Enter = new byte[4] { 0x00, 0x00, 0x11, 0x0a };

        

        public static byte[] packetbyte()
        {
            return CMLogin_Enter;
        }

        public static int packetlength()
        {
            return CMLogin_Enter.Length;
        }

    }
}
