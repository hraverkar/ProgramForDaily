using System;

namespace ConsoleApp3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
            const string t = "HarshalRaverkar";
            var p =t.ToCharArray();
            PrintReverse(p);
        }

        private static void PrintReverse(char[] s)
        {
            Helper(0, s);
        }

        private static void Helper(int i, char [] s)
        {
            if (s == null || i >=s.Length)
            {
                return;
            }
            Helper(i+1,s);
            Console.Write("'" +s[i]+ "'"+",");
           
        }
    }
}
