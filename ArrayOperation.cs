using System;
using System.Collections.Generic;

namespace ConsoleApplication24
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {4, 6, 7, 8, 9, 1, 2};
            var p = SortedArray(arr);
            foreach (var test in p)
            {
                Console.Write("-->{0}", test);
            }

            var t = MinimumElementSortedArray(p);
            Console.WriteLine("\nMinimum Element {0} ", t);
            var q = MaximumElementSortedArray(p);
            Console.WriteLine("Maximum Element {0} ", q);
            var k = MedianArray(p);
            Console.WriteLine("Median of Array {0} ", k);

        }

        private static decimal MedianArray(IReadOnlyList<int> ints)
        {
            decimal medianValue = 0;
            if (ints.Count % 2 == 0)
            {
                var middleElement1 = ints[(ints.Count / 2) - 1];
                var middleElement2 = ints[(ints.Count / 2)];
                // ReSharper disable once PossibleLossOfFraction
                medianValue = (middleElement1 + middleElement2) / 2;
            }
            else
            {
                medianValue = ints[(ints.Count / 2)];
            }

            return medianValue;
        }

        private static int MaximumElementSortedArray(IReadOnlyList<int> ints)
        {
            var max = ints[0];
            for (var i = 1; i < ints.Count; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
            }

            return max;
        }

        private static int MinimumElementSortedArray(IReadOnlyList<int> ints)
        {
            var min = ints[0];
            for (var i = 1; i < ints.Count; i++)
            {
                if (ints[i] < min)
                {
                    min = ints[i];
                }

            }

            return min;
        }

        private static int[] SortedArray(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)

            for (var j = i + 1; j < arr.Length; j++)

                if (arr[i] > arr[j])
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            return arr;
        }
    }
}
