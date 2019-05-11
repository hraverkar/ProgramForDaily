using System;

namespace ArrayPalindrome
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var arr = new int[] {1, 3, 8, 6, 1};
      var length = arr.Length;

      var t = minOperatins(arr, length);

      if (t == 0)
      {
        Console.WriteLine("Array is already palindrome, Minimum no of merge operations took is " + t);
      }
      else if (t == length - 1)
      {
        Console.WriteLine("merging all elements to get a palindrome, Minimum no of merge operations took is " + t);
      }
      else
      {
        Console.WriteLine("Minimum no of merge operations took is " + t);
      }
    }

    private static int minOperatins(int[] arr, int length)
    {
      int ans = 0, i = 0;
      var j = length - 1;

      while (i <= j)
      {
        if (arr[i] == arr[j])
        {
          i++;
          j--;
        }
        else if (arr[i] > arr[j])
        {
          arr[j - 1] = arr[j - 1] + arr[j];
          j--;
          ans++;
        }
        else
        {
          arr[i + 1] = arr[i + 1] + arr[i];
          i++;
          ans++;
        }
      }

      return ans;
    }
  }
}
