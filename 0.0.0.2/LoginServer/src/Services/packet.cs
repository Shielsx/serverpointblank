using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointBlankServer.services.crypt;
using PointBlankServer.src.network;


namespace PointBlankServer.services.crypt
{
    class packet
    {
        public static byte[] decrypt(byte[] message)
        {
            message = cut_packet(message);
            message = RC4.Decrypt(Server.rc4_key_hashed, message);
            return message;
        }

        public static byte[] decrypt(byte[] key, byte[] message)
        {
            message = cut_packet(message);
            message = RC4.Decrypt(key, message);
            return message;
        }

        public static byte[] cut_packet(byte[] packet)
        {
            byte[] packetlength = new byte[4] { packet[0], packet[1], packet[2], packet[3] };
            int packet_length = BitConverter.ToInt32(packetlength, 0);
            byte[] cutted_packet = new byte[packet_length - 4];
            int b = 0;
            for (int i = 4; i <= packet_length - 1; i++)
            {
                cutted_packet[b] = packet[i];
                b++;

            }
            return cutted_packet;
        }

        public static int get_opcode(byte[] message)
        {
            byte[] opcodef = new byte[4] { message[0], message[1], message[2], message[3] };
            int opcode = BitConverter.ToInt32(opcodef, 0);
            return opcode;
        }
    }
}
