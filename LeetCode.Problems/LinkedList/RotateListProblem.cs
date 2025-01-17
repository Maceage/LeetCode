using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/rotate-list
/// </summary>
public class RotateListProblem
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
        {
            return head;
        }

        if (head.Next == null)
        {
            return head;
        }

        ListNode oldTail = head;

        int nodeCount;

        for (nodeCount = 1; oldTail.Next != null; nodeCount++)
        {
            oldTail = oldTail.Next;
        }

        // Reached tail node so join to start
        oldTail.Next = head;

        ListNode newTail = head;

        // Find new tail : (n - k % n - 1)th node
        // And new head : (n - k % n)th node
        for (int i = 0; i < nodeCount - (k % nodeCount) - 1; i++)
        {
            newTail = newTail.Next;
        }

        ListNode newHead = newTail.Next;

        newTail.Next = null;

        return newHead;
    }
}