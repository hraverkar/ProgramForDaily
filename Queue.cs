using System;
using System.Collections;
using System.Text;

namespace ConsoleApp19
{
  class Queue
  {
    public Stack s1 = new Stack();
    public Stack s2 = new Stack();
    public void EnQueue(int x)
    {
      while (s1.Count > 0)
      {
        s2.Push(s1.Pop());
      }
      s1.Push(x);

      while (s2.Count > 0)
      {
        s1.Push(s2.Pop());
      }
    }

    public int Dequeue()
    {
      if (s1.Count == 0)
      {
        Console.WriteLine("Q is Empty");
      }
      int x = (int)s1.Peek();
      s1.Pop();
      return x;
    }

    public static void Main()
    {
      Queue q = new Queue();
      q.EnQueue(1);
      q.EnQueue(2);
      q.EnQueue(3);
      q.EnQueue(4);

      Console.WriteLine(q.Dequeue() + " ");
      Console.WriteLine(q.Dequeue() + " ");
      Console.WriteLine(q.Dequeue());
    }
  }
}
