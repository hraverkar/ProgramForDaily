using System;
using System.Linq;

namespace ConsoleApp11
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 0, 1, 3 };
      var n = arr.Length;
      var sum = n * (n + 1) / 2;
      getMissingElement(arr,n,sum);
    }

    private static void getMissingElement(int[] arr, int n, int sum)
    {
      int s = 0;
      for(int i=0;i<n;i++)
      {
        s += arr[i];
      }
      var t =(sum - s);
      Console.WriteLine(t);
    }
  }
}
