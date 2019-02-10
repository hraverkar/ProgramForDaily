using System;

namespace TestApplication
{
    internal interface IOne
    {
        void One();
        void Two();
        void Four();
        void Six();
    }

    internal interface ITwo
    {
        void Two();
    }

    internal interface IThree:IOne
    {
        void Three();
    }

    internal interface IFour
    {
        void Four();
    }

    internal interface IFIve : IThree
    {
        void Five();
    }

    internal interface ISix
    {
        void Six();
    }

    internal interface IEven : ITwo,IFour,ISix
    {
        
    }

    internal class OddEven : IEven, IFIve
    {
        public void One()
        {
            Console.WriteLine("this is One");
        }

        public void Two()
        {
            Console.WriteLine("this is Two");
        }

        public void Three()
        {
            Console.WriteLine("This is Three");
        }

        public void Four()
        {
            Console.WriteLine("this is Four");
        }

        public void Five()
        {
            Console.WriteLine("this is Five");
        }

        public void Six()
        {
            Console.WriteLine("this is Six");
        }
        
    }


    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is ODD");
            IFIve obj = new OddEven();
            obj.One();
            obj.Three();
            obj.Five();
            
            Console.WriteLine("\n\nThis is Even");
            IOne obj1 = new OddEven();
            obj1.Two();
            obj1.Four();
            obj1.Six();
            Console.ReadLine();
        }
        
    }
    
}
