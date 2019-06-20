using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp49
{
  class Program
  {
    

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string s = "My Name is Harshal Raverkar";
      var t = IsUnique(s);
      Console.WriteLine(t);
    }

    private static string IsUnique(string s)
    {
      
      
      //return new string(s.ToCharArray().Distinct().ToArray());



      string newString = "";
      List<char> found = new List<char>();
      foreach(var c in s)
      {
        if (found.Contains(c))
        {
          continue;
        }

        newString = newString + c.ToString();
        found.Add(c);
      }
      return newString;
    }
  }
}
