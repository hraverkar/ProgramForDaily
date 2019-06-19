using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
  class Program
  {
    static void Main()
    {
      var arr = new int[] { 1, 2, 3, 4, 8, 9, 5, 2, 1, 5 };
      int[] q = arr.Distinct().ToArray();
      foreach(var t in q)
      {
        Console.WriteLine(t); 
      }
      Console.WriteLine("//////////////////////////////////////////");
      var slist = new ArrayList();
      for(int i = 0; i < arr.Length; i++)
      {
        if(slist.Contains(arr[i]) == false)
        {
          slist.Add(arr[i]);
        }
      }
      var anew = slist.ToArray();
      foreach (var t in anew)
      {
        Console.WriteLine(t);     
      }
      Console.WriteLine("//////////////////////////////////////////");
      HashSet<int> set = new HashSet<int>(arr);
      int[] result = new int[set.Count];
      set.CopyTo(result);
      
      foreach(var t in result)
      {
        Console.WriteLine(t);
      }
      Console.WriteLine("//////////////////////////////////////////");
    }
  }
}

