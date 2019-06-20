using System;
using System.Collections;
using System.Collections.Generic;
/*Stack - A stack is data structure in which items are added or 
* removed in a last in first out .
* We can use example of plates in which the last 
* added plate will be removed first.
* --- Stack two mehthod Push, Pop
* Push()--- > Push in stack means adding element to the stack 
* Elements are added in the stack from one direction only. I ma calling tha t
* position as the top of the stack.
* Stack is somewaht of a restrictive data structure 
* becasue it only allows insertion of
* element from the top of the stack.
* 
* Pop--- Pop in stack means removeing an element from the stack 
* item are added in the oreder  1 2 3 
* then on calling pop then item 3 will be removed first then 2 and 
* 1.
* 
* Peek -- A peek operation returns the last added element in the staf
* on the top.
* 
* Clear -- it will clear all the items pf the stack.
* Enumeratng among elemnt of the stack.
*/
namespace ConsoleApp13
{
  internal class Stack
  {
    static readonly int MAX = 1000;
    int top;
    readonly int[] stack = new int[MAX];
    public Stack()
    {
      top = -1;
    }

    public bool IsEmpty()
    {
      return (top < 0);
    }

    internal bool Push(int data)
    {
      if (top >= MAX)
      {
        Console.WriteLine("Stack is overflow");
        return false;
      }
      else
      {
        stack[++top] = data;
        return true;
      }
    }
    internal int Pop()
    {
      if (top < 0)
      {
        Console.WriteLine("Stack Underflow");
        return 0;
      }
      else
      {
        int value = stack[top--];
        return value;
      }
    }
    internal void Peek()
    {
      if (top < 0)
      {
        Console.WriteLine("Stack Underflow");
        return;
      }
      else
        Console.WriteLine("The topmost element of stak : " + stack[top]);
    }

    internal void PrintStack()
    {
      if (top < 0)
      {
        Console.WriteLine("Stack Underflow");
        return;
      }
      else
      {
        Console.WriteLine("items in the stack are");
        for (int i = top; i >= 0; i--)
        {
          Console.WriteLine(stack[i]);
        }
      }
    }
  }

  class Program
  {
    static void Main()
    {
      Stack stack = new Stack();
      stack.Push(10);
      stack.Push(20);
      stack.Push(30);
      stack.Push(40);
      stack.Push(50);
      stack.PrintStack();
      stack.Peek();

      Console.WriteLine("Item is poped form stack {0}", stack.Pop());
      stack.PrintStack();
    }
  }
}
