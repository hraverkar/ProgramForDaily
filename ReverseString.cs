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
            var k = s.Length;
            string temp = "";

            for (int i = k-1; i >=0; i--)
            {
                temp = temp + s[i];
                
            } 
            return temp;
        }
    }
}
