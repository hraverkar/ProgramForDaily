using System;
using System.Linq;

/*
 *  Where operator to filter elements into a sequence.
 */
namespace ConsoleApp95
{
  internal class Program
  {
    private static void Main()
    {
      string[] names = {"Python", "Java", "JavaScript", "Bash", "C++", "Oracle"};
      var te = names.Where(p => p.StartsWith("J"));
      foreach (var variable in te)
      {
        Console.WriteLine(variable);
      }

      var test = names.Where((p, i) => (i & 1) == 1);
      foreach (var variable in test)
      {
        Console.WriteLine(variable);
      }

      string[] str = {"hello World", "hello Linq", "hello test"};
      var items = from s in str where s.StartsWith("hello") select s;
      foreach (var variable in items)
      {
       Console.WriteLine(variable); 
      }

      string[] str1 = { "hello World", "hello Linq", "hello test" };
      var t = str1.Select(p => p.Length);
      foreach (var variable in t)
      {
        Console.WriteLine(variable);
      }

      var o = str1.Select(p => new {LastName = p, l = p.Length});
      foreach (var variable in o)
      {
        Console.WriteLine(variable.LastName +" : "+variable.l);
      }

      string[] names1 = {"Python", "Java", "Javascript", "Bash", "C++", "Oracle"};
      var g = names1.Select((p, i) => new {Index = i, Lastname = p});
      foreach (var variable in g)
      {
        Console.WriteLine(variable.Index+1 +" : "+variable.Lastname);
      }

      int[] numbers = {0014, 02, 1, 39, 004};
      var nums = numbers.Select(s => (s)).ToArray();
      foreach (var variable in nums)
      {
        Console.WriteLine(variable);
      }

      string[] names3 = {"Python", "Java"};
      var y = names3.SelectMany(p => p.ToArray());
      foreach (var variable in y)
      {
        Console.WriteLine(variable);
      }

      string[] codeNames = { "Python", "Java", "Javascript", "Bash", "C++", "Oracle" };

      var items5 = codeNames.Skip(1);

      foreach (var item in items5)
        Console.WriteLine(item);

      var h = codeNames.OrderByDescending(s => s);
      var w =h.Reverse();
      foreach (var variable in w)
      {
        Console.WriteLine(variable);
      }

      string[] codeNames34 = { "Python", "Java", "Javascript", "Bash", "C++", "Oracle" };
      var itemswe = codeNames34.OrderBy(s => s.Length).ThenByDescending(s => s);

      foreach (var variable in itemswe)
      {
        Console.WriteLine(variable);
      }

      Console.WriteLine("****///************///*************///");

      var b = codeNames34.Reverse();
      foreach (var variable in b)
      {
        Console.WriteLine(variable);
      }

    }
  }
}
