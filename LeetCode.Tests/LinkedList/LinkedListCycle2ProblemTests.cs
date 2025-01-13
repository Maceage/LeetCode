using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class LinkedListCycle2ProblemTests
{
    [Fact]
    public void DetectCycle_TestCase_1()
    {
        // Arrange
        int[] head = [3, 2, 0, -4];
        int position = 1;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        ListNode expected = GetAtIndex(headNode, position);

        LinkedListCycle2Problem linkedListCycle2Problem = new LinkedListCycle2Problem();

        // Act
        ListNode actual = linkedListCycle2Problem.DetectCycle(headNode);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void DetectCycle_TestCase_2()
    {
        // Arrange
        int[] head = [1, 2];
        int position = 0;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        ListNode expected = GetAtIndex(headNode, position);

        LinkedListCycle2Problem linkedListCycle2Problem = new LinkedListCycle2Problem();

        // Act
        ListNode actual = linkedListCycle2Problem.DetectCycle(headNode);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void DetectCycle_TestCase_3()
    {
        // Arrange
        int[] head = [1];
        int position = -1;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        ListNode expected = GetAtIndex(headNode, position);

        LinkedListCycle2Problem linkedListCycle2Problem = new LinkedListCycle2Problem();

        // Act
        ListNode actual = linkedListCycle2Problem.DetectCycle(headNode);

        // Assert
        actual.Should().Be(expected);
    }

    private static ListNode GetAtIndex(ListNode headNode, int index)
    {
        ListNode listNode = null;

        if (index >= 0)
        {
            listNode = headNode;

            for (int i = 0; i < index; i++)
            {
                listNode = listNode.Next;
            }
        }

        return listNode;
    }
}