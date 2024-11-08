using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class RemoveElementProblemTests
{
    [Fact]
    public void RemoveElement_TestCase_1()
    {
        // Arrange
        int[] nums = [3, 2, 2, 3];
        int val = 3;

        int[] expected = [2, 2];

        RemoveElementProblem removeElementProblem = new RemoveElementProblem();

        // Act
        int actual = removeElementProblem.RemoveElement(nums, val);

        // Assert
        actual.Should().Be(expected.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            nums[i].Should().Be(expected[i]);
        }
    }

    [Fact]
    public void RemoveElement_TestCase_2()
    {
        // Arrange
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        int val = 2;

        int[] expected = [0, 1, 3, 0, 4];

        RemoveElementProblem removeElementProblem = new RemoveElementProblem();

        // Act
        int actual = removeElementProblem.RemoveElement(nums, val);

        // Assert
        actual.Should().Be(expected.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            nums[i].Should().Be(expected[i]);
        }
    }
}