using System;
using System.Runtime.Serialization;

namespace ConsoleApp51
{
  public class Test
  {
    public static void Main()
    {
      try
      {
        int a = 1;
        int b = 1;
        var result = Division(a, b);
        Console.WriteLine(result);

        Temprature temp = new Temprature();
        temp.showTemp();

      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
      finally
      {
        Console.WriteLine("Hello Mr. Raverkar");
      }
    }
    private static int Division(int a, int b)
    {
      return a / b;
    }

    class Temprature
    {
      int temprature = 0;
      internal void showTemp()
      {
        try
        {
          if(temprature == 0)
          {
            throw (new TempZeroException ("Zero Temprature"));
          }
          else
          {
            Console.WriteLine("Temprature is non zero");
          }
        }
        catch(TempZeroException temp)
        {
          Console.WriteLine(temp);
        }

      }
    }
  }

  [Serializable]
  internal class TempZeroException : Exception
  {
    public TempZeroException()
    {
    }

    public TempZeroException(string message) : base(message)
    {
      message = "The tempratuer is zero";
    }

    public TempZeroException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected TempZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
