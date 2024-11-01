using FluentAssertions;
using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class AllOneProblemTests
{
    [Fact]
    public void AllOne_TestCase_1()
    {
        // Arrange
        AllOneProblem.AllOne allOne = new AllOneProblem.AllOne();

        // Act/Assert
        allOne.Inc("hello");
        allOne.Inc("hello");

        allOne.GetMaxKey().Should().Be("hello");
        allOne.GetMinKey().Should().Be("hello");

        allOne.Inc("leet");

        allOne.GetMaxKey().Should().Be("hello");
        allOne.GetMinKey().Should().Be("leet");

        allOne.Inc("leet");
        allOne.Inc("leet");
        allOne.Inc("leet");

        allOne.GetMaxKey().Should().Be("leet");
        allOne.GetMinKey().Should().Be("hello");

        allOne.Dec("hello");
        allOne.Dec("hello");
        allOne.Dec("hello");

        allOne.GetMaxKey().Should().Be("leet");
        allOne.GetMinKey().Should().Be("leet");
    }

    [Fact]
    public void AllOne_TestCase_2()
    {
        // Arrange
        AllOneProblem.AllOne allOne = new AllOneProblem.AllOne();

        // Act/Assert
        allOne.Inc("a");
        allOne.Inc("b");
        allOne.Inc("c");
        allOne.Inc("d");
        allOne.Inc("e");
        allOne.Inc("f");
        allOne.Inc("g");
        allOne.Inc("h");
        allOne.Inc("i");
        allOne.Inc("j");
        allOne.Inc("k");
        allOne.Inc("l");

        allOne.Dec("a");
        allOne.Dec("b");
        allOne.Dec("c");
        allOne.Dec("d");
        allOne.Dec("e");
        allOne.Dec("f");

        allOne.Inc("g");
        allOne.Inc("h");
        allOne.Inc("i");
        allOne.Inc("j");

        allOne.GetMaxKey().Should().Be("g");
        allOne.GetMinKey().Should().Be("k");

        allOne.Inc("k");
        allOne.Inc("l");

        allOne.GetMaxKey().Should().Be("g");
        allOne.GetMinKey().Should().Be("g");

        allOne.Inc("a");
        allOne.Dec("j");

        allOne.GetMaxKey().Should().Be("g");
        allOne.GetMinKey().Should().Be("a");
    }
}