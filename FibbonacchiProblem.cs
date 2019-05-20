using System;

namespace ConsoleApplication13
{
  class Program
  {
    public static void Main(string[] args)
    {
      int n = 6;
      int t = fibonacchiSeries(n);
      Console.WriteLine(t);
    }

    private static int fibonacchiSeries(int i)
    {
      int number = i - 1;
      int[] Fib = new int[number + 1];
      Fib[0] = 0;
      Fib[1] = 1;
      for (int j = 2; j <=number; j++)
      {
        Fib[j] = Fib[j - 2] + Fib[j - 1];
      }

      return Fib[number];
    }
  }

}
