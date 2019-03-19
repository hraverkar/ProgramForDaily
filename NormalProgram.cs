using System;

namespace ConsoleApplication25
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const int m = 1000;
            Function2();
            Console.WriteLine(m);
        }

        private static void Function1()
        {
            const int m = 10;
            Console.WriteLine(m);
        }

        private static void Function2()
        {
            const int m = 100;
            Function1();
            Console.WriteLine(m);
            
        }
    }
}
