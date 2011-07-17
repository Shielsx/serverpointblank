using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogLG;

namespace PointBlankServer.src.Services
{
    class ConsoleUtil
    {
        public static void cwrite(string category)
        {
            Debug.writelog("\n###########################" + category + "###########################\n",  "serverEmuPointBlank.log");
            Console.WriteLine("\n########################### {0} ###########################\n", category);
        }

        public static void consoleinfo(string info)
        {
            Debug.writelog(info, "serverEmuPointBlank.log");
            Console.WriteLine("[INFO]: {0:G} - {1}", DateTime.Now, info);
        }

        public static void consolerror(string error)
        {
            Error.writeError(error, "serverEmuPointBlank.log");
            Console.WriteLine("[ERROR]: {0:G} - {1}\a", DateTime.Now, error);
        }

        public static void hexdump(byte[] array, int byteC)
        {
            Console.WriteLine("-------------------------------------------");
            Debug.writelog("-------------------------------------------", "serverEmuPointBlank.log");
            Console.WriteLine("Unknown packet:");
            Debug.writelog("Unknown packet:", "serverEmuPointBlank.log");
            Debug.writelog("-------------------------------------------", "serverEmuPointBlank.log");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                //Debug.writelog(String.Format("{0:X2}", array[i]), "serverEmuPointBlank.log");
                Console.Write(String.Format("{0:X2}", array[i]));
                Console.Write(" ");
                //Debug.writelog(" ", "serverEmuPointBlank.log");
                if (i > 0 && (i % 16) == 0)
                {
                    Console.WriteLine();
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Length: ", byteC);
            Console.WriteLine("-------------------------------------------");
        }

        public static void hexdump2(byte[] array2)
        {
            Console.WriteLine("-------------------------------------------");
            Debug.writelog("-------------------------------------------", "serverEmuPointBlank.log");
            Console.WriteLine("Unknown packet:");
            Debug.writelog("Unknown packet:", "serverEmuPointBlank.log");
            Debug.writelog("-------------------------------------------", "serverEmuPointBlank.log");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < array2.Length; i++)
            {
                //Debug.writelog(String.Format("{0:X2}", array[i]), "serverEmuPointBlank.log");
                Console.Write(String.Format("{0:X2}", array2[i]));
                Console.Write(" ");
                //Debug.writelog(" ", "serverEmuPointBlank.log");
                if (i > 0 && (i % 16) == 0)
                {
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(array2.Length);
            Console.WriteLine("-------------------------------------------");
        }



    }
}
