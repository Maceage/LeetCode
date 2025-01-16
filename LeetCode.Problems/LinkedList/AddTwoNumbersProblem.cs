using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/add-two-numbers/
/// </summary>
public class AddTwoNumbersProblem
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode();
        ListNode currentNode = dummyHead;

        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int x = l1?.Value ?? 0;
            int y = l2?.Value ?? 0;

            int sum = carry + x + y;

            carry = sum / 10;

            currentNode.Next = new ListNode(sum % 10);
            currentNode = currentNode.Next;

            if (l1 != null)
            {
                l1 = l1.Next;
            }

            if (l2 != null)
            {
                l2 = l2.Next;
            }
        }

        return dummyHead.Next;
    }
}