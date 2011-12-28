//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
////using tera.commons.network;

//using tera.loginserver.packets.server;

//namespace tera.loginserver.packets
//{
//    public class LsPacketBroadcaster
//    {
//        public static byte[] lsPacketBroadcast(byte[] buf)
//        {
//            int opcode = Convert.ToInt32(Functions.BytesToHex(buf).Substring(8, 8).ToLower(), 16);
//            //Logger.debug("opcode\t" + opcode);
//            byte[] comletePacket = null;
//            try
//            {
//                switch (opcode)
//                {
//                    case 91492202:
//                        //Logger.debug("Sending SV_SERVERLIST packet...");
//                        comletePacket = new sv_serverlist().buildPacket(buf);
//                        break;
//                    default:
//                        break;
//                }
//            }
//            catch (Exception e)
//            {
//                Logger.error("Error recerving packet with opcode " + opcode + " ERROR:" + e);
//            }
//            return comletePacket;
//        }
//    }
//}
