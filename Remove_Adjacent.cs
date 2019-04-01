using System;
namespace ConsoleApplication33
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ab = "geeksforgeek";
            var t=RemoveAdjcent(ab);
            Console.WriteLine(t);
        }

        private static string RemoveAdjcent(string ab)
        {
            if (ab.Length == 0) return ab;

            var t = ab.ToCharArray();
            var lastchar = t[0];

            var count = 1;
            for (var i = 1; i < ab.Length; i++)
            {
                if (count > 0 && t[i] == t[count - 1])
                {
                    lastchar = t[count - 1];

                    while (count > 0 && t[count - 1] == lastchar)
                    {
                        count--;
                    }
                }
                else if (t[i] == lastchar)
                {

                }
                else
                {
                    t[count++] = t[i];
                }
            }
            return new string(t,0,count);
        }
    }
}
