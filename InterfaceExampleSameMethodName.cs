using System;

namespace ConsoleApp107
{
  internal interface IA
  {
    void Print();
  }

  internal interface IB
  {
    void Print();
  }

  internal interface IC
  {
    void Print();
  }

  internal interface ID
  {
    void Print();
  }

  internal class Prog : IC, ID
  {
    void IC.Print()
    {
      Console.WriteLine("IC");
    }

    void ID.Print()
    {
      Console.WriteLine("ID");
    }
  }

  internal class Program : IA, IB
  {
    void IA.Print()
    {
      Console.WriteLine("IA");
    }

    void IB.Print()
    {
      Console.WriteLine("IB");
    }

    public static void Print()
    {
      Console.WriteLine("Hello");
    }
  }
  internal static class Test
  {
    private static void Main()
    {
      IA ia = new Program();
      ia.Print();

      IB ib = new Program();
      ib.Print();

      var program = new Program();
      Program.Print();

      IC ic = new Prog();
      ic.Print();

      ID id = new Prog();
      id.Print();

    }
  }
}
