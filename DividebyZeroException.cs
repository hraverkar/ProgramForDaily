using System;
using System.IO;

namespace ConsoleApplication5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var a = 10;
                var b = 0;
                devide(a, b);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private static int devide(int i, int i2)
        {
            return i / i2;
        }
    }
}
