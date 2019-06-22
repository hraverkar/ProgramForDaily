using System;
/*
 * Single linked list : --- > 
 * Single linklist is a variant of linked list which allows only forword traversal of 
 * linked list. This is simpple from at effective for several problem such as Big 
 * Interger Calculation.
 * 
 * List is collection of similer type of element, There are two way to maintianing a list in 
 * memeroy 
 * Store the element of the list in an array,
 * second way to store elemennt is the Linked List.
 * 
 * Random access is not allowed. We have to access elements sequentially starting from 
 * the first node. we cannot do binary search with linked lists
 
   */
namespace ConsoleApp17
{
  public class Node
  {
    public Node next;
    public object data;
  }

  public class LinkedList
  {
    private Node head;

    public void printAllNodes()
    {
      Node current = head;
      while(current!=null)
      {
        Console.WriteLine(current.data);
        current = current.next;
      }
    }

    public void AddFirst(object data)
    {
      Node toAdd = new Node();
      toAdd.data = data;
      toAdd.next = head;
      head = toAdd;
    }

    public void AddLast(object data)
    {
      if(head == null)
      {
        head = new Node();
        head.data = data;
        head.next = null;
      }
      else
      {
        Node toadd = new Node();
        toadd.data = data;

        Node current = head;
        while(current.next != null)
        {
          current = current.next;
        }
        current.next = toadd;
      }
    }
  }



  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      LinkedList linkedList = new LinkedList();
      linkedList.AddFirst("Hello");
      linkedList.AddFirst("Harshal");
      linkedList.AddFirst("Raverkar");
      linkedList.AddFirst("Bangalore");
      linkedList.printAllNodes();
      linkedList.AddLast("India");
    }
  }
}
