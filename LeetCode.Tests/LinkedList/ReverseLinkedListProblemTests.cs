using LeetCode.Problems.Data;
using LeetCode.Problems;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class ReverseLinkedListProblemTests
{
    [Fact]
    public void ReverseList_TestCase_1()
    {
        // Arrange
        int[] numberArray = [1, 2, 3, 4, 5];

        ListNode headNode = numberArray.CreateLinkedList();

        ReverseLinkedListProblem reverseLinkedListProblem = new ReverseLinkedListProblem();

        // Act
        var actual = reverseLinkedListProblem.ReverseList(headNode);

        // Assert
        actual.AssertLinkedList([5, 4, 3, 2, 1]);
    }

    [Fact]
    public void ReverseList_TestCase_2()
    {
        // Arrange
        int[] numberArray = [1, 2];

        ListNode headNode = numberArray.CreateLinkedList();

        ReverseLinkedListProblem reverseLinkedListProblem = new ReverseLinkedListProblem();

        // Act
        var actual = reverseLinkedListProblem.ReverseList(headNode);

        // Assert
        actual.AssertLinkedList([2, 1]);
    }
}