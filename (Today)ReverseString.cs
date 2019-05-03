using System;
using System.Diagnostics;

namespace ConsoleApp18
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      const string s = "Harshal Raverkar";
      ReverseString(s);
    }

    private static void ReverseString(string s)
    {
      var ch = s.ToCharArray();
      var p = ch.Length-1;

      for (var i = 0; i < p; i++)
      {
        ch[i] ^= ch[p];
        ch[p] ^= ch[i];
        ch[i] ^= ch[p];
        p--;
      }

      Console.WriteLine( new string(ch));
    }
  }
}
