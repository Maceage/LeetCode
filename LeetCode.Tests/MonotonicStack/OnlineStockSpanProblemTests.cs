using FluentAssertions;
using LeetCode.Problems.MonotonicStack;

namespace LeetCode.Tests.MonotonicStack;

public class OnlineStockSpanProblemTests
{
    [Fact]
    public void StockSpanner_TestCase_1()
    {
        // Arrange
        OnlineStockSpanProblem.StockSpanner stockSpanner = new OnlineStockSpanProblem.StockSpanner();

        // Act/Assert
        stockSpanner.Next(100).Should().Be(1);
        stockSpanner.Next(80).Should().Be(1);
        stockSpanner.Next(60).Should().Be(1);
        stockSpanner.Next(70).Should().Be(2);
        stockSpanner.Next(60).Should().Be(1);
        stockSpanner.Next(75).Should().Be(4);
        stockSpanner.Next(85).Should().Be(6);
    }
}