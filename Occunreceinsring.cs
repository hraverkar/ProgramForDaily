using System;

namespace ConsoleApp11
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = "aabcccccaaa";
      while (input.Length > 0)
      {
        Console.Write(input[0]);
        int count = 0;
        for (int j = 0; j < input.Length; j++)
        {
          if (input[0] == input[j])
          {
            count++;
          }
        }
        Console.Write(count);
        input = input.Replace(input[0].ToString(), string.Empty);
      }
      Console.ReadLine();
    }
  }
}
