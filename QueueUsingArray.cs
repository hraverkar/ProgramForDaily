using System;
using System.Collections.Concurrent;

namespace QueueImplementation
{
    public class Queue
    {
        private int front, rear, capacity;
        private int[] queue;

        public Queue(int c)
        {
            front = rear = 0; 
            this.capacity = c;
            queue = new int [capacity];
        }

        public void QueueEnqueue(int data)
        {
            if (capacity == rear)
            {
                Console.WriteLine("Queue is Full,");
                return;
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;               
        }

        public void QueueDequeue()
        {


            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = 0; i < rear-1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (rear < capacity)
                {
                    queue[rear] = 0;
                }

                rear--;
            }
            return;
            ;
        }

        public void QueueDisplay()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is EMpty");
                return;
            }

            for (int j = front; j < rear; j++)
            {
                Console.Write("{0} <--",queue[j]);
            }
        }

        public void queueFront()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
                return;
                
            }
            Console.WriteLine("Front element is {0}",queue[front]);
            return;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            
            queue.QueueEnqueue(25);
            queue.QueueEnqueue(30);
            queue.QueueEnqueue(35);
            queue.QueueEnqueue(45);
            queue.QueueEnqueue(80);
            
            queue.QueueDisplay();
            
            queue.QueueDequeue();
            queue.QueueDisplay();
            queue.QueueDequeue();
            queue.QueueDisplay();
            
            queue.queueFront();
        }
    }
}
