using System;
using System.Text;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str = "Hello Harshal Ravekar        ";
      var p =str.TrimEnd();
      urlify(p);
    }
    private static void urlify(string str)
    {
      StringBuilder sb = new StringBuilder(str); 
      sb.Replace(" ","%20");
      Console.WriteLine(sb);
    }
  }
}
