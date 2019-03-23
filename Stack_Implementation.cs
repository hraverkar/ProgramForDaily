using System;

namespace ConsoleApplication27
{
    internal class Stack
    {
        static int max = 1000;
        private int top;
        int[] stack = new int[max];

        public Stack()
        {
            top = -1;
        }

        internal bool Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("stack overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("stack underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("stack underflow");
            }
            else
            {
                Console.WriteLine("Item in the stack are");
                for (int i = top; i >=0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack sk = new Stack();
            sk.Push(10);
            sk.Push(20);
            sk.Push(30);
            sk.Push(40);
            sk.PrintStack();

            sk.Pop();
            sk.PrintStack();

        }
    }
}
