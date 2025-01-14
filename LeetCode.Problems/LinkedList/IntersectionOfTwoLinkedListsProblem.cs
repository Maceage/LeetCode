using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

public class IntersectionOfTwoLinkedListsProblem
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        return GetIntersectionNodeWithTwoPointers(headA, headB);
        return GetIntersectionNodeWithHashTable(headA, headB);
        return GetIntersectionNodeBruteForce(headA, headB);
    }

    private static ListNode GetIntersectionNodeWithTwoPointers(ListNode headA, ListNode headB)
    {
        ListNode pA = headA;
        ListNode pB = headB;

        while (pA != pB)
        {
            pA = pA == null ? headB : pA.Next;
            pB = pB == null ? headA : pB.Next;
        }

        return pA;
    }

    private static ListNode GetIntersectionNodeWithHashTable(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> visitedNodes = [];

        while (headB != null)
        {
            visitedNodes.Add(headB);
            headB = headB.Next;
        }

        while (headA != null)
        {
            if (visitedNodes.Contains(headA))
            {
                return headA;
            }

            headA = headA.Next;
        }

        return null;
    }

    private static ListNode GetIntersectionNodeBruteForce(ListNode headA, ListNode headB)
    {
        while (headA != null)
        {
            ListNode pB = headB;

            while (pB != null)
            {
                if (headA == pB)
                {
                    return headA;
                }

                pB = pB.Next;
            }

            headA = headA.Next;
        }

        return null;
    }
}