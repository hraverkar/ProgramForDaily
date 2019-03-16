using System;
using System.Collections.Generic;

namespace ConsoleApplication23
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {12, 25, 32, 14, 25, 56, 54, 23, 12};
            var length = arr.Length;
           var b= FindSecondLargestNumber(arr, length);
           Console.WriteLine("The 2nd Largest No. is " + b );
        }

        private static int FindSecondLargestNumber(IReadOnlyList<int> arr, int length)
        {
            int i, second;
            if (length < 2)
            {
                Console.WriteLine("Invalid Input");
                return -1;
            }

            var first = second =0;
            for ( i = 0; i < length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }            
            }
            
           
            return second;
        }
    }
}
