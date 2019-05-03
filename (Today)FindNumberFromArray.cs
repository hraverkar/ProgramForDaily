using System;
using System.Collections.Generic;

namespace ConsoleApp18
{
  internal static class Program
  {
    public static void Main()
    {
      int[] a = {1, 2, 3, 4, 5, 6, 7};
      int[] b = {1, 2, 3, 4, 5, 7};

      var p = FindMissingNumber(a, b);
      Console.WriteLine(p);
    }

    private static int FindMissingNumber(IReadOnlyList<int> a, IReadOnlyList<int> b)
    {
      var p = a.Count;
      var q = b.Count;
      var temp = 0;

      for (var i = 0; i < p; i++)
      {
        temp += a[i];
      }

      var temp1 = 0;
      for (var i = 0; i < q; i++)
      {
        temp1 += b[i];
      }

      var missing = temp - temp1;

      return missing;
    }
  }
}
