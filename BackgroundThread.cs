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
      
      ForeGround ----------------------
      A thread which keeps on running to complete its work even if the main thread leaves its process, 
      this type of thread is known as foreground thread. Foreground thread 
      does not care the main thread is alive or not.it completes only when it finish 
      its assignment work, or other words the life of the foreground thread does 
      not depend on the other main thread.
      --------------------------------------
      
      BackGround -----------------------------
      A thread which leaves its process when the Main method leaves its process,
      these types of the thread are known as the background threads,
      or in other words the life of the background thead depends upon the life of the main thread.
      if the main thread is finished its process,
      then background thread also end its process
      
      
      If you want to use a background thread in your program, 
      then set the value if IsBackground property of the thread is true.
      
     
     */


    internal static class Program
    {
        public static void Main(string[] args)
        {

            var thread = new Thread(myThread) {Name = "MyThread"};
            thread.Start();

            thread.IsBackground = true;
            Console.WriteLine("Main thread is ENds !!!!");
        }

        private static void myThread()
        {
            Console.WriteLine("In Progress thread is : {0}", Thread.CurrentThread.Name);
            Thread.Sleep(200);
            Console.WriteLine("Completed thread is : {0}", Thread.CurrentThread.Name);
        }
    }
}

/*

in this example you are able to see the thread Thread runs after main thread ended.
so the life of thread Thread doesn't depends upon the life of the main thread.
the thread Thread only ends its process when it completes its assigned task.

*/
