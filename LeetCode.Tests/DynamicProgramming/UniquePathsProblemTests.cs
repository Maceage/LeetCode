using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class UniquePathsProblemTests
{
    [Fact]
    public void UniquePaths_TestCase_1()
    {
        // Arrange
        int m = 3;
        int n = 7;

        UniquePathsProblem uniquePathsProblem = new UniquePathsProblem();

        // Act
        int actual = uniquePathsProblem.UniquePaths(m, n);

        // Assert
        actual.Should().Be(28);
    }

    [Fact]
    public void UniquePaths_TestCase_2()
    {
        // Arrange
        int m = 3;
        int n = 2;

        UniquePathsProblem uniquePathsProblem = new UniquePathsProblem();

        // Act
        int actual = uniquePathsProblem.UniquePaths(m, n);

        // Assert
        actual.Should().Be(3);
    }
}