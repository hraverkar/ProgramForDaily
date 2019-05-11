using System;
using System.Collections;
using System.Collections.Specialized;

namespace ConsoleApplication3
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var dictionary = new ListDictionary
      {
        {"India", "Delhi"}, {"Pakistan", "Islamabad"}, {"Afghanistan", "Kabul"}, {"SriLanka", "Colombo"}
      };

      Console.WriteLine("Total key/value pairs in dictionary are : " + dictionary.Count);

      foreach ( DictionaryEntry variable in dictionary)
      {
        Console.WriteLine("Key :"+variable.Key +" "+ "Values :" +variable.Value );
      }
    }
  }
}
