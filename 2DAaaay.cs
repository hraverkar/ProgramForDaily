using System;

namespace Array_2D
{
  internal static class Program
  {
    private static void Main()
    {
      var a = new int[3,5]{{5, 12, 17, 9, 3}, {13, 4, 8, 14, 1}, {9, 6, 3, 7, 21}};

      for(int i=0; i<3; i++)
      {
        for(int j=0; j<5; j++)
        {
          // Print out each element
          Console.Write( +a[i,j] +",");
        }
        Console.WriteLine( );
        // Print new line character after the row is printed in above loop
      }
    }
  }
}
