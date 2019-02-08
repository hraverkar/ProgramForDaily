using System;
using System.Diagnostics;

namespace TestApplication
{
    
    /* Polymorphism --- Example of Method Overriding ---
     
     When derived class has a definition for one of the member functions of
     the base class. that base function is said to be overriden.
     
     
     
    */

    public class Vehicle
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class");
        }
    }

    public class Honda : Vehicle
    {
        public override void show()
        {
           Console.WriteLine("Derived Class"); 
        }
    }
    
    internal static class Polymorphism
    {
        public static void Main(string[] args)
        {
            var vehicle = new Vehicle();
            vehicle.show();
            
            vehicle = new Honda();
            vehicle.show();
            
        }
    }
}
