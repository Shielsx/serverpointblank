using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.Services
{
   public static class Friends
    {
       public static byte ClanSlots = 0x00; //отвечает за количество клановых контактов
      
       public static void friendsGet(string login, int friendsC)
       {
           ClanSlots = Convert.ToByte(friendsC);
           Console.WriteLine("Service Friends Updated...");
       }
    }
}
