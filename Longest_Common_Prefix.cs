using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "flower","flow","float" };

           var t = LongestPalindrome(a);
            Console.WriteLine(t);
            Console.ReadKey();

        }
        public static string LongestPalindrome(string [] st)
        {
              if (st.Length == 0)
                return "";
            string _pFix = st[0];
            for(int i=0;i<st.Length;i++)
            {
                while(st[i].IndexOf(_pFix) !=0)
                {
                    _pFix = _pFix.Substring(0,_pFix.Length-1);

                    if (_pFix == "")
                        return "";
                }
            }
            return _pFix;

            throw new IndexOutOfRangeException();
        }
    }
}


