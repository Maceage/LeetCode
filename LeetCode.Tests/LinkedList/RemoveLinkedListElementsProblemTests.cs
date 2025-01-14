using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class RemoveLinkedListElementsProblemTests
{
    [Fact]
    public void RemoveElements_TestCase_1()
    {
        // Arrange
        int[] head = [1, 2, 6, 3, 4, 5, 6];
        int val = 6;

        ListNode headNode = head.CreateLinkedList();

        RemoveLinkedListElementsProblem removeLinkedListElementsProblem = new RemoveLinkedListElementsProblem();

        // Act
        ListNode actual = removeLinkedListElementsProblem.RemoveElements(headNode, val);

        // Assert
        actual.AssertLinkedList([1, 2, 3, 4, 5]);
    }

    [Fact]
    public void RemoveElements_TestCase_2()
    {
        // Arrange
        int[] head = [];
        int val = 1;

        ListNode headNode = head.CreateLinkedList();

        RemoveLinkedListElementsProblem removeLinkedListElementsProblem = new RemoveLinkedListElementsProblem();

        // Act
        ListNode actual = removeLinkedListElementsProblem.RemoveElements(headNode, val);

        // Assert
        actual.AssertLinkedList([]);
    }

    [Fact]
    public void RemoveElements_TestCase_3()
    {
        // Arrange
        int[] head = [7, 7, 7, 7];
        int val = 7;

        ListNode headNode = head.CreateLinkedList();

        RemoveLinkedListElementsProblem removeLinkedListElementsProblem = new RemoveLinkedListElementsProblem();

        // Act
        ListNode actual = removeLinkedListElementsProblem.RemoveElements(headNode, val);

        // Assert
        actual.AssertLinkedList([]);
    }
}