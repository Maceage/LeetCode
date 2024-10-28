using FluentAssertions;
using LeetCode.Problems.Heap;

namespace LeetCode.Tests.Heap;

public class SmallestNumberInInfiniteSetProblemTests
{
    [Fact]
    public void SmallestInfiniteSet_TestCase_1()
    {
        // Arrange
        SmallestNumberInInfiniteSetProblem.SmallestInfiniteSetPriorityQueueHashSet smallestInfiniteSetPriorityQueueHashSet = new SmallestNumberInInfiniteSetProblem.SmallestInfiniteSetPriorityQueueHashSet();

        // Act/Assert
        smallestInfiniteSetPriorityQueueHashSet.AddBack(2);

        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(1);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(2);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(3);

        smallestInfiniteSetPriorityQueueHashSet.AddBack(1);

        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(1);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(4);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(5);
    }

    [Fact]
    public void SmallestInfiniteSet_TestCase_2()
    {
        // Arrange
        SmallestNumberInInfiniteSetProblem.SmallestInfiniteSetSortedSet smallestInfiniteSetPriorityQueueHashSet = new SmallestNumberInInfiniteSetProblem.SmallestInfiniteSetSortedSet();

        // Act/Assert
        smallestInfiniteSetPriorityQueueHashSet.AddBack(2);

        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(1);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(2);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(3);

        smallestInfiniteSetPriorityQueueHashSet.AddBack(1);

        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(1);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(4);
        smallestInfiniteSetPriorityQueueHashSet.PopSmallest().Should().Be(5);
    }
}