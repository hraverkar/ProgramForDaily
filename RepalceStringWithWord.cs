using System;

namespace ConsoleApplication21
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string str = "My Name is Harshal Raverkar";
            str = str.Trim();
            str = str.Replace(" ", "%20");
            Console.Write(str);
        }

    }
}
