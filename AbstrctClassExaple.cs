using System;

namespace AbstractClassExample
{
    public abstract class GeeksForGeeks
    {
       public abstract void Gfg();
    }

    public class Geek1 : GeeksForGeeks
    {

        public override void Gfg()
        {
            Console.WriteLine("Class Geek 1");
        }
    }

    public class Geek2 : GeeksForGeeks
    {
        public override void Gfg()
        {
            Console.WriteLine("Class Geek 2");
        }
    }
    
    public static class Program
    {
        private static void Main(string[] args)
        {
            GeeksForGeeks g;
            g = new Geek1();
            g.Gfg();
            
            g = new Geek2();
            g.Gfg();

        }
    }
}
