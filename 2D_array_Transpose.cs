using System;

namespace Array_2D
{
  internal static class Program
  {
    private static void Main()
    {
      var a = new int[3, 5] {{5, 12, 17, 9, 3}, {13, 4, 8, 14, 1}, {9, 6, 3, 7, 21}};
      for (var i = 0; i < 3; i++)
      {
        for (var j = 0; j < 5; j++)
        {
          // Print out each element
          Console.Write(+a[i, j] + ",");
        }

        Console.WriteLine();
        // Print new line character after the row is printed in above loop
      }

      var rowCount = a.GetLength(0);
      var columnCount = a.GetLength(1);

      var transpose = new int[columnCount, rowCount];

      if (rowCount == columnCount)
      {
        transpose = (int[,]) a.Clone();

        for (var i = 1; i < rowCount; i++)
        {
          for (var j = 0; j < i; j++)
          {
            var temp = transpose[i, j];
            transpose[i, j] = transpose[j, i];
            transpose[j, i] = temp;
          }
        }
      }
      else
      {
        for (var i = 0; i < columnCount; i++)
        {
          for (var j = 0; j < rowCount; j++)
          {
            transpose[i, j] = a[j, i];
          }
        }
      }
      for (var i = 0; i < 5; i++)
      {
        for (var j = 0; j < 3; j++)
        {
          // Print out each element
          Console.Write(+transpose[i, j] + ",");
        }
        Console.WriteLine();
        // Print new line character after the row is printed in above loop
      }
    }
  }
}
