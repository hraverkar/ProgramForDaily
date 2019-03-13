using System;
using System.Text;

namespace ConsoleApplication21
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string input = "aaabbbcc";
            var a = CompressString(input);
            Console.WriteLine(a);

        }

        private static string CompressString(string imp)
        {
            var sb = new StringBuilder();
            var ch = imp.ToCharArray();
            var length = ch.Length;
            var count = 1;

            for (var i = 0; i < length - 1; i++)
            {
                if (i != length - 1 && ch[i] == ch[i + 1])
                {
                    count++;
                }
                else
                {
                    sb.Append(ch[i] + "" + count);
                    count = 1;

                }
            }

            if (imp.Length > sb.ToString().Length)
            {
                sb.Append(ch[imp.Length - 1] + "" + count);
            }

            return sb.ToString();
        }
    }
}
