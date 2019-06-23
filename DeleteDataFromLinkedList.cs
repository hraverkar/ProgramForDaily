using System;
using System.Text;

namespace ConsoleApp19
{
  class Program
  {
    class Node
    {
      public int data;
      public Node next;
    }

    static Node Delete(Node head)
    {
      if (head == null)
        return null;
      if (head.next == null)
        return null;
      Node slow_ptr = head;
      Node fast_ptr = head;

      Node prev = null;

      while (fast_ptr != null && fast_ptr.next != null)
      {
        fast_ptr = fast_ptr.next.next;
        prev = slow_ptr;
        slow_ptr = slow_ptr.next;
      }
      prev.next = slow_ptr.next;
      return head;
    }

    static void PrintList(Node ptr)
    {
      while(ptr != null)
      {
        Console.Write(ptr.data + "->");
        ptr = ptr.next;
      }
      Console.WriteLine("NULL");
    }

    static Node NewNode(int data)
    {
      Node temp = new Node
      {
        data = data,
        next = null
      };
      return temp;
    }


    public static void Main()
    {
      Node head = NewNode(1);
      head.next = NewNode(2);
      head.next.next = NewNode(3);
      head.next.next.next = NewNode(4);
      head.next.next.next.next = NewNode(5);
      head.next.next.next.next.next = NewNode(6);
      head.next.next.next.next.next.next = NewNode(7);
      head.next.next.next.next.next.next.next = NewNode(8);
      head.next.next.next.next.next.next.next.next = NewNode(9);

      Console.WriteLine("Given linked List");
      PrintList(head);

      head = Delete(head);
      Console.WriteLine("Given linked List - after deletion of middle");
      PrintList(head);
    }
  }
}
