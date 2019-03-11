using System;
using System.Collections.Generic;
using System.Linq;

namespace StringProgram
{
    /*
     * Algorithm for reverse string 
     */
    internal class Test
    {
        public static void Main(string[] args)
        {
            string a = "HarshalRaverkar";
            var p = reverse(a);
            Console.WriteLine(p);
        }

        private static string reverse(string s)
        {
            char[] ch = s.ToCharArray();
            var p = ch.Length - 1;

            for (int i = 0; i < p; i++,p--)
            {
                ch[i] ^= ch[p];
                ch[p] ^= ch[i];
                ch[i] ^= ch[p];
            }
            return new string(ch);
        }
    }
}
