using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list
/// </summary>
public class FlattenAMultilevelDoublyLinkedListProblem
{
    public Node Flatten(Node head)
    {
        return FlattenDfsByRecursion(head);
        return FlattenDfsByIteration(head);
    }

    private static Node FlattenDfsByRecursion(Node head)
    {
        if (head == null)
        {
            return head;
        }

        Node newHead = new Node { Next = head };

        FlattenDfs(newHead, head);

        newHead.Next.Previous = null;

        return newHead.Next;
    }

    private static Node FlattenDfs(Node previous, Node current)
    {
        if (current == null)
        {
            return previous;
        }

        current.Previous = previous;
        previous.Next = current;

        Node tempNext = current.Next;

        Node tail = FlattenDfs(current, current.Child);

        current.Child = null;

        return FlattenDfs(tail, tempNext);
    }

    private static Node FlattenDfsByIteration(Node head)
    {
        if (head == null)
        {
            return head;
        }

        Node newHead = new Node { Next = head };

        Node previousNode = newHead;

        Stack<Node> stack = new Stack<Node>();
        stack.Push(head);

        while (stack.Count > 0)
        {
            Node currentNode = stack.Pop();

            previousNode.Next = currentNode;

            currentNode.Previous = previousNode;

            if (currentNode.Next != null)
            {
                stack.Push(currentNode.Next);
            }

            if (currentNode.Child != null)
            {
                stack.Push(currentNode.Child);

                currentNode.Child = null;
            }

            previousNode = currentNode;
        }

        newHead.Next.Previous = null;

        return newHead.Next;
    }
}