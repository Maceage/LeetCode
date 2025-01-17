using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/insert-into-a-sorted-circular-linked-list
/// </summary>
public class InsertIntoACyclicSortedListProblem
{
    public ListNode Insert(ListNode head, int insertVal)
    {
        if (head == null)
        {
            ListNode listNode = new ListNode(insertVal);

            listNode.Next = listNode;

            return listNode;
        }

        ListNode currentNode = head.Next;
        ListNode previousNode = head;
        bool toInsert = false;

        do
        {
            if (previousNode.Value <= insertVal && insertVal <= currentNode.Value)
            {
                toInsert = true;
            }
            else if (previousNode.Value > currentNode.Value)
            {
                if (insertVal >= previousNode.Value || insertVal <= currentNode.Value)
                {
                    toInsert = true;
                }
            }

            if (toInsert)
            {
                previousNode.Next = new ListNode(insertVal, currentNode);
                return head;
            }

            previousNode = currentNode;
            currentNode = currentNode.Next;
        }
        while (previousNode != head);

        previousNode.Next = new ListNode(insertVal, currentNode);

        return head;
    }
}