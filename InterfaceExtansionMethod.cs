using System;
/// <summary>
/// Using the extansion method implement interface.......
/// </summary>
namespace ConsoleApp43
{
  public interface ITestUser
  {
    int id { get; set; }
    string firstName { get; set; }
    string lastName { get; set; }
    string FormattedName();
  }
  static class ITestUserHelpers
  {
    public static string FormattedNameDefault(this ITestUser user)
    {
      return "LastName - " + user.lastName + " FirstName - " + user.firstName + " ID - " + user.id;
    }
  }

  public class TestUser : ITestUser
  {
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }

    public string FormattedName()
    {
      return this.FormattedNameDefault();
    }
  }

  class Program
  {
    public static void Main()
    {
      var TestUser = new TestUser();
      TestUser.firstName = "Harshal";
      TestUser.lastName = "Raverkar";
      TestUser.id = 111;
      var p = TestUser.FormattedName();
        Console.WriteLine(p);
        Console.ReadKey();
      
    }
  }
}


