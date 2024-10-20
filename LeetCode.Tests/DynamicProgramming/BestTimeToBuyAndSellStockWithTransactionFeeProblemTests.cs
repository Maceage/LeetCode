using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class BestTimeToBuyAndSellStockWithTransactionFeeProblemTests
{
    [Fact]
    public void MaxProfit_TestCase_1()
    {
        // Arrange
        int[] prices = [1, 3, 2, 8, 4, 9];
        int fee = 2;

        BestTimeToBuyAndSellStockWithTransactionFeeProblem bestTimeToBuyAndSellStockWithTransactionFeeProblem = new BestTimeToBuyAndSellStockWithTransactionFeeProblem();

        // Act
        int actual = bestTimeToBuyAndSellStockWithTransactionFeeProblem.MaxProfit(prices, fee);

        // Assert
        actual.Should().Be(8);
    }

    [Fact]
    public void MaxProfit_TestCase_3()
    {
        // Arrange
        int[] prices = [1, 3, 7, 5, 10, 3];
        int fee = 3;

        BestTimeToBuyAndSellStockWithTransactionFeeProblem bestTimeToBuyAndSellStockWithTransactionFeeProblem = new BestTimeToBuyAndSellStockWithTransactionFeeProblem();

        // Act
        int actual = bestTimeToBuyAndSellStockWithTransactionFeeProblem.MaxProfit(prices, fee);

        // Assert
        actual.Should().Be(6);
    }
}