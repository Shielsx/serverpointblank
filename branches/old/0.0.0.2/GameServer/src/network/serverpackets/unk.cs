using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class UNK
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        public static byte[] unk = new byte[15] { 0x0f, 0x00, 0x03, 0x5b, 0x73, 0x00, 0x00, 0x2e, 0xb0, 0xd7, 0xf9, 0xe9, 0xec, 0xf5, 0x79 };
        public static byte[] packetbyte()
        {
            return unk;
        }

        public static int packetlength()
        {
            return unk.Length;
        }


    }
}
