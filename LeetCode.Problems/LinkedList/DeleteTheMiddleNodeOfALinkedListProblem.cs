using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list
/// </summary>
public class DeleteTheMiddleNodeOfALinkedListProblem
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.Next == null)
        {
            return null;
        }

        ListNode slow = head;
        ListNode fast = head.Next.Next;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        slow.Next = slow.Next.Next;
        return head;
    }
}