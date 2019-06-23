using System;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str = "abcd10jk";
      string str1 = "hello Harshl";
      var t = Is_UniqueKeyWord(str);
      var t1 = Is_UniqueKeyWord1(str1);
      if (t == true)
      {
        Console.WriteLine("This string is has unique keyword");
      }
      else
      {
        Console.WriteLine("This string is has no unique keyword");
      }

      if (t1 == true)
      {
        Console.WriteLine("This string is has unique keyword");
      }
      else
      {
        Console.WriteLine("This string is has no unique keyword");
      }
    }

    private static bool Is_UniqueKeyWord1(string str)
    {
      char[] ch = str.ToCharArray();
      Array.Sort(ch);

      for(int i=0;i<ch.Length-1;i++)
      {
        if (ch[i] != ch[i + 1])
          continue;
        else
          return false;
      }
      return true;
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
