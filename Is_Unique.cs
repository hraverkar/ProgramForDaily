using System;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str = "abcd10jk";
      var t = Is_UniqueKeyWord(str);
      if(t == true)
      {
        Console.WriteLine("This string is has unique keyword");
      }
      else
      {
        Console.WriteLine("This string is has no unique keyword");
      }
    }

    private static bool Is_UniqueKeyWord(string str)
    {
      for(int i=0;i<str.Length;i++)
      {
        for (int j = i +1;j<str.Length;j++)
        {
          if (str[i] == str[j])
            return false;
        }
      }
      return true;
    }
  }
}
