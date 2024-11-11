using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class PascalsTriangle2ProblemTests
{
    [Fact]
    public void GetRow_TestCase_1()
    {
        // Arrange
        int rowIndex = 3;

        PascalsTriangle2Problem pascalsTriangle2Problem = new PascalsTriangle2Problem();

        // Act
        IList<int> actual = pascalsTriangle2Problem.GetRow(rowIndex);

        // Assert
        actual.Should().BeEquivalentTo([1, 3, 3, 1], options => options.WithStrictOrdering());
    }

    [Fact]
    public void GetRow_TestCase_2()
    {
        // Arrange
        int rowIndex = 0;

        PascalsTriangle2Problem pascalsTriangle2Problem = new PascalsTriangle2Problem();

        // Act
        IList<int> actual = pascalsTriangle2Problem.GetRow(rowIndex);

        // Assert
        actual.Should().BeEquivalentTo([1], options => options.WithStrictOrdering());
    }

    [Fact]
    public void GetRow_TestCase_3()
    {
        // Arrange
        int rowIndex = 1;

        PascalsTriangle2Problem pascalsTriangle2Problem = new PascalsTriangle2Problem();

        // Act
        IList<int> actual = pascalsTriangle2Problem.GetRow(rowIndex);

        // Assert
        actual.Should().BeEquivalentTo([1, 1], options => options.WithStrictOrdering());
    }
}