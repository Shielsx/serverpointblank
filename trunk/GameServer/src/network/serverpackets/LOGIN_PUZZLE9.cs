﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class LOGIN_PUZZLE9
    {
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x07, 0x01, 0x00, 0x80 };
        //public static byte[] Login_Puzzle2 = new byte[8] { 0x04, 0x00, 0x04, 0x0a, 0x65, 0x09, 0x0f, 0x00 };
        public static byte[] Login_Puzzle9 = new byte[717] { 0xb8, 0x55, 0x5d, 0x0f, 0xc6, 0x28, 0x11, 0xaf, 0x6a, 0xb5, 0xa0, 0xa9, 0x17, 0xfa, 0x06, 0xd4, 0x1e, 0xaf, 0x55, 0x04, 0x51, 0x10, 0x28, 0x7a, 0x0b, 0x0f, 0xaf, 0xd2, 0xf0, 0x72, 0xd1, 0x57, 0xe6, 0x59, 0xbd, 0x00, 0x5f, 0xdf, 0x33, 0x9b, 0x52, 0x75, 0x9d, 0xa8, 0x2d, 0xf7, 0x05, 0xd4, 0xb5, 0x9b, 0x46, 0xcf, 0x1e, 0x03, 0x3a, 0x80, 0x4c, 0xe4, 0x6b, 0x52, 0xd7, 0x98, 0x24, 0x71, 0x13, 0x45, 0xa3, 0x55, 0x94, 0x00, 0x11, 0x96, 0xe2, 0x10, 0x99, 0x46, 0xae, 0xa0, 0x3b, 0x38, 0x03, 0xa0, 0xa0, 0xec, 0xb5, 0x02, 0xde, 0x6f, 0xaa, 0x12, 0xcb, 0xc5, 0x08, 0x6c, 0x8c, 0x60, 0x9a, 0x85, 0xa8, 0x6a, 0xe4, 0x88, 0x02, 0xed, 0xf0, 0x28, 0x52, 0x8e, 0xf6, 0xa6, 0x2f, 0xc2, 0x01, 0x74, 0x77, 0x75, 0x8c, 0x09, 0x38, 0x33, 0xd4, 0xd5, 0x42, 0xd5, 0xa9, 0x9a, 0x1d, 0x58, 0xa8, 0xab, 0x4a, 0x80, 0xe7, 0x30, 0xc7, 0xfe, 0x8b, 0xfe, 0x65, 0x2e, 0x7a, 0x9d, 0xeb, 0x9b, 0x7a, 0x78, 0xd4, 0x84, 0xcd, 0xff, 0x6a, 0x11, 0xfd, 0x15, 0xb4, 0x2c, 0x83, 0xa7, 0x22, 0x51, 0x23, 0xba, 0x5d, 0x53, 0x78, 0x23, 0x20, 0x1c, 0xde, 0x04, 0x04, 0xa6, 0x47, 0x79, 0x4b, 0xf5, 0x89, 0x65, 0xf0, 0xf7, 0x7d, 0x62, 0x2a, 0x1a, 0x7f, 0xac, 0x60, 0xc2, 0x30, 0xc3, 0xd2, 0xbc, 0xf9, 0xc0, 0x00, 0x20, 0x20, 0x2d, 0xf7, 0x37, 0x1f, 0x43, 0x81, 0x4a, 0x92, 0x8c, 0x5a, 0xa4, 0xb1, 0xec, 0x47, 0xee, 0x46, 0x57, 0xbf, 0x90, 0x74, 0x4a, 0x69, 0x11, 0xc3, 0xb2, 0x14, 0x5e, 0x97, 0x94, 0x11, 0x77, 0x29, 0x58, 0x52, 0xb4, 0x46, 0xf2, 0xad, 0x9a, 0xcb, 0xbd, 0x34, 0xdc, 0x32, 0x5a, 0x80, 0xcc, 0x7d, 0x53, 0xde, 0x42, 0x5d, 0x29, 0x0a, 0xaa, 0xe4, 0xbd, 0x84, 0x47, 0xc3, 0x93, 0xe5, 0x0b, 0x5b, 0x1d, 0xb8, 0xbb, 0x87, 0x34, 0x53, 0xaf, 0x09, 0x81, 0xe6, 0x22, 0xb1, 0xda, 0x74, 0xd7, 0x3e, 0x64, 0xb8, 0x94, 0x53, 0x25, 0x1d, 0xb3, 0xee, 0xe9, 0x5e, 0x7a, 0xff, 0x83, 0x5c, 0x29, 0x1f, 0x90, 0xc4, 0x9e, 0x0d, 0x78, 0x5e, 0xe3, 0x1e, 0xe1, 0xe9, 0x00, 0xc4, 0xfb, 0x73, 0xb8, 0x5a, 0x4c, 0x90, 0x99, 0xec, 0x29, 0xf2, 0xce, 0xec, 0xaf, 0x55, 0xfb, 0xb5, 0x4f, 0x5d, 0x71, 0x33, 0x39, 0xbd, 0x0c, 0x0e, 0x6b, 0x00, 0x95, 0x74, 0x88, 0x7d, 0xda, 0x95, 0xb6, 0x2a, 0x74, 0x76, 0xcb, 0x65, 0x3b, 0x28, 0x13, 0xe2, 0x5e, 0xa5, 0x5c, 0xd3, 0xa0, 0x44, 0xf9, 0x16, 0xb8, 0x0b, 0x72, 0xf5, 0xc6, 0x76, 0xc4, 0xe2, 0x26, 0x96, 0xdd, 0x9d, 0x8c, 0x38, 0x43, 0x0c, 0x8e, 0x21, 0x3c, 0xbf, 0x97, 0x08, 0xd5, 0x69, 0x33, 0x77, 0xa2, 0x71, 0x4f, 0xc7, 0xe4, 0x13, 0x5b, 0x1e, 0x53, 0xf3, 0x48, 0xd9, 0x46, 0x36, 0x4b, 0x0a, 0xac, 0x3f, 0xfe, 0x6d, 0xa3, 0x6a, 0xb2, 0x87, 0xaa, 0xdd, 0x62, 0xa3, 0x0b, 0x3a, 0x54, 0x82, 0x03, 0x83, 0x84, 0x5d, 0xda, 0x4a, 0x3c, 0xcc, 0x6d, 0xa9, 0x38, 0xef, 0x1c, 0x71, 0x53, 0x7e, 0xcc, 0x4a, 0x54, 0x2f, 0x6c, 0x76, 0xf5, 0xa9, 0x32, 0x92, 0x88, 0x90, 0x74, 0x1f, 0x19, 0xc2, 0x93, 0x62, 0x56, 0x03, 0xd6, 0xc3, 0x88, 0xe4, 0xab, 0x8c, 0xbf, 0xb2, 0x32, 0x99, 0xc3, 0xcf, 0x7d, 0xea, 0x24, 0xe6, 0x92, 0x9b, 0xcf, 0xa3, 0x90, 0x93, 0x49, 0x18, 0x16, 0xc8, 0xa2, 0x18, 0xfd, 0xb6, 0xe8, 0x5c, 0x25, 0x13, 0x12, 0xb7, 0x5b, 0x40, 0xf9, 0x9b, 0xf6, 0x00, 0xb7, 0xe5, 0xe1, 0xeb, 0xca, 0x5d, 0x04, 0x2a, 0xdf, 0x50, 0x2d, 0xac, 0x9a, 0x47, 0x66, 0xcc, 0x01, 0x4c, 0x1a, 0x80, 0x41, 0xfb, 0xc2, 0xb3, 0xee, 0x87, 0x8d, 0xf5, 0xe6, 0x29, 0x7c, 0x97, 0x77, 0x66, 0x23, 0x9f, 0x08, 0xc6, 0x85, 0x3c, 0xe3, 0x5d, 0x8d, 0x43, 0xc1, 0x1e, 0x3e, 0x42, 0xd7, 0xb0, 0xeb, 0x18, 0x4e, 0xc9, 0x5c, 0x0c, 0x7a, 0x1c, 0xc6, 0xbb, 0x99, 0x7e, 0x94, 0x36, 0x9d, 0x77, 0x90, 0xb3, 0xd8, 0xba, 0xf7, 0xdf, 0x1b, 0x5e, 0x8a, 0x93, 0x03, 0x0c, 0x52, 0x9f, 0x4f, 0x71, 0x1d, 0x81, 0xa8, 0x50, 0x84, 0x4d, 0xb0, 0x1f, 0xb3, 0xaa, 0xce, 0xd1, 0xf9, 0x31, 0x3d, 0xa2, 0x1e, 0x4f, 0x70, 0xfd, 0xfe, 0x30, 0x95, 0xf5, 0x78, 0x76, 0x7d, 0x35, 0x96, 0x1f, 0x3b, 0x4b, 0xdc, 0xf4, 0x46, 0xeb, 0x25, 0xc1, 0xa3, 0xb8, 0xce, 0xbc, 0xec, 0xf6, 0x87, 0xe9, 0x9e, 0x1d, 0xfa, 0xa6, 0xc5, 0x41, 0xe2, 0xcd, 0x43, 0xc7, 0xa7, 0x8f, 0x6a, 0x94, 0x0c, 0xbe, 0xf3, 0xd8, 0x4c, 0xb6, 0x8c, 0xad, 0xa6, 0x23, 0x7f, 0xeb, 0xae, 0x5c, 0x6c, 0x32, 0x74, 0x4d, 0x58, 0x3a, 0x0b, 0x9a, 0x50, 0xf1, 0x27, 0x2b, 0xfd, 0x8e, 0xe4, 0x9c, 0x1d, 0xd0, 0xb5, 0xcf, 0x61, 0x4e, 0x02, 0x2c, 0x72, 0x2f, 0x14, 0xf5, 0x32, 0xff, 0xfd, 0xfc, 0x84, 0x9e, 0x71, 0x34, 0xfc, 0x74, 0x78, 0x98, 0x2f, 0xca, 0x7a, 0x91, 0xba, 0xc3, 0xdc, 0x42, 0x53, 0x94, 0xee, 0x81, 0xff, 0x3c, 0x3d, 0x68, 0x15, 0x8e, 0x6c, 0x08, 0x19, 0x63, 0x9b, 0xcd, 0xa4, 0x1e, 0xbb, 0x35, 0xbf, 0xd1 };
        public static byte[] packetbyte()
        {
            return Login_Puzzle9;
        }

        public static int packetlength()
        {
            return Login_Puzzle9.Length;
        }


    }
}
