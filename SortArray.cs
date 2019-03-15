using System;

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

        private static int FindSmallest(int[] arr, int i)
        {
           Array.Sort(arr);
           return arr[0];
        }
    }
}
