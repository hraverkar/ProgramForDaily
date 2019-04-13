using System;
using System.Threading;

namespace ConsoleApplication37
{
    /*    Multitasking is the simultaneous execution of multiple tasks of process over a certain time interval
     *    Windows operating system is an example of multitasking because it is capable of running more than one
     *    process at a time like running Google chrome, VLC, and all.
     */


    internal static class Program
    {
        public static void Main(string[] args)
        {
          var t1 = new Thread(Method1);
          var t2 = new Thread(Method2);
          
          t1.Start();
          t2.Start();
        }


        private static void Method1()
        {
            for (var i = 0; i <=10; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);

                if (i == 5)
                {
                    Thread.Sleep(60000);
                }
            }
        }

        private static void Method2()
        {
            for (var j = 0; j <=10; j++)
            {
                Console.WriteLine("Method2 is : {0}", j);
            }
        }
    }
}
