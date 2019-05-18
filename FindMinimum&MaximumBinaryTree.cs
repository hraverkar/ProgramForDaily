using System;

namespace ConsoleApplication12
{
  public class Node
  {
    public readonly int Data;
    public Node Right, Left;

    public Node(int key)
    {
      Data = key;
      Right = Left = null;
    }
  }

  public class BinaryTree
  {
    public Node Root;

    public int FindMax(Node node)
    {
      if (node == null)
        return int.MinValue;
      var result = node.Data;
      var leftResult = FindMax(node.Left);
      var rightResult = FindMax(node.Right);

      if (leftResult > result)
        result = leftResult;
      if (rightResult > result)
        result = rightResult;
      return result;
    }

    public int FindMin(Node node)
    {
      if (node == null)
        return int.MaxValue;
      var result = node.Data;
      var leftResult = FindMax(node.Left);
      var rightResult = FindMax(node.Right);

      if (leftResult < result)
        result = leftResult;
      if (rightResult < result)
        result = rightResult;
      return result;
    }
  }

  internal static class Program
  {
    public static void Main(string[] args)
    {
      var tree = new BinaryTree {Root = new Node(2) {Left = new Node(7), Right = new Node(5)}};
      tree.Root.Left.Right = new Node(6) {Left = new Node(1), Right = new Node(11)};
      tree.Root.Right.Right = new Node(9) {Left = new Node(4)};

      Console.WriteLine("Maximum Number in Binary Tree : " + tree.FindMax(tree.Root));
      Console.WriteLine("Minimum Number in Binary Tree : " + tree.FindMin(tree.Root));

    }
  }
}
