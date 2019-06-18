using System;

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
    static void Main()
    {
      string str = "HarshalRaverkar";
     var t=  hash(str);
      Console.Write(t);
    }

    private static long hash(string str)
    {
      const int p = 3;
      const int m = 10000009;
      long hash = 0;
      long pow = 1;
      foreach(var t in str)
      {
        hash = (hash + (t - 'a' + 1) * pow) % m;
        pow = (pow * p) % m;
      }
      return hash;
    }
  }
}
