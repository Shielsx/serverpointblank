using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.network.ServerPackets
{
    class SMDeniedAutorize_Static
    {
        public static byte[] DeniedAutorize_Static = new byte[16] { 0x0c, 0x00, 0x04, 0x0a, 0x02, 0x01, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public static byte[] packetbyte()
        {
            return DeniedAutorize_Static;
        }

        public static int packetlength()
        {
            return DeniedAutorize_Static.Length;
        }

    }
}
