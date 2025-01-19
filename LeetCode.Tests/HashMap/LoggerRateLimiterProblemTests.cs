using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class LoggerRateLimiterProblemTests
{
    [Fact]
    public void Logger_TestCase_1()
    {
        // Arrange
        LoggerRateLimiterProblem.Logger logger = new LoggerRateLimiterProblem.Logger();

        // Act/Assert
        logger.ShouldPrintMessage(1, "foo").Should().BeTrue();
        logger.ShouldPrintMessage(2, "bar").Should().BeTrue();
        logger.ShouldPrintMessage(3, "foo").Should().BeFalse();
        logger.ShouldPrintMessage(8, "bar").Should().BeFalse();
        logger.ShouldPrintMessage(10, "foo").Should().BeFalse();
        logger.ShouldPrintMessage(11, "foo").Should().BeTrue();
    }
}