using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.Services
{
   public static class GameServerClass
    {
       public static int ip1_part_1 = 192;
       public static int ip1_part_2 = 168;
       public static int ip1_part_3 = 0;
       public static int ip1_part_4 = 135;

       public static int ip2_part_1 = 192;
       public static int ip2_part_2 = 168;
       public static int ip2_part_3 = 1;
       public static int ip2_part_4 = 3;

       public static int ip3_part_1 = 192;
       public static int ip3_part_2 = 168;
       public static int ip3_part_3 = 1;
       public static int ip3_part_4 = 4;

       public static int status_game_server1 = 0;
       public static byte status_game_serverB1 = 0x00;

       public static int status_game_server2 = 1;
       public static byte status_game_serverB2 = 0x00;

       public static int status_game_server3 = 1;
       public static byte status_game_serverB3 = 0x00;

       public static byte ip1_part_1B = 0x00;
       public static byte ip1_part_2B = 0x00;
       public static byte ip1_part_3B = 0x00;
       public static byte ip1_part_4B = 0x00;

       public static byte ip2_part_1B = 0x00;
       public static byte ip2_part_2B = 0x00;
       public static byte ip2_part_3B = 0x00;
       public static byte ip2_part_4B = 0x00;

       public static byte ip3_part_1B = 0x00;
       public static byte ip3_part_2B = 0x00;
       public static byte ip3_part_3B = 0x00;
       public static byte ip3_part_4B = 0x00;
       
       public static void GameServer()
       {
           ip1_part_1B = Convert.ToByte(ip1_part_1);
           ip1_part_2B = Convert.ToByte(ip1_part_2);
           ip1_part_3B = Convert.ToByte(ip1_part_3);
           ip1_part_4B = Convert.ToByte(ip1_part_4);

           ip2_part_1B = Convert.ToByte(ip2_part_1);
           ip2_part_2B = Convert.ToByte(ip2_part_2);
           ip2_part_3B = Convert.ToByte(ip2_part_3);
           ip2_part_4B = Convert.ToByte(ip2_part_4);

           ip3_part_1B = Convert.ToByte(ip3_part_1);
           ip3_part_2B = Convert.ToByte(ip3_part_2);
           ip3_part_3B = Convert.ToByte(ip3_part_3);
           ip3_part_4B = Convert.ToByte(ip3_part_4);
           switch (status_game_server1)
           {
               case 1:
                   status_game_serverB1 = 0x00;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 1 " + "status server - " + status_game_server1.ToString());
                   break;

               default :
                   status_game_serverB1 = 0x0F;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 1 " + "status server - " + status_game_server1.ToString());
                   break;
           }

           switch (status_game_server2)
           {
               case 1:
                   status_game_serverB2 = 0x00;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 2 " + "status server - " + status_game_server2.ToString());
                   break;

               default:
                   status_game_serverB2 = 0x0F;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 2 " + "status server - " + status_game_server2.ToString());
                   break;
           }

           switch (status_game_server3)
           {
               case 1:
                   status_game_serverB3 = 0x00;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 3 " + "status server - " + status_game_server3.ToString());
                   break;

               default:
                   status_game_serverB3 = 0x0F;
                   ConsoleUtil.consoleinfo("Updating status " + "GameServer 3 " + "status server - " + status_game_server3.ToString());
                   break;
           }

           ConsoleUtil.consoleinfo("Get IP GameServer....OK");
       }
    }
}
