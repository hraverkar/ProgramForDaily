using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1452369874;
            int t = Reverse(x);
            Console.WriteLine(t);
            Console.ReadKey();
        }

        private static int Reverse(int x)
        {
            if (x == 0)
                return 0;
            string st = x.ToString();
            char[] str = st.ToCharArray();
            Array.Reverse(str);
            long i = long.Parse(string.Concat(str));
            int number = (int)i;
            return number;
            

            /*   if (x == 0)
                   return 0;
               int reverse = 0;
               while (x != 0)
               {
                   reverse = reverse * 10 + x % 10;
                   x = x / 10;
               }
               
            return reverse;*/
        }
    }
}
