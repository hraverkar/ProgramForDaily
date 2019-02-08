using System;

/* Encapsulation:
 * Encapsulate the wrapping the data and code.
 * variable of class are always hidden from other class
 * it can be only access using the method of their classes.
 */

namespace TestApplication
{
    public class Demo
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var demo = new Demo {Name = "Harshal Raverkar", Age = 26};

            Console.WriteLine("My name is "+demo.Name);
            Console.WriteLine("My Age is " +demo.Age);
        }   
    }
}
