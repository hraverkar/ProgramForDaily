using System;

namespace FindSubstringInGIvenSubstring
{
    internal static class Program
    {
        private static int NoOfChars { get; } = 256;

        private static void Main()
        {
            Console.WriteLine("Hello World!");
            const string test = "BBBB";
            var n = test.Length;
            var t =LongestLength(test,n);
            Console.WriteLine(t);
        }

        private static int LongestLength(string test,int n)
        {
            var curLen = 1;
            var maxLen = 1;

            var visited = new int[NoOfChars];
            for (var i = 0; i < NoOfChars; i++)
            {
                visited[i] = -1;
            }

            visited[test[0]] = 0;


            for (var i = 1; i < n; i++)
            {
                var prevIndex = visited[test[i]];

                if (prevIndex == -1 || i - curLen > prevIndex)
                    curLen++;
                else
                {
                    if (curLen > maxLen)
                        maxLen = curLen;

                    curLen = i - prevIndex;
                }

                visited[test[i]] = i;
            }

            if (curLen > maxLen)
                maxLen = curLen;

            return maxLen;
        }
    }
}
