using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class LOGIN_Enter
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        public static byte[] Login_Enter = new byte[8] { 0x04, 0x00, 0x12, 0x0a, 0x00, 0x00, 0x00, 0x00 };
        
        public static byte[] packetbyte()
        {
            return Login_Enter;
        }
        
        public static int packetlength()
        {
            return Login_Enter.Length;
        }


    }
}
