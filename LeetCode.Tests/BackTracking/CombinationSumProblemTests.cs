using FluentAssertions;
using LeetCode.Problems.Backtracking;

namespace LeetCode.Tests.BackTracking;

public class CombinationSumProblemTests
{
    [Fact]
    public void CombinationSum3_TestCase_1()
    {
        // Arrange
        int k = 3;
        int n = 7;

        IList<IList<int>> expected = new List<IList<int>>
        {
            { [1, 2, 4] }
        };

        CombinationSumProblem combinationSumProblem = new CombinationSumProblem();

        // Act
        IList<IList<int>> actual = combinationSumProblem.CombinationSum3(k, n);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void CombinationSum3_TestCase_2()
    {
        // Arrange
        int k = 3;
        int n = 9;

        IList<IList<int>> expected = new List<IList<int>>
        {
            { [1, 2, 6] },
            { [1, 3, 5] },
            { [2, 3, 4] }
        };

        CombinationSumProblem combinationSumProblem = new CombinationSumProblem();

        // Act
        IList<IList<int>> actual = combinationSumProblem.CombinationSum3(k, n);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void CombinationSum3_TestCase_3()
    {
        // Arrange
        int k = 4;
        int n = 1;

        CombinationSumProblem combinationSumProblem = new CombinationSumProblem();

        // Act
        IList<IList<int>> actual = combinationSumProblem.CombinationSum3(k, n);

        // Assert
        actual.Should().BeEquivalentTo(new List<IList<int>>(), options => options.WithStrictOrdering());
    }
}