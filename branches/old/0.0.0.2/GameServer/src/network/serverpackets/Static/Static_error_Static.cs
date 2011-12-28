using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class SM_Error_Static
    {
        public static byte[] Static_error_Static = new byte[16] { 0xe1, 0x63, 0x36, 0x7c, 0x4e, 0xfb, 0xca, 0x7e, 0x2d, 0xad, 0xca, 0xdc, 0x20, 0x14, 0xfc, 0xdc };
        
        public static byte[] packetbyte()
        {
            return Static_error_Static;
        }

        public static int packetlength()
        {
            return Static_error_Static.Length;
        }

    }
}
