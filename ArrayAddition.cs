using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication
{
    internal static class Program
    {
        public static void Main()
        {
            int[] A = {1,2,3,4,5};
            const int p = 982;
            var c = A.Length;
            var temp=0;
            for (int i = 0; i < c; i++)
            {
                temp = 10 * temp + A[i];
            }

            int test = temp + p;
            var o = test.ToString().Select(u => Convert.ToInt64(u.ToString())).ToArray();
            foreach (var VARIABLE in o)
            {
                Console.WriteLine(VARIABLE);
            }

        }

        
    }
}
