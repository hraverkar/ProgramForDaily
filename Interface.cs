using System;

namespace TestApplication
{
    internal interface IMyInterface
    {
        void MethodToImplement();

        int MethodAddition(int a, int b);
    }

    internal class InterfaceImplement : IMyInterface
    {
        public static void Main(string[] args)
        {
            var obj = new InterfaceImplement();
            obj.MethodToImplement();
            obj.MethodAddition(98, 2);
            Console.WriteLine(obj.MethodAddition(98, 2));
        }

        public int MethodAddition(int i, int i1)
        {
            return i + i1;
        }

        public void MethodToImplement()
        {
            Console.WriteLine("Test Harshal");
        }

    }
}
