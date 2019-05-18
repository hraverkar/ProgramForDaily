using System;

namespace ConsoleApplication11
{
  public class Node
  {
    public readonly int Key;
    public Node Left;
    public Node Right;

    public Node(int item)
    {
      Key = item;
      Left = Right = null;
    }
  }

  public class BinaryTree
  {
    public  Node Root;

    public BinaryTree()
    {
      Root = null;
    }

    private static void InOrder(Node node)
    {
      while (true)
      {
        if (node == null) return;
        InOrder(node.Left);
        Console.WriteLine(node.Key + " ");
        node = node.Right;
      }
    }

    private static void PreOrder(Node node)
    {
      while (true)
      {
        if (node == null) return;

        Console.WriteLine(node.Key + " ");
        PreOrder(node.Left);
        node = node.Right;
      }
    }

    private static void PostOrder(Node node)
    {
      if(node == null) return;
      PostOrder(node.Left);
      PostOrder(node.Right);
      Console.WriteLine(node.Key + " ");
    }

     public void InOrder(){InOrder(Root);}
     public void PreOrder(){PreOrder(Root);}
     public void PostOrder(){PostOrder(Root);}
  }
  internal static class Program
  {
    public static void Main()
    {
      var binaryTree = new BinaryTree {Root = new Node(1) {Left = new Node(2), Right = new Node(3)}};


      binaryTree.Root.Left.Left = new Node(4);
      binaryTree.Root.Left.Right = new Node(5);
      
      Console.WriteLine("PreOrder traversal " +  
                        "of binary tree is ");
      binaryTree.PreOrder();
      Console.WriteLine("\nInOrder traversal " +   
                        "of binary tree is "); 
      binaryTree.InOrder(); 
  
      Console.WriteLine("\nPostOrder traversal " +  
                        "of binary tree is "); 
      binaryTree.PostOrder(); 
      

    }
  }
}
