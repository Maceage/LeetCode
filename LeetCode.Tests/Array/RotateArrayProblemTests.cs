using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class RotateArrayProblemTests
{
    [Fact]
    public void Rotate_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        int k = 3;

        RotateArrayProblem rotateArrayProblem = new RotateArrayProblem();

        // Act
        rotateArrayProblem.Rotate(nums, k);

        // Assert
        nums.Should().BeEquivalentTo([5, 6, 7, 1, 2, 3, 4], options => options.WithStrictOrdering());
    }

    [Fact]
    public void Rotate_TestCase_2()
    {
        // Arrange
        int[] nums = [-1, -100, 3, 99];
        int k = 2;

        RotateArrayProblem rotateArrayProblem = new RotateArrayProblem();

        // Act
        rotateArrayProblem.Rotate(nums, k);

        // Assert
        nums.Should().BeEquivalentTo([3, 99, -1, -100], options => options.WithStrictOrdering());
    }

    [Fact]
    public void Rotate_TestCase_3()
    {
        // Arrange
        int[] nums = [-1];
        int k = 3;

        RotateArrayProblem rotateArrayProblem = new RotateArrayProblem();

        // Act
        rotateArrayProblem.Rotate(nums, k);

        // Assert
        nums.Should().BeEquivalentTo([-1], options => options.WithStrictOrdering());
    }
}