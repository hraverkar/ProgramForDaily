using System;
using System.Linq;

namespace ConsoleApp18
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      string st, rev;
      st = "Malayalam";
      var ch = st.ToCharArray();
      ch.Reverse();
      rev = new string(ch);
      if(st == rev)
        Console.WriteLine("True");
      else
        Console.WriteLine("false");

    }
  }
}
