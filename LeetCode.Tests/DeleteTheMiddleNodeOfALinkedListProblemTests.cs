using LeetCode.Problems;
using LeetCode.Problems.Data;
using LeetCode.Tests.Utilities;

namespace LeetCode.Tests;

public class DeleteTheMiddleNodeOfALinkedListProblemTests
{
    [Fact]
    public void DeleteMiddle_TestCase_1()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([1, 3, 4, 7, 1, 2, 6]);

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [1, 3, 4, 1, 2, 6]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_2()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([1, 2, 3, 4]);

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [1, 2, 4]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_3()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([2, 1]);

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [2]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_4()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([2]);

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, []);
    }
}