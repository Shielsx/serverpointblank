using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointBlankServer.src.Services
{
    public class Functions
    {
        private static readonly char[] HexChars = "0123456789ABCDEF".ToCharArray();

        public static string BytesToHex(byte[] data)
        {
            StringBuilder builder = new StringBuilder(data.Length * 2);
            foreach (byte b in data)
            {
                builder.Append(HexChars[b >> 4]);
                builder.Append(HexChars[b & 0xf]);
            }
            return builder.ToString();
        }

        public static byte[] HexToBytes(String hexString)
        {
            byte[] result = new byte[hexString.Length / 2];
            for (int j = 1; j < hexString.Length; )
            {
                result[j / 2] = Convert.ToByte(Convert.ToInt32("0x0" + hexString.Substring(j - 1, 2), 16));
                j += 2;
            }
            return result;
        }

        public static string HexToString(String hexString)
        {
            String result = "";
            for (int j = 1; j < hexString.Length; )
            {
                result += Convert.ToByte(Convert.ToInt32("0x0" + hexString.Substring(j - 1, 2), 16));
                j += 2;
            }
            return result;
        }

        public static double IPAddressToNumber(string IPaddress)
        {
            if (IPaddress == "")
                return 0;

            int i;
            string[] arrDec;
            double num = 0;

            arrDec = IPaddress.Split('.');
            for (i = arrDec.Length - 1; i >= 0; i = i - 1)
            {
                num += ((int.Parse(arrDec[i]) % 256) * Math.Pow(256, (3 - i)));
            }
            return num;
        }
    }
}
