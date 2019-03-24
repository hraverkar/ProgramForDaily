using System;
using System.Collections.Generic;

namespace ConsoleApplication28
{
    internal static class Stack
    {
        public static void Main(string[] args)
        {
            var st = new Stack<char> ();
            var reverse = new Stack<char>();

            st.Push('p');
            st.Push('q');
            st.Push('r');
            
            
            Console.WriteLine("Current Stack is :");
            foreach (var variable in st)
            {
                Console.Write(variable + "-->");
            }
            Console.WriteLine();
            while (st.Count != 0)
            {
                reverse.Push(st.Pop());
            }
            Console.WriteLine("Reverse Stack is :");
            foreach (var variable in reverse)
            {
                Console.Write(variable + "-->");
            }

        }
    }
}
