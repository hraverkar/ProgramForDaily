using System;

namespace ConsoleApplication5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var p = new Program();
                p.display(2, 3, 8);
                int[] a = {2, 56, 89, 56};
                Console.WriteLine("Example of Array");
                Console.WriteLine("Array element added are");
                p.display(a);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void display(params int[] b)
        {
            foreach (var t in b)
            {
                Console.WriteLine("Array is :{0}",t);
                
            }
        }
    }
}
