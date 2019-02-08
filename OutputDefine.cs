using System;

namespace ConsoleApplication5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                #if(!pi)
                    Console.WriteLine("i");
                    #else
                    Console.WriteLine("Pi is not define");
                #endif
                Console.WriteLine("Ok");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
