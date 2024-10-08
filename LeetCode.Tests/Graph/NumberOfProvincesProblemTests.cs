using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class NumberOfProvincesProblemTests
{
    [Fact]
    public void FindCircleNum_TestCase_1()
    {
        // Arrange
        int[][] isConnected = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
        int expected = 2;

        NumberOfProvincesProblem numberOfProvincesProblem = new NumberOfProvincesProblem();

        // Act
        int actual = numberOfProvincesProblem.FindCircleNum(isConnected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void FindCircleNum_TestCase_2()
    {
        // Arrange
        int[][] isConnected = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
        int expected = 3;

        NumberOfProvincesProblem numberOfProvincesProblem = new NumberOfProvincesProblem();

        // Act
        int actual = numberOfProvincesProblem.FindCircleNum(isConnected);

        // Assert
        actual.Should().Be(expected);
    }
}