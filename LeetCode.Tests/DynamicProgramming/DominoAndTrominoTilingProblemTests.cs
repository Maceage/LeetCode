using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class DominoAndTrominoTilingProblemTests
{
    [Fact]
    public void NumTilings_TestCase_1()
    {
        // Arrange
        int n = 3;

        DominoAndTrominoTilingProblem dominoAndTrominoTilingProblem = new DominoAndTrominoTilingProblem();

        // Act
        int actual = dominoAndTrominoTilingProblem.NumTilings(n);

        // Assert
        actual.Should().Be(5);
    }

    [Fact]
    public void NumTilings_TestCase_2()
    {
        // Arrange
        int n = 1;

        DominoAndTrominoTilingProblem dominoAndTrominoTilingProblem = new DominoAndTrominoTilingProblem();

        // Act
        int actual = dominoAndTrominoTilingProblem.NumTilings(n);

        // Assert
        actual.Should().Be(1);
    }
}