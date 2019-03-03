using System;

namespace MissingNumberfromArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int[] b = {1, 2, 3, 4, 6};

            var xor1 = b[0];
            for (var i = 1; i < b.Length; i++)
            {
                xor1 = xor1 ^ b[i];
            }

            var xor2 = 1;
            for (var i = 2; i <= b.Length +1; i++)
            {
                xor2 = xor1 ^ i;
            }
            
            Console.WriteLine("the Answer is {0}",+ xor1^xor2);
        }
    }
}
