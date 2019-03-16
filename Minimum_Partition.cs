using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication23
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1,5,8,6,3,1};
            var length = arr.Length;
            const int k = 3;
           var b= FindSecondLargestNumber(arr, length,k);
           Console.WriteLine("The 2nd Largest No. is " + b );
        }

        private static int FindSecondLargestNumber(int[] arr, int length, int i)
        {
            if (i == 1)
                return arr.Min();
            if (i == 2)
                return Math.Max(arr[0], arr[length - 1]);
            return arr.Max();
        }
    }
}
