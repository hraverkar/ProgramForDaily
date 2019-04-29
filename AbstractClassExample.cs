using System;

namespace AbstractClassExample
{
    public abstract class AreaClass
    {
        public abstract int Area();
    }

    internal class Square : AreaClass
    {
        private readonly int _side = 0;

        public Square(int n)
        {
            _side = n;
        }

        public override int Area()
        {
            return _side * _side;
        }

    }
    
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var square = new Square(6);
            Console.WriteLine(square.Area());

        }

    }
}
