using LeetCode.Problems.Data;
using LeetCode.Problems;
using LeetCode.Tests.Utilities;

namespace LeetCode.Tests;

public class ReverseLinkedListProblemTests
{
    [Fact]
    public void ReverseList_TestCase_1()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([1, 2, 3, 4, 5]);

        ReverseLinkedListProblem reverseLinkedListProblem = new ReverseLinkedListProblem();

        // Act
        var actual = reverseLinkedListProblem.ReverseList(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [5, 4, 3, 2, 1]);
    }

    [Fact]
    public void ReverseList_TestCase_2()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([1, 2]);

        ReverseLinkedListProblem reverseLinkedListProblem = new ReverseLinkedListProblem();

        // Act
        var actual = reverseLinkedListProblem.ReverseList(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [2, 1]);
    }
}