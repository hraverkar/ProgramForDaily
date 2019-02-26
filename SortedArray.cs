using System;
using System.Linq;

namespace ConsoleApp40
{
    public class Program
    {
        public static void Main()
        {
            int[] c = { 1, 2, 3, 4, 0, 0, 0, 0 };
            c = c.Except(new int[] { 0 }).ToArray();
            int[] d = { 4, 0, 0, 0, 0, 5, 6 };
            d = d.Except(new int[] { 0 }).ToArray();
            var e = c.Length;
            var f = d.Length;
            var p = Merge(c, e, d, f);
            p = p.Distinct().ToArray();
            foreach (var t in p)
            {
                Console.WriteLine(t);
                Console.ReadKey();
            }
        }
        public static int[] Merge(int[] a, int x, int[] b, int y)
        {
            int[] answer = new int[x + y];

            int i = x - 1, j = y - 1, k = answer.Length;

            while (k > 0)
            {
                answer[--k] = (j < 0 || (i >= 0 && a[i] >= b[j])) ? a[i--] : b[j--];
            }
            return answer;
        }
    }
}

