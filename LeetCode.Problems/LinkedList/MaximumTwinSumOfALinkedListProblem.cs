using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

public class MaximumTwinSumOfALinkedListProblem
{
    public int PairSum(ListNode head)
    {
        // Find the midpoint of the linked list
        ListNode midPointNode = FindMidPointNode(head);

        // Split the latter half from the linked list
        ListNode secondHalfHead = midPointNode.Next;
        midPointNode.Next = null;

        // Reverse latter half of linked list
        secondHalfHead = ReverseList(secondHalfHead);

        // Iterate through each linked list half and find the highest twin sum
        ListNode leftNode = head;
        ListNode rightNode = secondHalfHead;

        int highestSum = 0;

        do
        {
            int leftValue = leftNode.Value;
            int rightValue = rightNode.Value;

            int currentSum = leftValue + rightValue;

            highestSum = Math.Max(highestSum, currentSum);

            leftNode = leftNode.Next;
            rightNode = rightNode.Next;
        }
        while ((leftNode != null) && (rightNode != null));

        return highestSum;
    }

    private static ListNode FindMidPointNode(ListNode head)
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

        return slow;
    }

    private static ListNode ReverseList(ListNode head)
    {
        if ((head == null) || (head.Next == null))
        {
            return head;
        }

        ListNode result = ReverseList(head.Next);

        head.Next.Next = head;
        head.Next = null;

        return result;
    }
}