using FluentAssertions;
using LeetCode.Problems.Heap;

namespace LeetCode.Tests.Heap;

public class SmallestNumberInInfiniteSetProblemTests
{
    [Fact]
    public void SmallestInfiniteSet_TestCase_1()
    {
        // Arrange
        SmallestNumberInInfiniteSetProblem.SmallestInfiniteSet smallestInfiniteSet = new SmallestNumberInInfiniteSetProblem.SmallestInfiniteSet();

        // Act/Assert
        smallestInfiniteSet.AddBack(2);

        smallestInfiniteSet.PopSmallest().Should().Be(1);
        smallestInfiniteSet.PopSmallest().Should().Be(2);
        smallestInfiniteSet.PopSmallest().Should().Be(3);

        smallestInfiniteSet.AddBack(1);

        smallestInfiniteSet.PopSmallest().Should().Be(1);
        smallestInfiniteSet.PopSmallest().Should().Be(4);
        smallestInfiniteSet.PopSmallest().Should().Be(5);
    }
}