using System;

namespace ConsoleApp16
{
  public static class Program
  {
    
    public static void Main(string[] args)
    {
      int? i = null;
      const int j = 10;
      
      if(Nullable.Compare<int>(i,j) < 0)
        Console.WriteLine("i<j");
      else if(Nullable.Compare<int>(i,j) > 0 )
        Console.WriteLine("i>j");
      else
        Console.WriteLine("i==j");
    }
  }
}
