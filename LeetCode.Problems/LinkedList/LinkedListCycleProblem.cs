using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/linked-list-cycle/
/// </summary>
public class LinkedListCycleProblem
{
    private readonly HashSet<ListNode> _visitedNodes = [];

    public bool HasCycle(ListNode head)
    {
        return HasCycleWithFloydsCycleFindingAlgorithm(head);
        return HasCycleWithHashSet(head);
    }

    private bool HasCycleWithFloydsCycleFindingAlgorithm(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.Next;

        while (slow != fast)
        {
            if ((fast == null) || (fast.Next == null))
            {
                return false;
            }

            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return true;
    }

    private bool HasCycleWithHashSet(ListNode head)
    {
        bool hasCycle = false;

        if (head != null)
        {
            _visitedNodes.Add(head);

            ListNode currentNode = head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;

                if (!_visitedNodes.Add(currentNode))
                {
                    hasCycle = true;
                    break;
                }
            }
        }

        return hasCycle;
    }
}