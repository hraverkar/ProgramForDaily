using System;

namespace ConsoleApp15
{

  class Queue
  {
    private readonly int[] queue;
    int front;
    int rear;
    const int Max = 100;

    public Queue()
    {
      queue = new int[Max];
      front = 0;
      rear = -1;
    }

    public void Insert(int item)
    {
      if(rear == Max-1)
      {
        Console.WriteLine("Queue is OVerflow");
        return;
      }
      else
      {
        queue[++rear] = item;
      }
    }
    public int Delete()
    {
      if(front == rear+1)
      {
        Console.WriteLine("Queue is Empty");
        return -1;
      }
      else
      {
        Console.WriteLine("Deleted Element is " + queue[front]);
        return queue[front++];
      }
    }

    public void PrintQueue()
    {
      if(front == rear+1)
      {
        Console.WriteLine("Queue is empty");
        return;
      }
      else
      {
        for(int i=front;i<=rear;i++)
        {
          Console.WriteLine("Item [" + (i + 1) + "]:" + queue[i]);
        }
      }
    }
  }

  class Program
  {
    static void Main()
    {
      Queue queue = new Queue();
      queue.Insert(10);
      queue.Insert(20);
      queue.Insert(30);
      queue.Insert(40);
      queue.Insert(50);
      queue.Insert(60);

      queue.PrintQueue();
      queue.Delete();
      queue.PrintQueue();

    }
  }
}
