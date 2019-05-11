using System;
using System.Collections.Generic;

namespace ArrayPalindrome
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      int[] a = {3, 6, 0, 6, 3,8};
      var n = a.Length;
      var t =  Palindrome(a, 0, n - 1);

     Console.WriteLine(t == 1 ? "Array is palindrome" : "Array is not palindrome");
    }

    private static int Palindrome(IReadOnlyList<int> arr, int begin, int end)
    {
      while (true)
      {
        if (begin >= end)
        {
          return 1;
        }

        if (arr[begin] != arr[end]) return 0;
        begin += 1;
        end -= 1;
        continue;

        return 0;
        break;
      }
    }
  }
}
