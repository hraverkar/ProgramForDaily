using System;
using System.Collections.Generic;

namespace StringProgram
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Harshal Raverkar");
            int[] a = {1, 2, 3, 4, 5, 6, 7};
            int[] b = {1, 2, 3, 4, 5, 7};

            var p = FindMissingNumber(a, b);
            Console.WriteLine(p);
        }

        private static int FindMissingNumber(IReadOnlyList<int> arr, IReadOnlyList<int> arr1)
        {
            var a = arr.Count;
            var b = arr1.Count;

            var temp = 0;
            for (var i = 0; i < a; i++)
            {
                temp += arr[i];
            }

            var temp1 = 0;
            for (var j = 0; j < b; j++)
            {
                temp1 += arr1[j];
            }

            var missingElement = temp - temp1;
            return missingElement;
        }
    }
}
