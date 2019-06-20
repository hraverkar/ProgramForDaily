using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp49
{
  class Program
  {
    static void Main()
    {
      string str1 = "test";
      string str2 = "pest";
      var t = arePerMutation(str1, str2);
      Console.WriteLine(t);
    }

    private static bool arePerMutation(string str1, string str2)
    {
      var l1 = str1.Length;
      var l2 = str2.Length;

      if (l1 != l2)
        return false;
      char[] ch1 = str1.ToCharArray();
      char[] ch2 = str2.ToCharArray();

      Array.Sort(ch1);
      Array.Sort(ch2);

      for( int i=0;i<l1; i++)
      {
        if (ch1[i] != ch2[i])
          return false; 
      }
      return true;
    }
  }
}
