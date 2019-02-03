using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApplication10
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string s1 = "My name is Harshal Raverkar";

            var s2 = s1.Substring(0, 12);
            Console.WriteLine(s2);
            s2 = s1.Substring(6);
            Console.WriteLine(s2);
            var length = s1.Length;
            Console.Write(length);
            s2 = s1.Substring(length - 7);
            Console.WriteLine(s2);
            s2 = s1.Insert(7, " Testing");
            Console.WriteLine(s2);
            /*s2 = s1.Remove(7);
            Console.WriteLine(s2);
*/
            s2 = s1.Replace("testing", "papa");
            Console.WriteLine(s2);

            s2 = s1.ToLower();
            Console.WriteLine(s2);

            s2 = s1.ToUpper();
            Console.WriteLine(s2);

        }
    }
}
