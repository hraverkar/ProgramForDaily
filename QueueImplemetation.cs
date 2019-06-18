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
  class LinearQueue
  {
    private int[] element;
    int front;
    int rear;
    int max;
    public LinearQueue(int size)
    {
      element = new int[size];
      front = 0;
      rear = -1;
      max = size;
    }

    public void insert (int item)
    {
      if(rear == max-1)
      {
        Console.WriteLine("Queue overflow");
        return;
      }
      else
      {
        element[++rear] = item;
      }
    }

    public int delete()
    {
      if(front == rear +1)
      {
        Console.WriteLine("Queue is empty");
        return -1;
      }
      else
      {
        Console.WriteLine("Deleted element is " + element[front]);
        return element[front++];
      }
    }

    public void printQueu()
    {
      if(front == rear+1)
      {
        Console.WriteLine("Queu is empty");
        return;
      }
      else
      {
        for(int i=front; i<= rear;i++)
        {
          Console.WriteLine("Item [ " + (i + 1) + " ]:" + element[i]);
        }
      }
    }
  }
  class Program
  {
    public static void Main()
    {
      LinearQueue linearQueue = new LinearQueue(5);
      linearQueue.insert(10);
      linearQueue.insert(20);
      linearQueue.insert(30);
      linearQueue.insert(40);
      linearQueue.insert(50);
      linearQueue.insert(60);

      linearQueue.printQueu();


      linearQueue.delete();
      linearQueue.delete();


      linearQueue.printQueu();
    }

    
  }
}
