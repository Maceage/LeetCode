namespace LeetCode.Problems.Data;

public class Node(int value = 0, Node previous = null, Node next = null, Node child = null)
{
    public int Value = value;
    public Node Previous = previous;
    public Node Next = next;
    public Node Child = child;
}