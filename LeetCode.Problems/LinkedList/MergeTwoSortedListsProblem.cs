using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/merge-two-sorted-lists/editorial/
/// </summary>
public class MergeTwoSortedListsProblem
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        return MergeTwoListsIteration(list1, list2);
        return MergeTwoListsRecursion(list1, list2);
        return MergeTwoListsOriginal(list1, list2);
    }

    private static ListNode MergeTwoListsIteration(ListNode list1, ListNode list2)
    {
        ListNode preHead = new ListNode(-1);
        ListNode previous = preHead;

        while (list1 != null && list2 != null)
        {
            if (list1.Value <= list2.Value)
            {
                previous.Next = list1;
                list1 = list1.Next;
            }
            else
            {
                previous.Next = list2;
                list2 = list2.Next;
            }

            previous = previous.Next;
        }

        previous.Next = list1 == null ? list2 : list1;

        return preHead.Next;
    }

    private static ListNode MergeTwoListsRecursion(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }
        else if (list1.Value < list2.Value)
        {
            list1.Next = MergeTwoListsRecursion(list1.Next, list2);
            return list1;
        }
        else
        {
            list2.Next = MergeTwoListsRecursion(list1, list2.Next);
            return list2;
        }
    }

    private static ListNode MergeTwoListsOriginal(ListNode list1, ListNode list2)
    {
        ListNode headNode = new ListNode();

        ListNode currentNode = headNode;

        ListNode list1Node = list1;
        ListNode list2Node = list2;

        while ((list1Node != null) || (list2Node != null))
        {
            if (list1Node?.Value < list2Node?.Value)
            {
                currentNode.Next = list1Node;

                list1Node = list1Node.Next;

                currentNode = currentNode.Next;
            }
            else if (list1Node?.Value > list2Node?.Value)
            {
                currentNode.Next = list2Node;

                list2Node = list2Node.Next;

                currentNode = currentNode.Next;
            }
            else
            {
                if (list1Node != null)
                {
                    currentNode.Next = list1Node;

                    list1Node = list1Node.Next;

                    currentNode = currentNode.Next;
                }

                if (list2Node != null)
                {
                    currentNode.Next = list2Node;

                    list2Node = list2Node.Next;

                    currentNode = currentNode.Next;
                }
            }
        }

        return headNode.Next;
    }
}