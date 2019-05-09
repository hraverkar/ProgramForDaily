using System;

namespace Dummy
{
  internal static class Program
  {
    private interface IVehicle
    {
      void Display();
      void Test();
    }

    private interface IAeroPlane
    {
      int JetAirways(int testFlight);
      string AirAsia(string nameofPassenger);

    }

    public class Hero : IVehicle,IAeroPlane
    {
      private int FlightNumber { get; set; }
      
      private string Name { get; set; } 

      public void Display()
      {
        Console.WriteLine("This is Hero Class Display Vehicle");
      }

      public void Test()
      {
        Console.WriteLine("this is Hero Class Test Vehicle");
      }
      
      public int JetAirways(int FlightNumber)
      {
        Console.WriteLine("Hello JetAirWays" + FlightNumber);
        return FlightNumber;
      }

      public string AirAsia(string nameofPassenger)
      {
        Console.WriteLine("name of Passenger" + nameofPassenger);
        return nameofPassenger;
      }
      
    }

    public class Suzuki : IVehicle
    {
      public void Display()
      {
        Console.WriteLine("this is Suzuki class  Display method ");
      }

      public void Test()
      {
        Console.WriteLine("this is suzuki class Test Method");
      }
    }
    
    public static void Main(string[] args)
    {
      var hero = new Hero();
      hero.JetAirways(50);
      hero.AirAsia("Rajesh Raverkar");
      hero.Display();
      hero.Test();
      
      var suzuki = new Suzuki();
      suzuki.Display();
      suzuki.Test();

    }
  }
}
