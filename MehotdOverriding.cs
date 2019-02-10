using System;

/* Encapsulation:
 * Encapsulate the wrapping the data and code.
 * variable of class are always hidden from other class
 * it can be only access using the method of their classes.
 */

namespace TestApplication
{
    public class Demo
    {
        private int _x;
        private int _y;

        public Demo(){
        }
        
        public Demo(int i,int j)
        {
            _x = i;
            _y = j;
        }

        public void ShowXy()
        {
            Console.WriteLine("{0}{1}", _x, _y);
        }

        public static Demo operator +(Demo d1, Demo d2)
        {
            var demo = new Demo {_x = d1._x + d2._y, _y = d1._x + d2._y};
            return demo;
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var demo = new Demo();
            demo.ShowXy();
            
            var demo1 = new Demo( 20,30);
            demo1.ShowXy();

            var demo2 = demo + demo1;
            demo2.ShowXy();
            
        }
         
    }
}
