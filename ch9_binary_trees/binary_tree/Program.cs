
using System.Collections.Specialized;

namespace BinaryTree
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Node n1 = new Node(1);
      Node n2 = new Node(2);
      Node n3 = new Node(3);
      Node n4 = new Node(4);
      Node n5 = new Node(5);
      Node n6 = new Node(6);
      Node n7 = new Node(7);

      n1.Left = n2;
      n1.Right = n3;

      n2.Left = n4;
      n2.Right = n5;

      n3.Left = n6;
      n3.Right = n7;

      InOrderTraversal(n1);
    }

    public static void InOrderTraversal(Node? root)
    {
      if (root != null)
      {
        InOrderTraversal(root.Left);

        Console.WriteLine(root.Data);

        InOrderTraversal(root.Right);
      }
    }
  }

  public class Node
  {
    // Basic Node properties
    public Node? Left { get; set; }
    public Node? Right { get; set; }
    public int Data { get; set; }

    public Node(int data)
    {
      this.Data = data;
    }
  }
}

