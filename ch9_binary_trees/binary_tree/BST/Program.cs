using EPI.BSTNode;

public class BST<T> where T: IComparable<T>
{

    // fields
    private BSTNode<T>? _root;
    private uint _count;
    private uint _height;

    // the root of the tree
    public BSTNode<T>? Root
    {
        get { return _root; }
    }

    // number of nodes in the tree
    public uint Count
    {
        get { return _count; }
    }

    // height of the tree
    public uint Height
    {
        get { return _height; }
    }

    // Primary constructor
    public BST()
    {
        _root = null;
    }

    // Secondary constructor 
    public BST(T data)
    {
        _root = new BSTNode<T>(value: data, left: null, right: null);
    }

    public BSTNode<T> Insert(BSTNode<T>? someRoot, T value)
    {
        // create temp node for comparison
        BSTNode<T> tempNode = new BSTNode<T>(value: value, null, null);

        // base case: create leaf node and return leaf for parent reference
        if (someRoot == null)
        {
            someRoot = tempNode;

            // case: empty tree
            if (_root == null)
            {
                _root = someRoot;
            }
        }

        // case: go left
        else if (someRoot.CompareTo(tempNode) > 0)
        {
            someRoot.LeftChild = Insert(someRoot.LeftChild, value);
        }

        // case: go right
        else if (someRoot.CompareTo(tempNode) < 0)
        {
            someRoot.RightChild = Insert(someRoot.RightChild, value);
        }

        // Always returning the child of parent node..
        return someRoot;
    }

    public static void PreorderTraverse(BSTNode<T>? root)
    {
        if (root != null)
        {
            Console.WriteLine($"Visiting: {root.Value}");
            PreorderTraverse(root.LeftChild);
            PreorderTraverse(root.RightChild);
        }
    }

    public static void InorderTraverse(BSTNode<T>? root)
    {
        if (root != null)
        {
            InorderTraverse(root.LeftChild);
            Console.WriteLine($"Visiting: {root.Value}");
            InorderTraverse(root.RightChild);
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        // Test tree
        BST<int> tree = new BST<int>();
        BSTNode<int>? root = null;

        root = tree.Insert(root, 5);
        tree.Insert(root, 3);
        tree.Insert(root, 10);
        tree.Insert(root, 1);
        tree.Insert(root, 2);
        tree.Insert(root, 6);
        tree.Insert(root, 12);

        // BST<int>.PreorderTraverse(tree.Root);
        BST<int>.InorderTraverse(tree.Root);
        
    }
}
