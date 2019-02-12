using System;
using System.Linq;

namespace ConsoleApplication16
{
    internal static class Program
    {

        public static void Main(string[] args)
        {
            int[] a = {1,2 };
            int[] b = { 3,4};
           var p =  FindMedian(a, b);
           Console.WriteLine(p);
        }


        private static double FindMedian(int[] n1, int[] n2)
        {
            var len1 = n1.Length;
            var len2 = n2.Length;

            var mid = (len1 + len2) / 2;

            if ((len1 + len2) % 2 != 0)
            {
                return FindMedianArrayHelper(n1, n2, mid + 1);
            }
            else
            {
                var left = FindMedianArrayHelper(n1, n2, mid);
                var right = FindMedianArrayHelper(n1, n2, mid + 1);
                return (left + right) / 2;
            }
        }

        private static double FindMedianArrayHelper(int[] n1, int[] n2, int k)
        {
            while (true)
            {
                var count1 = n1.Length;
                var count2 = n2.Length;

                if (count1 > count2)
                {
                    var n3 = n1;
                    n1 = n2;
                    n2 = n3;
                    continue;
                }

                if (count1 == 0) return n2[k - 1];

                if (k == 1) return Math.Min(n1[0], n2[0]);


                var mid1 = Math.Min(count1, k / 2);
                var mid2 = k - mid1;


                if (n1[mid1 - 1] > n2[mid2 - 1])
                {
                    n2 = n2.Skip(mid2).ToArray();
                    k = k - mid2;
                }
                else
                {
                    n1 = n1.Skip(mid1).ToArray();
                    k = k - mid1;
                }
            }
        }
    }
}
