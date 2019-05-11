using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var odd = new HashSet<int>();

      for (var i = 1; i <= 10; i++)
      {
        odd.Add(2 * i + 1);
      }

      foreach (var variable in odd)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
