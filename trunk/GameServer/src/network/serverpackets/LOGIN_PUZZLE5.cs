﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class LOGIN_PUZZLE5
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        public static byte[] Login_Puzzle5 = new byte[52] { 0x30, 0x00, 0x0c, 0x0a, 0x0a, 0x00, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x8c, 0x01, 0x00, 0x00, 0x7a, 0x01, 0x00, 0x00, 0x8c, 0x01, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x8c, 0x01, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0x7c, 0x01, 0x00, 0x00 };
        public static byte[] packetbyte()
        {
            return Login_Puzzle5;
        }

        public static int packetlength()
        {
            return Login_Puzzle5.Length;
        }


    }
}
