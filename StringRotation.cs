using System;
using System.Text;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str = "HarshalRaverkar";
      var t =LeftRotate(str, 3);
      Console.WriteLine(t);
      t = RightRotate(str, 3);
      Console.WriteLine(t);
    }

    private static string RightRotate(string str, int v)
    {
      return LeftRotate(str, str.Length - v);
    }

    private static string LeftRotate(string str, int v)
    {
      string ans = str.Substring(v) + str.Substring(0, v);
      return ans;
    }

  }
}
