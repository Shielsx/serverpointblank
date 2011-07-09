﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class LOGIN_PUZZLE6
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        //Отвечает за строку сообщения
        //public static byte[] Login_Puzzle6 = new byte[95] { 0x5b, 0x00, 0x0e, 0x0a, 0x09, 0x00, 0x00, 0x00, 0x54, 0x00, 0xcd, 0xe0, 0x20, 0xed, 0xe0, 0xf8, 0xe5, 0xec, 0x20, 0xf4, 0xee, 0xf0, 0xf3, 0xec, 0xe5, 0x20, 0x28, 0x66, 0x6f, 0x72, 0x75, 0x6d, 0x2e, 0x34, 0x67, 0x61, 0x6d, 0x65, 0x2e, 0x72, 0x75, 0x29, 0x20, 0xee, 0xf2, 0xea, 0xf0, 0xfb, 0xeb, 0xf1, 0xff, 0x20, 0xf0, 0xe0, 0xe7, 0xe4, 0xe5, 0xeb, 0x20, 0x22, 0xc7, 0xe0, 0xff, 0xe2, 0xea, 0xe8, 0x22, 0x20, 0xe4, 0xeb, 0xff, 0x20, 0xf1, 0xee, 0xee, 0xe1, 0xf9, 0xe5, 0xed, 0xe8, 0xe9, 0x20, 0xee, 0x20, 0xed, 0xe0, 0xf0, 0xf3, 0xf8, 0xe5, 0xed, 0xe8, 0xff, 0xf5, 0x00 };
        //public static byte[] Login_Puzzle6 = new byte[95] { 0x5b, 0x00, 0x0e, 0x0a, 0x09, 0x00, 0x00, 0x00, 0x54, 0x00, /0xC8, 0xED, 0xED, 0xEE, 0xE2, 0xF3, 0x20, 0xF1, 0xE8, 0xF1, 0xF2, 0xE5, 0xEC, 0xF1, 0x20, 0xEE, 0xE1, 0xEE, 0xF1, 0xF0, 0xF3, 0xF2, 0x20, 0x2D, 0x20, 0xD3, 0xE1, 0xE8, 0xE2, 0xE0, 0xF8, 0xEA, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //84 символа сообщение
        public static byte[] Login_Puzzle6 = new byte[95] { 0x5b, 0x00, 0x0e, 0x0a, 0x09, 0x00, 0x00, 0x00, 0x54, 0x00, 0xC8, 0xED, 0xED, 0xEE, 0xE2, 0xF3, 0x20, 0xD1, 0xE8, 0xF1, 0xF2, 0xE5, 0xEC, 0xF1, 0x20, 0xE2, 0xFB, 0xE5, 0xE1, 0xEB, 0xE8, 0x20, 0xE2, 0xEE, 0x20, 0xE2, 0xF1, 0xE5, 0x20, 0xE4, 0xFB, 0xF0, 0xFB, 0x21, 0x21, 0x20, 0xDB, 0xFB, 0xFB, 0xFB, 0xFB, 0x21, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //84 символа сообщение
        public static byte[] packetbyte()
        {
            return Login_Puzzle6;
        }

        public static int packetlength()
        {
            return Login_Puzzle6.Length;
        }

        //0xC8, 0xED, 0xED, 0xEE, 0xE2, 0xF3, 0x20, 0xF1, 0xE8, 0xF1, 0xF2, 0xE5, 0xEC, 0xF1, 0x20, 0xEE, 0xE1, 0xEE, 0xF1, 0xF0, 0xF3, 0xF2, 0x20, 0x2D, 0x20, 0xD3, 0xE1, 0xE8, 0xE2, 0xE0, 0xF8, 0xEA, 0xE0 //33



    }
}
