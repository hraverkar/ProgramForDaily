using System;

namespace ConsoleApplication5
{
    public class Generic<T>
    {
        public T Field;
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var a = new Generic<int>();
                var b = new Generic<int>();

                a.Field = 100;
                b.Field = 50;

                if (a.Field % b.Field == 0)
                {
                    Console.WriteLine("Welcome to CsharpStar");
                }
                else
                {
                    Console.WriteLine("Print nothing");
                }

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
