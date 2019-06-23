using System;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str1 = "test";
      string str2 = "ttes";
      var t = arePermutation(str1,str2);
      if (t == true)
      {
        Console.WriteLine("This string is permutation");
      }
      else
      {
        Console.WriteLine("This string is no permutation");
      }
    }

    private static bool arePermutation(string str1,string str2)
    {
      int n1 = str1.Length;
      int n2 = str2.Length;

      if (n1 != n2)
        return false;
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();
      Array.Sort(ch1);
      Array.Sort(ch2);

      for(int i=0;i<n1;i++)
      {
        if (ch1[i] != ch2[i])
          return false;
      }
      return true;
    }
  }
}
