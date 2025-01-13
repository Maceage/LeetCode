using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

public class LinkedListCycle2Problem
{
    private readonly HashSet<ListNode> _visitedNodes = [];

    public ListNode DetectCycle(ListNode head)
    {
        return DetectCycleFloydTortoiseAndHareAlgorithm(head);
        return DetectCycleWithHashSet(head);
    }

    private ListNode DetectCycleFloydTortoiseAndHareAlgorithm(ListNode head)
    {
        ListNode tortoise = head;
        ListNode hare = head;

        while ((hare != null) && (hare.Next != null))
        {
            tortoise = tortoise.Next;
            hare = hare.Next.Next;

            if (tortoise == hare)
            {
                break;
            }
        }

        if ((hare == null) | (hare.Next == null))
        {
            return null;
        }

        hare = head;

        while (tortoise != hare)
        {
            tortoise = tortoise.Next;
            hare = hare.Next;
        }

        return tortoise;
    }

    private ListNode DetectCycleWithHashSet(ListNode head)
    {
        ListNode cycleNode = null;

        if (head != null)
        {
            _visitedNodes.Add(head);

            ListNode currentNode = head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;

                if (!_visitedNodes.Add(currentNode))
                {
                    cycleNode = currentNode;
                    break;
                }
            }
        }

        return cycleNode;
    }
}