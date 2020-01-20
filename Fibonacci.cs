using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp29
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var i in FibonachiSeries().Take(5))
      {
        Console.WriteLine(i);
      };
    }

    private static IEnumerable<int> FibonachiSeries()
    {
      int current = 1; int next = 1;
      while(true)
      {
        yield return current;
        next = current + (current = next);
      }
    }
  }
}
