using System;

namespace AbstractClassExample
{
    internal abstract class AbstractClass
    {
        public int AddTwoNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public abstract int MultiplyTwoNumbers(int num1, int num2);
    }


    internal class Derived : AbstractClass
    {
        public override int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        
    }
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
           var derived = new Derived();

          Console.WriteLine(derived.AddTwoNumber(5, 5)); 
          Console.WriteLine(derived.MultiplyTwoNumbers(5, 5)); 

        }

    }
}
