using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var vowel = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
            Console.WriteLine("Enter the Sentence  :- ");
            var sentence = Console.ReadLine()?.ToLower();
            if (sentence != null)
            {
                var total = sentence.Count(a => vowel.Contains(a));
                Console.WriteLine("YOur Total number of vowel is : {0}", total);
            }

            Console.ReadLine();
        }
    }
}
