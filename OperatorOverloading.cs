using System;
using System.Diagnostics;

namespace TestApplication
{
    
    /* Polymorphism --- Example of Operator Overloading ---
     
     The concept of operating overloading a function can also apply to operators.
     Operator overloading gives the ability to use the same operator to do various 
     operations.
     
     
     
    */

    public class Program
    {
        private int _number1;
        private int _number2;

        public Program(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public static Program operator -(Program c1)
        {
            c1._number1 = -c1._number1;
            c1._number2 = -c1._number2;
            return c1;
        }

        public void Print()
        {
            Console.WriteLine("Number 1 = " +_number1);
            Console.WriteLine("Number 2 = " +_number2);
        }
    }
    
    internal static class Polymorphism
    {
        public static void Main(string[] args)
        {
            var program = new Program(15,-25);
            program = -program;
            program.Print();

        }
    }
}
