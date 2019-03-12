using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ConsoleApplication21
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string s = "ABCDEF";
            var arr = s.ToCharArray();
            GetPermutation(arr);

        }

        private static void GetPermutation(char[] arr)
        {
            var x = arr.Length - 1;
            GetPer(arr, 0, x);
        }

        private static void GetPer(char[] arr, int k, int m)
        {
            if (k == m)
                Console.WriteLine(arr);
            else
            {
                for (var i = k; i <= m; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GetPer(arr, k + 1, m);
                    Swap(ref arr[k], ref arr[i]);

                }
            }
        }

        private static void Swap(ref char c, ref char c1)
        {
            if (c == c1)
            {
                return;
            }

            c ^= c1;
            c1 ^= c;
            c ^= c1;
        }
    }
}
