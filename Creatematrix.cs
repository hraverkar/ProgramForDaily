using System;

namespace ConsoleApp46
{
  class Program
  {
    public static void Main()
    {
      int i, j;
      int[,] arr = new int[3, 3];

      for (i = 0; i < 3; i++)
      {
        for (j = 0; j < 3; j++)
        {
          Console.WriteLine("Element [{0},{1}]", i, j);
          arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }
      Console.WriteLine("The matrix is \n");

      for (i = 0; i < 3; i++)
      {
        Console.WriteLine("\n");
        for (j = 0; j < 3; j++)
        {
          Console.Write("{0} \t", arr[i, j]);
        }
        Console.WriteLine("\n\n");
      }
    }
  }
}
