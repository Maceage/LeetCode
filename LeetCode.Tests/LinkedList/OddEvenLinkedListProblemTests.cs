using LeetCode.Problems;
using LeetCode.Problems.Data;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class OddEvenLinkedListProblemTests
{
    [Fact]
    public void OddEvenList_TestCase_1()
    {
        // Arrange
        int[] numberArray = [1, 2, 3, 4, 5];

        ListNode headNode = numberArray.CreateLinkedList();

        OddEvenLinkedListProblem oddEvenLinkedListProblem = new OddEvenLinkedListProblem();

        // Act
        ListNode actual = oddEvenLinkedListProblem.OddEvenList(headNode);

        // Assert
        actual.AssertLinkedList([1, 3, 5, 2, 4]);
    }

    [Fact]
    public void OddEvenList_TestCase_2()
    {
        // Arrange
        int[] numberArray = [2, 1, 3, 5, 6, 4, 7];

        ListNode headNode = numberArray.CreateLinkedList();

        OddEvenLinkedListProblem oddEvenLinkedListProblem = new OddEvenLinkedListProblem();

        // Act
        ListNode actual = oddEvenLinkedListProblem.OddEvenList(headNode);

        // Assert
        actual.AssertLinkedList([2, 3, 6, 7, 1, 5, 4]);
    }
}