using System;

namespace ConsoleApp65
{
  public delegate string MyDel(string str);

  internal class EventProgram
  {
    private event MyDel MyEvent;

    public EventProgram()
    {
      MyEvent += WellComeUser;
    }

    public string WellComeUser(string username)
    {
      return "Welcome " + username;
    }

    private static void Main()
    {
      Console.WriteLine("Hello World!");
      var ev = new EventProgram();
      var result = ev.MyEvent("Hello Harshal Raverkar");
      Console.WriteLine(result);
    }
  }
}


