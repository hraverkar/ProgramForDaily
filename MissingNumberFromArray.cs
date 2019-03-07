using System;
using System.Collections.Generic;

namespace StringProgram
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Harshal Raverkar");
            int[] a = {1, 2,4, 5, 6, 7};
            int[] b = {1, 2, 3, 4, 5, 7};
            var c = a.Length;

            var p = FindMissingNumber(a,c);
            Console.WriteLine(p);
            
        }

        private static int FindMissingNumber(int[] ints, int i)
        {
            var total = (i + 1) * (i + 2) / 2;

            for (int j = 0; j < i; j++)
            {
                total = total - ints[j];
            }
            return total;
        }
    }
}
