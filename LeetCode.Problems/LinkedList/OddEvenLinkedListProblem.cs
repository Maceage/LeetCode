using LeetCode.Problems.Data;

namespace LeetCode.Problems;

public class OddEvenLinkedListProblem
{
    public ListNode OddEvenList(ListNode head)
    {
        return OddEvenListPointers(head);
        return OddEvenListQueue(head);
    }

    private static ListNode OddEvenListPointers(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode oddNode = head;
        ListNode evenNode = head.Next;
        ListNode evenHeadNode = evenNode;

        while (evenNode != null && evenNode.Next != null)
        {
            oddNode.Next = evenNode.Next;
            oddNode = oddNode.Next;

            evenNode.Next = oddNode.Next;
            evenNode = evenNode.Next;
        }

        oddNode.Next = evenHeadNode;
        return head;
    }

    private static ListNode OddEvenListQueue(ListNode head)
    {
        if ((head != null) && (head.Next != null))
        {
            int currentIndex = 0;

            ListNode current = head;

            Queue<ListNode> oddNodes = new Queue<ListNode>();
            Queue<ListNode> evenNodes = new Queue<ListNode>();

            while (current != null)
            {
                if (currentIndex % 2 == 0)
                {
                    evenNodes.Enqueue(current);
                }
                else
                {
                    oddNodes.Enqueue(current);
                }

                current = current.Next;
                currentIndex++;
            }

            ListNode newHead = evenNodes.Dequeue();

            while (evenNodes.TryDequeue(out current))
            {
                newHead.Next = current;
                current.Next = null;
                newHead = current;
            }

            while (oddNodes.TryDequeue(out current))
            {
                newHead.Next = current;
                current.Next = null;
                newHead = current;
            }
        }

        return head;
    }
}