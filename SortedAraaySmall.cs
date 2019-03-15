using System;
using System.Collections.Generic;

namespace ConsoleApplication22
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] a = {45, 67, 23, 13, 56, 78, 34, 11, 67, 89};
            var l = a.Length;

            var b = FindSmallest(a, l);
            Console.WriteLine(b);
            

        }

        private static int FindSmallest(IReadOnlyList<int> arr, int i)
        {
            var max = arr[0];
            for (var j = 1; j < i; j++)
            {
                if (arr[j] < max)
                {
                    max = arr[j];
                }
            }

            return max;
        }
    }
}
