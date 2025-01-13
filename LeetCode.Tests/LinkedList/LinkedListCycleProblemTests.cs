using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class LinkedListCycleProblemTests
{
    [Fact]
    public void HasCycle_TestCase_1()
    {
        // Arrange
        int[] head = [3, 2, 0, -4];
        int position = 1;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        LinkedListCycleProblem linkedListCycleProblem = new LinkedListCycleProblem();

        // Act/Assert
        linkedListCycleProblem.HasCycle(headNode).Should().BeTrue();
    }

    [Fact]
    public void HasCycle_TestCase_2()
    {
        // Arrange
        int[] head = [1, 2];
        int position = 0;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        LinkedListCycleProblem linkedListCycleProblem = new LinkedListCycleProblem();

        // Act/Assert
        linkedListCycleProblem.HasCycle(headNode).Should().BeTrue();
    }

    [Fact]
    public void HasCycle_TestCase_3()
    {
        // Arrange
        int[] head = [1];
        int position = -1;

        ListNode headNode = head.CreateLinkedListWithCycle(position);

        LinkedListCycleProblem linkedListCycleProblem = new LinkedListCycleProblem();

        // Act/Assert
        linkedListCycleProblem.HasCycle(headNode).Should().BeFalse();
    }
}