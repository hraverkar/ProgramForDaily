using System;

namespace ConsoleApp46
{
  class Program
  {
    public static void Main()
    {
      var input = 21;
      FindNumber(input);
    }

    private static void FindNumber(int input)
    {
      int copyOfInputNumber = input;
      int sum = 0;
      while (input != 0)
      {
        int lastDigit = input % 10;
        sum += lastDigit;
        input /= 10;
      }

      if ((copyOfInputNumber % sum) == 0)
      {
        Console.WriteLine(copyOfInputNumber + " is a Harshad number");
      }
      else
      {
        Console.WriteLine(copyOfInputNumber + " is not a Harshad number");
      }
    }
  }
}
