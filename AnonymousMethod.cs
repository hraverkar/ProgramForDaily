using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication5
{
  internal class MyData
  {
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public DateTime Dob { get; set; }
    public string MiddleName { get; set; }
  }

  public static class Program
  {
    public static void Main(string[] args)
    {
      var data = new List<MyData>
      {
        new MyData
        {
          FirstName = "harshal", Lastname = "Raverkar", MiddleName = "Test", Dob = new DateTime(1992, 10, 19)
        },
        new MyData
        {
          FirstName = "Test1", Lastname = "Raverkar1", MiddleName = "Test5", Dob = new DateTime(1992, 11, 20)
        },
        new MyData
        {
          FirstName = "Test2", Lastname = "Raverkar2", MiddleName = "Test3", Dob = new DateTime(1992, 01, 13)
        },
        new MyData
        {
          FirstName = "Test3", Lastname = "Raverkar3", MiddleName = "Test4", Dob = new DateTime(1992, 09, 14)
        }
      };


      var anndata = from pl in data select new {pl.FirstName, pl.Lastname};

      foreach (var variable in anndata)
      {
        Console.WriteLine("Name :" + variable.FirstName + " Last Name :"+ variable.Lastname);
      }
    }
  }
}
