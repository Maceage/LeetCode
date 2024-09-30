using LeetCode.Problems.Data;

namespace LeetCode.Problems;

public class ReverseLinkedListProblem
{
    public ListNode ReverseList(ListNode head)
    {
        if ((head == null) || head.Next == null)
        {
            return head;
        }

        ListNode result = ReverseList(head.Next);

        head.Next.Next = head;
        head.Next = null;

        return result;
    }

    //public ListNode ReverseList(ListNode head)
    //{
    //    ListNode previousNode = null;
    //    ListNode currentNode = head;

    //    while (currentNode != null)
    //    {
    //        ListNode nextNode = currentNode.Next;

    //        currentNode.Next = previousNode;

    //        previousNode = currentNode;

    //        currentNode = nextNode;
    //    }

    //    return previousNode;
    //}

    //public ListNode ReverseList(ListNode head)
    //{
    //    if ((head == null) || (head.Next == null))
    //    {
    //        return head;
    //    }

    //    ListNode currentNode = head;

    //    Stack<ListNode> listNodeStack = new Stack<ListNode>();

    //    while (currentNode != null)
    //    {
    //        listNodeStack.Push(currentNode);

    //        currentNode = currentNode.Next;
    //    }

    //    ListNode newHead = listNodeStack.Pop();

    //    newHead.Next = null;

    //    currentNode = newHead;

    //    while (listNodeStack.TryPop(out var nextNode))
    //    {
    //        nextNode.Next = null;

    //        currentNode.Next = nextNode;

    //        currentNode = nextNode;
    //    }

    //    return newHead;
    //}
}