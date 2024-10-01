using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Tests.Extensions;
using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class MaximumTwinSumOfALinkedListProblemTests
{
    [Fact]
    public void PairSum_TestCase_1()
    {
        // Arrange
        int[] numberArray = [5, 4, 2, 1];

        ListNode headNode = numberArray.CreateLinkedList();

        MaximumTwinSumOfALinkedListProblem maximumTwinSumOfALinkedListProblem = new MaximumTwinSumOfALinkedListProblem();

        // Act
        var actual = maximumTwinSumOfALinkedListProblem.PairSum(headNode);

        // Assert
        actual.Should().Be(6);
    }

    [Fact]
    public void PairSum_TestCase_2()
    {
        // Arrange
        int[] numberArray = [4, 2, 2, 3];

        ListNode headNode = numberArray.CreateLinkedList();

        MaximumTwinSumOfALinkedListProblem maximumTwinSumOfALinkedListProblem = new MaximumTwinSumOfALinkedListProblem();

        // Act
        var actual = maximumTwinSumOfALinkedListProblem.PairSum(headNode);

        // Assert
        actual.Should().Be(7);
    }

    [Fact]
    public void PairSum_TestCase_3()
    {
        // Arrange
        int[] numberArray = [1, 10000];

        ListNode headNode = numberArray.CreateLinkedList();

        MaximumTwinSumOfALinkedListProblem maximumTwinSumOfALinkedListProblem = new MaximumTwinSumOfALinkedListProblem();

        // Act
        var actual = maximumTwinSumOfALinkedListProblem.PairSum(headNode);

        // Assert
        actual.Should().Be(10001);
    }

    [Fact]
    public void PairSum_TestCase_4()
    {
        // Arrange
        int[] numberArray = [5, 4, 2, 1, 1, 2, 4, 5];

        ListNode headNode = numberArray.CreateLinkedList();

        MaximumTwinSumOfALinkedListProblem maximumTwinSumOfALinkedListProblem = new MaximumTwinSumOfALinkedListProblem();

        // Act
        var actual = maximumTwinSumOfALinkedListProblem.PairSum(headNode);

        // Assert
        actual.Should().Be(10);
    }
}