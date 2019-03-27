using System;
using System.Collections.Generic;

namespace ConsoleApplication30
{
    public sealed class TwoStacks
    {
        private readonly int _size;
        private int _top1;
        private int _top2;
        private readonly int[] _arr;

        public TwoStacks(int n)
        {
            _arr = new int[n];
            _size = n;
            _top1 = -1;
            _top2 = _size;
        }

        public void Push1(int x)
        {
            if (_top1 < _top2 - 1)
            {
                _top1++;
                _arr[_top1] = x;
            }
            else
            {
                Console.WriteLine("Stack is overflow");
                Environment.Exit(1);
            }
        }

        public void Push2(int x)
        {
            if (_top1 < _top2 - 1)
            {
                _top2--;
                _arr[_top2] = x;
            }
            else
            {
                Console.WriteLine("Stack overflow");
                Environment.Exit(1);
            }
        }

        public int Pop1()
        {
            if (_top1 >= 0)
            {
                var x = _arr[_top1];
                _top1--;
                return x;
            }
            else
            {
                Console.WriteLine("stack is underflow");
                Environment.Exit(1);
            }

            return 0;
        }

        public int Pop2()
        {
            if (_top2 < _size)
            {
                var x = _arr[_top2];
                _top2++;
                return x;
            }
            else
            {
                Console.WriteLine("stack is underflow");
                Environment.Exit(1);
            }

            return 0;
        }

    }

    internal static class Program
    {
        public static void Main(string[] args)
        {
            var twoStacks = new TwoStacks(5);
            twoStacks.Push1(5);
            twoStacks.Push1(10);
            twoStacks.Push2(15);
            twoStacks.Push1(20);
            twoStacks.Push2(25);


            Console.WriteLine("Popped element from" +
                              " stack1 is " + twoStacks.Pop1());
            twoStacks.Push2(40);
            Console.WriteLine("Popped element from" +
                              " stack2 is " + twoStacks.Pop2());
        }
    }
}
