using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class RemoveNthNodeFromEndOfListProblemTests
{
    [Fact]
    public void RemoveNthFromEnd_TestCase_1()
    {
        // Arrange
        int[] head = [1, 2, 3, 4, 5];
        int n = 2;

        ListNode headNode = head.CreateLinkedList();

        RemoveNthNodeFromEndOfListProblem removeNthNodeFromEndOfListProblem = new RemoveNthNodeFromEndOfListProblem();

        // Act
        ListNode actual = removeNthNodeFromEndOfListProblem.RemoveNthFromEnd(headNode, n);

        // Assert
        actual.AssertLinkedList([1, 2, 3, 5]);
    }

    [Fact]
    public void RemoveNthFromEnd_TestCase_2()
    {
        // Arrange
        int[] head = [1];
        int n = 1;

        ListNode headNode = head.CreateLinkedList();

        RemoveNthNodeFromEndOfListProblem removeNthNodeFromEndOfListProblem = new RemoveNthNodeFromEndOfListProblem();

        // Act
        ListNode actual = removeNthNodeFromEndOfListProblem.RemoveNthFromEnd(headNode, n);

        // Assert
        actual.AssertLinkedList([]);
    }

    [Fact]
    public void RemoveNthFromEnd_TestCase_3()
    {
        // Arrange
        int[] head = [1, 2];
        int n = 1;

        ListNode headNode = head.CreateLinkedList();

        RemoveNthNodeFromEndOfListProblem removeNthNodeFromEndOfListProblem = new RemoveNthNodeFromEndOfListProblem();

        // Act
        ListNode actual = removeNthNodeFromEndOfListProblem.RemoveNthFromEnd(headNode, n);

        // Assert
        actual.AssertLinkedList([1]);
    }
}