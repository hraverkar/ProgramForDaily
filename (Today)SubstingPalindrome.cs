using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      string s = "ABCBAHELLOHOWRACECARAREYOUILOVEUEVOLIIAMAIDOINGGOOD";
      int longest = 3;
      int limit = s.Length;
      for (int i = 0; i < limit; i++)
      {
        for (int j = limit-1; j >i; j--)
        {
          string forstr = s.Substring(i, j - i);
          string revstr = new string(forstr.Reverse().ToArray());

          if (forstr == revstr && forstr.Length > longest)
          { 
            Console.WriteLine(forstr);
          }
        }
      }
    }
  }
}
