using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Utils
{
    class Hash
    {
        private static readonly char[] HashTable = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_'};

        public static string Encrypt(string password, string key)
        {
            StringBuilder str = new StringBuilder().Append("#1");
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];
                char ch2 = key[i];
                int num2 = ch / 16;
                int num3 = ch % 16;
                int index = (num2 + ch2) % HashTable.Length;
                int num5 = (num3 + ch2) % HashTable.Length;
                str.Append(HashTable[index]).Append(HashTable[num5]);
            }
            return str.ToString();
        }

        public static string DecryptIP(string packet)
        {
            string loc8 = packet.Substring(0, 8), loc9 = packet.Substring(8, 3), loc7 = packet.Substring(11);
            StringBuilder loc5 = new StringBuilder();
            int loc12, loc13, loc10;

            for (int loc11 = 0; loc11 < 8; loc11 += 2)
            {
                byte codigo_ascii = (byte)loc8[loc11];
                loc12 = codigo_ascii - 48;
                byte codigo_ascii2 = (byte)loc8[loc11 + 1];
                loc13 = codigo_ascii2 - 48;
                loc10 = (((loc12 & 15) << 4) | (loc13 & 15));
                if (loc11 != 0)
                    loc5.Append(".");
                loc5.Append(loc10);
            }
            return loc5.ToString();
        }

        public static string GenerateString(int length)
        {
            var str = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                str.Append(HashTable[random.Next(HashTable.Length)]);
            }
            return str.ToString();
        }

        public static int IndexHash(char ch)
        {
            for (int i = 0; i < HashTable.Length; i++)
                if (HashTable[i] == ch)
                    return i;
            return -1;
        }
    }
}
