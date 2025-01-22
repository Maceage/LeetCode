using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class ApiRateLimiterTests
{
    [Fact]
    public void RateLimit_TestCase_1()
    {
        DateTime dateTime = DateTime.Now;

        // Arrange
        ApiRateLimiter apiRateLimiter = new ApiRateLimiter(60, 5);

        // Act/Assert
        apiRateLimiter.RateLimit(123, dateTime).Should().BeFalse();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(10)).Should().BeFalse();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(20)).Should().BeFalse();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(30)).Should().BeFalse();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(40)).Should().BeFalse();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(50)).Should().BeTrue();
        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(60)).Should().BeTrue();

        apiRateLimiter.RateLimit(123, dateTime.AddSeconds(70)).Should().BeTrue();
    }
}