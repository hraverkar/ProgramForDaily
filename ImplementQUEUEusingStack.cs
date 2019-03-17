using System;
using System.Collections;


namespace QueueUsingStack
{

    public class Queue
    {
        private readonly Stack _s1 = new Stack();
        private readonly Stack _s2 = new Stack();

        public void EnQueue(int x)
        {
            while (_s1.Count > 0)
            {
                _s2.Push(_s1.Pop());
            }

            _s1.Push(x);

            while (_s2.Count > 0)
            {
                _s1.Push(_s2.Pop());
            }
        }

        public int DeQueue()
        {
            if (_s1.Count == 0)
            {
                Console.WriteLine("Q is empty");
            }

            var x = (int) _s1.Peek();
            _s1.Pop();
            return x;
        }

    }

    internal static class Program
    {
        public static void Main(string[] args)
        {
            var q1 = new System.Collections.Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);

            Console.WriteLine(q1.Dequeue() + "");
            Console.WriteLine(q1.Dequeue() + "");
            Console.WriteLine(q1.Dequeue());

        }
    }
}
