using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] a = { "flower","flow","float" };
            // string[] a = { "dog", "racecar", "car" };
                    
            string a = "6913259244", b = "71103343";
            var t = LongestPalindrome(a,b);
            Console.WriteLine(t);
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

        }
        public static string LongestPalindrome(string c, string d)
        {
            string q = c.Trim();
            long k = long.Parse(q);
            string p = d.Trim();
            long l = long.Parse(p);
            long result = k * l;
            string u = result.ToString();
            return u;
        }
    }
}


