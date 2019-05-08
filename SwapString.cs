using System;

namespace ConsoleApp20
{
  internal static class Program
  {
    private static void Main()
    {
      var a = "Hello";
      var b = "Geeks";
      Console.WriteLine("String a " + a + " String b " + b);
      a += b;
      b = a.Substring(0, a.Length - b.Length);
      a = a.Substring(b.Length);
      Console.WriteLine("String a " + a + " String b " + b);

      const double num1 = 78.8;
      const double num2 = 0.8;
      const double num3 = 78.2013;
        ;
      
      var sinhValue = Math.Sinh(num1);
      Console.WriteLine("The sinh of number =" + sinhValue);

      var sinValue = Math.Sinh(num2);
      Console.WriteLine("The sinh of number =" + sinhValue);

      var sihValue = Math.Sinh(num3);
      Console.WriteLine("This is Harshal" + sinhValue);
    }
  }
}
