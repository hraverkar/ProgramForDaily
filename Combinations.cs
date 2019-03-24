using System;
using System.Collections.Generic;

namespace ConsoleApplication28
{
    internal class Stack
    {
        public static void Main(string[] args)
        {
            var arr = new[] {'a', 'b', 'c'};
            var t =permutation(arr);
            foreach (var VARIABLE in t)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        private static string[] permutation(char[] arr)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    list.Add(new string(new char[]
                    {
                        arr[i], arr[j]
                    }));
                }
            }

            return list.ToArray();
        }
    }
}
