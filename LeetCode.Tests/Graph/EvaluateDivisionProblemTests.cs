using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class EvaluateDivisionProblemTests
{
    [Fact]
    public void CalcEquation_TestCase_1()
    {
        // Arrange
        IList<IList<string>> equations = [["a", "b"], ["b", "c"]];
        double[] values = [2.0, 3.0];
        IList<IList<string>> queries = [["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"]];

        double[] expected = [6.00000, 0.50000, -1.00000, 1.00000, -1.00000];

        EvaluateDivisionProblem evaluateDivisionProblem = new EvaluateDivisionProblem();

        // Act
        double[] actual = evaluateDivisionProblem.CalcEquation(equations, values, queries);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void CalcEquation_TestCase_2()
    {
        // Arrange
        IList<IList<string>> equations = [["a", "b"], ["b", "c"], ["bc", "cd"]];
        double[] values = [1.5, 2.5, 5.0];
        IList<IList<string>> queries = [["a", "c"], ["c", "b"], ["bc", "cd"], ["cd", "bc"]];

        double[] expected = [3.75000, 0.40000, 5.00000, 0.20000];

        EvaluateDivisionProblem evaluateDivisionProblem = new EvaluateDivisionProblem();

        // Act
        double[] actual = evaluateDivisionProblem.CalcEquation(equations, values, queries);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void CalcEquation_TestCase_3()
    {
        // Arrange
        IList<IList<string>> equations = [["a", "b"]];
        double[] values = [0.5];
        IList<IList<string>> queries = [["a", "b"], ["b", "a"], ["a", "c"], ["x", "y"]];

        double[] expected = [0.50000, 2.00000, -1.00000, -1.00000];

        EvaluateDivisionProblem evaluateDivisionProblem = new EvaluateDivisionProblem();

        // Act
        double[] actual = evaluateDivisionProblem.CalcEquation(equations, values, queries);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}