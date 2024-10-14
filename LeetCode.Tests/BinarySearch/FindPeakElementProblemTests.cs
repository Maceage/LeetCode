using FluentAssertions;
using LeetCode.Problems.BinarySearch;

namespace LeetCode.Tests.BinarySearch;

public class FindPeakElementProblemTests
{
    [Fact]
    public void FindPeakElement_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1];

        FindPeakElementProblem findPeakElementProblem = new FindPeakElementProblem();

        // Act
        int actual = findPeakElementProblem.FindPeakElement(nums);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void FindPeakElement_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 2, 1, 3, 5, 6, 4];

        FindPeakElementProblem findPeakElementProblem = new FindPeakElementProblem();

        // Act
        int actual = findPeakElementProblem.FindPeakElement(nums);

        // Assert
        actual.Should().Be(5);
        //actual.Should().Be(1);
    }
}