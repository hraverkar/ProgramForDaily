using System;
using System.Threading;

namespace ConsoleApplication37
{
    /* Thread is most useful feature of c# which allow concurrent programming of two or more parts of
     the program for maximizing the utilization of the CPU.
     
     Each of the part of a program is called Thread.
     Thread are lightweight processes in process. C# support two types 

      ForeGround
      BackGround
      
      A thread which keeps on running to complete its work even if the main thread leaves its process, this type of thread is known as foreground thread. Foreground thread dows not care the main thread is alive or dia.it completly only when it finisih its assignment work, or other words the life of the foreground thread does not depend on the other main thread.
     
     */


    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            var thread  = new Thread(Mythread);
            thread.Start();
            Console.WriteLine("Main thread Ends Here !!!");
        }

        private static void Mythread()
        {
            for (var i = 0; i <= 3; i++)
            {
                Console.WriteLine("My Thread in Progress " + i);
                Thread.Sleep(100);
                
            }
                Console.WriteLine("My Thread here !!!");            
        }
    }
}

       /*
       
       in this example you are able to see the thread Thread runs after main thread ended.
       so the life of thread Thread doesn't depends upon the life of the main thread.
       the thread Thread only ends its process when it completes its assigned task.
       
       */
