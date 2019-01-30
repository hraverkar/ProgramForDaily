using System;

namespace ConsoleApplication5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
               var a = new int[3];
               a[1] = 10;
               object o = a;
               var b = (int[]) o;
               b[1] = 100;
               Console.WriteLine(a[1]);
               ((int[])o)[1] = 1000;
               Console.WriteLine(a[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
