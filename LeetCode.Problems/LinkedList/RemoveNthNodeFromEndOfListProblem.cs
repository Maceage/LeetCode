using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list
/// </summary>
public class RemoveNthNodeFromEndOfListProblem
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        return RemoveNthFromEndOnePass(head, n);
        return RemoveNthFromEndTwoPass(head, n);
    }

    private static ListNode RemoveNthFromEndOnePass(ListNode head, int n)
    {
        ListNode dummy = new ListNode { Next = head };

        ListNode first = dummy;
        ListNode second = dummy;

        for (int i = 1; i <= n + 1; i++)
        {
            first = first.Next;
        }

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        second.Next = second.Next.Next;

        return dummy.Next;
    }

    private static ListNode RemoveNthFromEndTwoPass(ListNode head, int n)
    {
        ListNode dummy = new ListNode { Next = head };

        int length = 0;
        ListNode first = head;

        while (first != null)
        {
            length++;
            first = first.Next;
        }

        length -= n;
        first = dummy;

        while (length > 0)
        {
            length--;
            first = first.Next;
        }

        first.Next = first.Next.Next;

        return dummy.Next;
    }
}