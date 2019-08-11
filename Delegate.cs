using System;

namespace ConsoleApp65
{
  public delegate string FirstDelegate(int x);

  internal class DelegateTest
  {
    private string name;

    private static void Main()
    {
      var fd = new FirstDelegate(StaticMethod);
      var instance = new DelegateTest {name = "Hello Harshal Instance"};
      var fd1 = new FirstDelegate(instance.InstanceMethod);
      Console.WriteLine(fd(10));
      Console.WriteLine(fd1(10));
    }

    private string InstanceMethod(int x)
    {
      return $"{name}:{x}";
    }

    private static string StaticMethod(int x)
    {
      return $"static method {x}";
    }
  }
}


