using LeetCode.Problems;
using LeetCode.Problems.Data;
using LeetCode.Tests.Utilities;

namespace LeetCode.Tests;

public class OddEvenLinkedListProblemTests
{
    [Fact]
    public void OddEvenList_TestCase_1()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([1, 2, 3, 4, 5]);

        OddEvenLinkedListProblem oddEvenLinkedListProblem = new OddEvenLinkedListProblem();

        // Act
        ListNode actual = oddEvenLinkedListProblem.OddEvenList(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [1, 3, 5, 2, 4]);
    }

    [Fact]
    public void OddEvenList_TestCase_2()
    {
        // Arrange
        ListNode headNode = ListNodeUtilities.CreateLinkedList([2, 1, 3, 5, 6, 4, 7]);

        OddEvenLinkedListProblem oddEvenLinkedListProblem = new OddEvenLinkedListProblem();

        // Act
        ListNode actual = oddEvenLinkedListProblem.OddEvenList(headNode);

        // Assert
        ListNodeUtilities.AssertLinkedList(actual, [2, 3, 6, 7, 1, 5, 4]);
    }
}