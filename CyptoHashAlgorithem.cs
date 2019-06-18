using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

/*
* Hashing is an important technique which converts any object into 
* an integer of a given range. Hashing is the key idea 
* behind Hash Maps which provides searching in any dataset in O(1) time complexity.
* 
* 
* Hash of a string
For a string of length N, a strong hash function is defined as:

H(S)=(S[0]+S[1]∗P+S[2]∗P2+...+S[N−1]∗PN−1)modM


H(S)=(N−1∑i=0 S[i]∗Pi)modM

  where:

P is a prime number (say 3)
S[i] is the ascii value of the character at index i of S (String)
M is the upper limit/ range of the hash function
*/
namespace ConsoleApp13
{
  class Program
  {
    public static void Main()
    {
      string str = "HarshalRaverkar";
     var t = GetHashString(str);
      Console.WriteLine(t);
    }

    private static string GetHashString(string str)
    {
      StringBuilder sb = new StringBuilder();
      foreach(var t in GetHash(str))
      {
        sb.Append(t.ToString("X2"));
      }
      return sb.ToString();
    }

    private static byte[] GetHash(string str)
    {
      HashAlgorithm algorithm = SHA256.Create();
      return algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
    }
  }
}
