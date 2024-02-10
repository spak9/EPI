namespace EPI.BSTNode;
public class BSTNode<T> : IComparable<BSTNode<T>> where T: IComparable<T>
{

    // Properties
    public T Value { get; set; }
    public BSTNode<T>? LeftChild { get; set; }
    public BSTNode<T>? RightChild { get; set; }

    // Constructor
    public BSTNode(T value, BSTNode<T>? left, BSTNode<T>? right)
    {
        Value = value;
        LeftChild = left;
        RightChild = right;
    }
    
    public int CompareTo(BSTNode<T>? that)
    {
        // null - this instance is greater
        if (that == null)
        {
            return 1;
        }

        // Rely on the T's "CompareTo"
        return Value.CompareTo(that.Value);
    }
}
