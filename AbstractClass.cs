using System;
namespace TestApplication
{ 
    /* Abstract class can contain abstract method and non abstract method*/

    public abstract class AbsClass
    {
        protected static int AddTwoNumber(int a, int b)
        {
            return a + b;
        }

        public abstract int MultiplyTwoNumber(int a, int b);

        public abstract void AbstractMethod();

        public void NonAbstractMethod()
        {
            Console.WriteLine("Non Abstract Method");
        }

    }

    public class AbsDerived : AbsClass
    {
        public static void Main()
        {
            var calculate = new AbsDerived();
            var added = AddTwoNumber(25, 45);

            var multiply = calculate.MultiplyTwoNumber(12, 10);

            Console.WriteLine("Added value is {0}", added);
            Console.WriteLine("Multiply value is {0}", multiply);
        }

        public override int MultiplyTwoNumber(int a, int b)
        {
            return a * b;
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("this is abstract value");
        }
    }

}
