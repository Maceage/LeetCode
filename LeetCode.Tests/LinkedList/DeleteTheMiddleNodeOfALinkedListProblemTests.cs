using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class DeleteTheMiddleNodeOfALinkedListProblemTests
{
    [Fact]
    public void DeleteMiddle_TestCase_1()
    {
        // Arrange
        int[] numberArray = [1, 3, 4, 7, 1, 2, 6];

        ListNode headNode = numberArray.CreateLinkedList();

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        actual.AssertLinkedList([1, 3, 4, 1, 2, 6]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_2()
    {
        // Arrange
        int[] numberArray = [1, 2, 3, 4];

        ListNode headNode = numberArray.CreateLinkedList();

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        actual.AssertLinkedList([1, 2, 4]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_3()
    {
        // Arrange
        int[] numberArray = [2, 1];

        ListNode headNode = numberArray.CreateLinkedList();

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        actual.AssertLinkedList([2]);
    }

    [Fact]
    public void DeleteMiddle_TestCase_4()
    {
        // Arrange
        int[] numberArray = [2];

        ListNode headNode = numberArray.CreateLinkedList();

        DeleteTheMiddleNodeOfALinkedListProblem deleteTheMiddleNodeOfALinkedListProblem = new DeleteTheMiddleNodeOfALinkedListProblem();

        // Act
        var actual = deleteTheMiddleNodeOfALinkedListProblem.DeleteMiddle(headNode);

        // Assert
        actual.AssertLinkedList([]);
    }
}