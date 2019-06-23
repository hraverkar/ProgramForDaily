using System;
using System.Text;

namespace ConsoleApp19
{
  class Program
  {
    public static void Main()
    {
      string str = "wwwwaaadexxxxxxywww";
      PrintRLE(str);
    }

    private static void PrintRLE(string str)
    {
      int length = str.Length;
      char[] ch = str.ToCharArray();
      for(int i=0;i<length;i++)
      {
        int count = 1;
        while (i < length - 1 && ch[i] == ch[i+1])
        {
          count++;
          i++;
        }
        Console.Write(ch[i]);
        Console.Write(count);
      }
    }
  }
}
