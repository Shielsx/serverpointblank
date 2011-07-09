using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class LOGIN_PUZZLE10
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        public static byte[] Login_Puzzle10 = new byte[12] { 0xfa, 0x7c, 0xa6, 0x9b, 0xf2, 0x7c, 0x44, 0x08, 0x0a, 0x16, 0x44, 0x08 };
        public static byte[] packetbyte()
        {
            return Login_Puzzle10;
        }

        public static int packetlength()
        {
            return Login_Puzzle10.Length;
        }


    }
}
