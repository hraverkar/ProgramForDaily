using System;
/*Call back by interface*/
namespace ConsoleApp159
{
  public delegate string CallbackDemo(string str);

  class Program
  {
    public static event CallbackDemo OnFooBared;

    static void Main()
    {
      OnFooBared += Program_OnFooBared;
      string substr = strfunc();
      Console.WriteLine(substr);
      Action mycode = delegate { Console.WriteLine("Another use of a delegate"); };
      mycode();

      Action mycode1 = () => Console.WriteLine("a lambda exresion");
      mycode1(); 

    }

    private static string strfunc()
    {
      return OnFooBared("a use of a delegate (with a event)");
    }

    private static string Program_OnFooBared(string str)
    {
      return str.Substring(1, 3).ToString();
    }
  }
}
