using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/remove-linked-list-elements
/// </summary>
public class RemoveLinkedListElementsProblem
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode { Next = head };

        ListNode previousNode = dummy;
        ListNode currentNode = dummy.Next;

        while (currentNode != null)
        {
            if (currentNode.Value == val)
            {
                previousNode.Next = currentNode.Next;
            }
            else
            {
                previousNode = currentNode;
            }

            currentNode = currentNode.Next;
        }

        return dummy.Next;
    }
}