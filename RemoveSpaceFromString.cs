using System;

namespace ConsoleApplication21
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            char [] str = "My Name is harshal Raverkar".ToCharArray();
           var a= removeSpace(str);
           //Console.WriteLine(str(" ","%20"));
           Console.WriteLine(String.Join("",str).Substring(0,a));
        }

        private static int removeSpace(char[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    str[count++] = str[i];
            }

            return count;
        }
    }
}
