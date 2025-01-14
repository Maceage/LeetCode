using FluentAssertions;
using LeetCode.Problems.Data;

namespace LeetCode.Tests.Extensions;

public static class ListNodeExtensions
{
    public static ListNode CreateLinkedList(this int[] nodeValues)
    {
        ListNode headNode = new ListNode();

        if (nodeValues.Length > 0)
        {
            headNode.Value = nodeValues[0];

            ListNode nextNode = new ListNode();
            ListNode currentNode = headNode;

            for (int i = 1; i < nodeValues.Length; i++)
            {
                nextNode.Value = nodeValues[i];
                currentNode.Next = nextNode;

                currentNode = nextNode;
                nextNode = new ListNode();
            }
        }

        return headNode;
    }

    public static ListNode CreateLinkedListWithCycle(this int[] nodes, int position)
    {
        ListNode headNode = nodes.CreateLinkedList();

        if (position >= 0)
        {
            ListNode listNode = headNode;

            for (int i = 0; i < position; i++)
            {
                listNode = headNode.Next;
            }

            ListNode current = headNode;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = listNode;
        }

        return headNode;
    }

    public static void AssertLinkedList(this ListNode headNode, int[] expectedNodeValues)
    {
        int i = 0;

        ListNode currentNode = headNode;

        while (currentNode != null)
        {
            int current = expectedNodeValues[i];

            currentNode.Value.Should().Be(current);

            currentNode = currentNode.Next;
            i++;
        }

        i.Should().Be(expectedNodeValues.Length);
    }

    public static ListNode GetNodeAt(this ListNode headNode, int skipCount)
    {
        ListNode listNode = headNode;

        for (int i = 0; i < skipCount - 1; ++i)
        {
            listNode = listNode.Next;
        }

        return listNode;
    }
}