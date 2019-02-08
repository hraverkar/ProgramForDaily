using System;

namespace TestApplication
{
    
    /* Polymorphism --- Example of Method Overloading ---  Same name method
     * with but different parameter.
    */

    public class Program
    {
        public int Divide (int a, int b)
        {
            return a / b;
        }
        public int Divide(int c, int d, int f)
        {
            return c + d + f;
        }        
    }
    
    internal static class Polymorphism
    {
        public static void Main(string[] args)
        {
           var program = new Program();
           Console.WriteLine(program.Divide(10 , 2));
           Console.WriteLine(program.Divide(56, 859, 21));
           Console.ReadKey();
        }
    }
}
