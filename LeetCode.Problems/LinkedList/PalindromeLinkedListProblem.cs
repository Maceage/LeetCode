using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

public class PalindromeLinkedListProblem
{
    private static ListNode _frontPointer;

    public bool IsPalindrome(ListNode head)
    {
        return IsPalindromeWithReverseSecondHalfInPlace(head);
        return IsPalindromeRecursive(head);
        return IsPalindromeWithTwoPointers(head);
    }

    private static bool IsPalindromeWithReverseSecondHalfInPlace(ListNode head)
    {
        if (head == null)
        {
            return true;
        }

        ListNode firstHalfEnd = EndOfFirstHalf(head);
        ListNode secondHalfStart = ReverseList(firstHalfEnd.Next);

        ListNode p1 = head;
        ListNode p2 = secondHalfStart;

        bool result = true;

        while (result && p2 != null)
        {
            if (p1.Value != p2.Value)
            {
                result = false;
            }

            p1 = p1.Next;
            p2 = p2.Next;
        }

        firstHalfEnd.Next = ReverseList(secondHalfStart);

        return result;
    }

    private static ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextTemp = current.Next;

            current.Next = previous;
            previous = current;
            current = nextTemp;
        }

        return previous;
    }

    private static ListNode EndOfFirstHalf(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast.Next != null && fast.Next.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        return slow;
    }

    private static bool IsPalindromeRecursive(ListNode head)
    {
        _frontPointer = head;

        return RecursivelyCheck(head);
    }

    private static bool RecursivelyCheck(ListNode currentNode)
    {
        if (currentNode != null)
        {
            if (!RecursivelyCheck(currentNode.Next))
            {
                return false;
            }

            if (currentNode.Value != _frontPointer.Value)
            {
                return false;
            }

            _frontPointer = _frontPointer.Next;
        }

        return true;
    }

    private static bool IsPalindromeWithTwoPointers(ListNode head)
    {
        List<int> values = new List<int>();

        ListNode currentNode = head;

        while (currentNode != null)
        {
            values.Add(currentNode.Value);

            currentNode = currentNode.Next;
        }

        int front = 0;
        int back = values.Count - 1;

        while (front < back)
        {
            if (values[front] != values[back])
            {
                return false;
            }

            front++;
            back--;
        }

        return true;
    }
}