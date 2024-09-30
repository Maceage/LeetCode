using FluentAssertions;
using LeetCode.Problems.Data;

namespace LeetCode.Tests.Utilities;

public class ListNodeUtilities
{
    public static ListNode CreateLinkedList(int[] nodeValues)
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

    public static void AssertLinkedList(ListNode headNode, int[] expectedNodeValues)
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
    }
}