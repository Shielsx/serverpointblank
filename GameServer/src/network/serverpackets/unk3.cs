using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class UNK3
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        public static byte[] unk3 = new byte[3] { 0x03, 0x00, 0x08 };
        public static byte[] packetbyte()
        {
            return unk3;
        }

        public static int packetlength()
        {
            return unk3.Length;
        }


    }
}
