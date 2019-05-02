using System;

namespace ConsoleApp16
{
  internal class MyClass
  {
    public int? I = null;
    public  int J = 10;
  }

  internal static class Program
  {
    private static void Main(string[] args)
    {
      MyClass mc = new MyClass();
      if (mc.I < mc.J)
      {
        Console.WriteLine("i<J");
      }
      else if (mc.I > 10)
        Console.WriteLine("i>j");
      else if (mc.I == 10)
        Console.WriteLine("i== j");
      else 
        Console.WriteLine("Could not compare");

    }
  }
}
