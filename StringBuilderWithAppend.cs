using System;
using System.Text;

namespace ConsoleApplication21
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string str = "my name is Harshal Raverkar";
           var p = Replace(str);
           Console.WriteLine(p);
        }

        private static string Replace(string str)
        {
            var words = str.Split(' ');
            var st = new StringBuilder(words[0]);
            for (var i = 1; i < words.Length; i++)
            {
                st.Append("%20");
                st.Append(words[i]);
            }
            return st.ToString();
        }
    }
}
