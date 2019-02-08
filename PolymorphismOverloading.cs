using System;

namespace ConsoleApplication6
{
    public class Numbers
    {

        public void addition(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void addition(double a, double b, double c)
        {
            Console.WriteLine(a+b+c);
        }
    }

    public class Display
    {
        public static void Main(string[] args)
        {
            Numbers nm = new Numbers();
            
            nm.addition(2 ,4);
            nm.addition( 1.2,6.9,6.3);
            Console.ReadKey();
        }
        
    }

}
    
