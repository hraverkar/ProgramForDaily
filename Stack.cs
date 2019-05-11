using System;

namespace ConsoleApplication3
{
  public class Stack
  {
    private readonly int[] _element;
    private int _top;
    private readonly int _max;

    public Stack(int size)
    {
      _element = new[] {size};
      _top = -1;
      _max = size;
    }

    public void Push(int item)
    {
      if (_top == _max - 1)
      {
        Console.WriteLine("Stack overflow");
        return;
      }
      else
      {
        _element[++_top] = item;
      }
      
    }

    public int PoP()
    {
      if (_top == -1)
      {
        Console.WriteLine("Stack is empty");
        return -1;
      }
      else
      {
        Console.WriteLine("{0} popped from stack" ,_element[_top] );
        return _element[_top--];
      }
    }

    public void PrintStack()
    {
      if (_top == -1)
      {
        Console.WriteLine("Stack is empty");
        return;
      }
      else
      {
        for (var i = 0; i <= _top; i++)
        {
          Console.WriteLine("{0} pushed into stack",_element[i]);
        }
      }
    }
  }
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var stack = new Stack(5);
      stack.Push(10);
      stack.Push(200);
      stack.Push(300);
      stack.Push(2);
      stack.Push(65);
      
      stack.PrintStack();
      stack.PoP();
      stack.PrintStack();
    }
  }
}
