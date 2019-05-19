using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var arr = new int[] {9, 4, 20, 3, 10, 5};
      const int k = 33;
      var length = arr.Length;
      var t = FindSubarraySum(arr, length, k);
      Console.WriteLine(t);
    }

    private static int FindSubarraySum(IReadOnlyList<int> arr, int length, int i)
    {
      var count = 0;
      for (var j = 0; j < length; j++)
      {
        var sum = 0;
        for (var k = j; k < length; k++)
        {
          sum += arr[k];
          if (sum == i)
          {
            count++;
          }
        }
      }

      return count;
    }
  }
}
