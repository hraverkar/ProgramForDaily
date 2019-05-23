using System;

namespace ConsoleApp43
{
  class Program
  {
    static void Main()
    {
      int[] arr = { 2, 2, 1 };
      var l = arr.Length;
      var p = FindSingleElement(arr, l);
      Console.WriteLine(p);
      Console.ReadKey();
    }
    private static int FindSingleElement(int[] arr, int l)
    {
      int t = 0;
      for (int i = 0; i < l; i++)
      {
        t ^= arr[i];
      }
      return t;
    }
  }
}
