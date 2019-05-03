using System;

namespace ConsoleApp18
{
  interface IVehicle
  {
    void ChangeGear(int a);
    void SpeedUp(int a);
    void ApplyBreakes(int a);
  }


  class Bycycle : IVehicle
  {
    int speed;
    int gear;

    public void ChangeGear(int newGear)
    {
      gear = newGear;
    }

    public void SpeedUp(int increment)
    {
      speed = speed+increment;
    }

    public void ApplyBreakes(int decrement)
    {
      speed = speed - decrement;
    }

    public void PrintStatus()
    {
      Console.WriteLine("Speed" + speed + " gear" + gear);
    }
  }

  class Bike:IVehicle
  {
    private int speed;
    private int gear;

    public void ChangeGear(int newGear)
    {
      gear = newGear;
    }

    public void SpeedUp(int increment)
    {
      speed = speed + increment;
    }

    public void ApplyBreakes(int decrement)
    {
      
      speed = speed - decrement;
    }

    public void printState()
    {
      Console.WriteLine("speed" + speed + " gear" +gear);
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Bycycle bycycle = new Bycycle();
      bycycle.ChangeGear(2);
      bycycle.SpeedUp(3);
      bycycle.ApplyBreakes(1);
      
      Console.WriteLine("BiCycle Present state is : ");
      bycycle.PrintStatus();
      
      
      Bike bike = new Bike();
      bike.ChangeGear(1);
      bike.SpeedUp(4);
      bike.ApplyBreakes(3);
      
      Console.WriteLine("Bike Present state is : ");
      bike.printState();
    }
  }
}
