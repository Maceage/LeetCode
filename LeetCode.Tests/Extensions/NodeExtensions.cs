using FluentAssertions;
using LeetCode.Problems.Data;

namespace LeetCode.Tests.Extensions;

public static class NodeExtensions
{
    public static Node CreateMultilevelDoublyLinkedList(this int?[] nodeValues)
    {
        Node headNode = null;

        if (nodeValues.Length > 0)
        {
            headNode = new Node(nodeValues[0]!.Value);

            Node nextNode = new Node();
            Node currentNode = headNode;
            Node levelStartNode = headNode;

            for (int i = 1; i < nodeValues.Length; i++)
            {
                bool wasPreviousNull = nodeValues[i - 1]!.HasValue;

                if (nodeValues[i].HasValue)
                {
                    nextNode.Value = nodeValues[i]!.Value;

                    if (wasPreviousNull)
                    {
                        currentNode.Next = nextNode;
                        nextNode.Previous = currentNode;
                    }
                    else
                    {
                        currentNode.Child = nextNode;
                        levelStartNode = nextNode;
                    }

                    currentNode = nextNode;

                    nextNode = new Node();
                }
                else
                {
                    currentNode = wasPreviousNull ? levelStartNode : currentNode.Next;
                }
            }
        }

        return headNode;
    }

    public static void AssertDoublyLinkedList(this Node headNode, int[] expectedNodeValues)
    {
        int i = 0;

        Node currentNode = headNode;

        if (expectedNodeValues.Length > 0)
        {
            while (currentNode != null)
            {
                int current = expectedNodeValues[i];

                currentNode.Value.Should().Be(current);

                currentNode = currentNode.Next;
                i++;
            }

            i.Should().Be(expectedNodeValues.Length);
        }
        else
        {
            headNode.Should().BeNull();
        }
    }
}