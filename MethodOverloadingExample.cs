using System;

namespace ConsoleApp13
{
  public class Test
  {
    public int Area(int a, int b)
    {
      return a * b;
    }

    public string Area(string a)
    {

      return a + " Raverkar";
    }

    public static float Area(float a, float b)
    {
      return a * b;
    }

    public double Area(double a, double b)
    {
      return a * b;
    }

  }


  internal static class Program
  {
    public static void Main(string[] args)
    {
      var test = new Test();
      var m = test.Area(4, 5);
      Console.WriteLine(m);

      var n = test.Area("Harshal");
      Console.WriteLine(n);

      var o = test.Area(2.4, 5.6);
      Console.WriteLine(o);

      var p = test.Area(0.004f, 2.1f);
      Console.WriteLine(p);


    }
  }
}
