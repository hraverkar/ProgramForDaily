using System;

namespace FIndHoles
{
  class Program
  {
    static int[] array = {1,0,0,0,1,0,1,0,2,1};
    static void Main(string[] args)
    {
      int num = 1732;
      var t =CountHole(num);
      Console.WriteLine(t);
      Console.ReadKey();
    }

    private static int CountHole(int num)
    {
      int holes = 0;
      while(num > 0)
      {
        int d = num % 10;
        holes += array[d];
        num /= 10;
      }
      return holes;
    }
  }
}
