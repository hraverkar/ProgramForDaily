using System;
using System.Collections.Generic;

namespace ConsoleApplication34
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] {2, 3, 4, 10, 40};
            const int x = 10;
            var result = Search(arr, x,5);
            Console.WriteLine(result);
        }

        private static int Search(IReadOnlyList<int> arr, int i,int start)
        {
            var n = arr.Count;

            if (start < 0)
                return -1;
            for (var j = 0; j <n; j++)
            {
                if (arr[j] == i)
                {
                    return j ;
                }
            }           
            return -1;
        }
    }
}
