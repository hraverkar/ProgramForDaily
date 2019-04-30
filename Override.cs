using System;

namespace ConsoleApp12
{
    internal abstract class AbstractClass
    {
        public int AddTwoNumber(int a, int b)
        {
            return a + b;
        }

        public abstract int MultiplyTwoNumber(int a, int b);
    }


    internal class DerivedClass : AbstractClass
    {

        public override int MultiplyTwoNumber(int a, int b)
        {
            return a * b;
        }
        
    }

    public static class Program
    {
        public static void Main()
        {
            var derivedClass = new DerivedClass();
            var t = derivedClass.MultiplyTwoNumber(8, 9);
            var f = derivedClass.AddTwoNumber(80, 5);
            
            Console.WriteLine(t);
            Console.WriteLine(f);
        }
    }
}
