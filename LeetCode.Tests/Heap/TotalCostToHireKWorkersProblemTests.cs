using FluentAssertions;
using LeetCode.Problems.Heap;

namespace LeetCode.Tests.Heap;

public class TotalCostToHireKWorkersProblemTests
{
    [Fact]
    public void TotalCost_TestCase_1()
    {
        // Arrange
        int[] costs = [17, 12, 10, 2, 7, 2, 11, 20, 8];
        int k = 3;
        int candidates = 4;

        TotalCostToHireKWorkersProblem totalCostToHireKWorkersProblem = new TotalCostToHireKWorkersProblem();

        // Act
        long actual = totalCostToHireKWorkersProblem.TotalCost(costs, k, candidates);

        // Assert
        actual.Should().Be(11);
    }

    [Fact]
    public void TotalCost_TestCase_2()
    {
        // Arrange
        int[] costs = [1, 2, 4, 1];
        int k = 3;
        int candidates = 3;

        TotalCostToHireKWorkersProblem totalCostToHireKWorkersProblem = new TotalCostToHireKWorkersProblem();

        // Act
        long actual = totalCostToHireKWorkersProblem.TotalCost(costs, k, candidates);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void TotalCost_TestCase_3()
    {
        // Arrange
        int[] costs = [18, 64, 12, 21, 21, 78, 36, 58, 88, 58, 99, 26, 92, 91, 53, 10, 24, 25, 20, 92, 73, 63, 51, 65, 87, 6, 17, 32, 14, 42, 46, 65, 43, 9, 75];
        int k = 13;
        int candidates = 23;

        TotalCostToHireKWorkersProblem totalCostToHireKWorkersProblem = new TotalCostToHireKWorkersProblem();

        // Act
        long actual = totalCostToHireKWorkersProblem.TotalCost(costs, k, candidates);

        // Assert
        actual.Should().Be(223);
    }
}