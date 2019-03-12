using System;
using System.Data.SqlTypes;

namespace ConsoleApplication21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s = "My name is Harshal Raverkar".Split(' ');
            var length = s.Length;

           var p =  reverseWord(s, length);
           Console.WriteLine(p);
        }

        private static string reverseWord(string [] s, int length)
        {
            string ans = "";

            for (int i = s.Length-1; i >=0 ; i--)
            {
                ans = ans + s[i] +" ";
            }

            return ans.Substring(0,ans.Length-1);
        }
    }
}
