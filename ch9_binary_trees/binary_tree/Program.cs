
using System.Collections.Specialized;

namespace BinaryTree
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Node<int> n1 = new Node<int>(1);
      Node<int> n2 = new Node<int>(2);
      Node<int> n3 = new Node<int>(3);
      Node<int> n4 = new Node<int>(4);
      Node<int> n5 = new Node<int>(5);
      Node<int> n6 = new Node<int>(6);
      Node<int> n7 = new Node<int>(7);

      // Perfect binary tree
      // n1.Left = n2;
      // n1.Right = n3;
      // n2.Left = n4;
      // n2.Right = n5;
      // n3.Left = n6;
      // n3.Right = n7;

      n1.Left = n2;
      n1.Right = n3;
      n2.Left = n4;
      n2.Right = n5;
      n4.Left = n6;

      // Node<int>.GeneralTraversal(n1);
      // Console.WriteLine($"Height of n1: {Node<int>.GetHeight(n1)}");
      // Console.WriteLine($"Height of n7: {Node<int>.GetHeight(n4)}");

      var result = Node<int>.IsBalanced(n3);
      Console.WriteLine($"balanced?: {result}");

      // 
    }
  }


  public class Node<T>
  {
    // Basic Node properties
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }
    public T Data { get; set; }

    public Node(T data)
    {
      Data = data;
    }


    // 9.1 Check if tree is height-balanced
    public static bool IsBalanced(Node<T>? root)
    {

      (bool Balanced, int Height) CheckBalanced(Node<T>? root)
      {
        // Base case - no root is a balanced tree
        if (root == null)
        {
          return (true, -1);
        }

        var leftResult = CheckBalanced(root.Left);
        if (leftResult.Balanced == false)
        {
          return leftResult;
        }

        var rightResult = CheckBalanced(root.Right);
        if (rightResult.Balanced == false)
        {
          return rightResult;
        }

        // Do the actual "computation" post-order
        // check the abs difference between the two subtrees
        bool balanced = Math.Abs(leftResult.Height - rightResult.Height) <= 1;
        int height = Math.Max(leftResult.Height, rightResult.Height) + 1;

        return (balanced, height);
      }

      return CheckBalanced(root).Balanced;
    }

    // Height of binary tree
    public static int GetHeight(Node<T>? root)
    {
      // Base case - null root
      if (root == null)
      {
        return -1;
      }

      int leftTreeHeight = GetHeight(root.Left);
      int rightTreeHeight = GetHeight(root.Right);

      return Math.Max(leftTreeHeight, rightTreeHeight) + 1;
    }

    // 9.1 

    // Traversal
    public static void GeneralTraversal(Node<T>? root)
    {
      if (root != null)
      {
          // Pre-order - process root before left & right traversals
          Console.WriteLine($"Pre-order: {root.Data}");
          GeneralTraversal(root.Left);

          // In-order - process root after left, but before right traversal
          Console.WriteLine($"In-order: {root.Data}");
          GeneralTraversal(root.Right);

          // Post-order - process root after left & right traversals
          Console.WriteLine($"Post-order: {root.Data}");
      }
    }   

  }
}

