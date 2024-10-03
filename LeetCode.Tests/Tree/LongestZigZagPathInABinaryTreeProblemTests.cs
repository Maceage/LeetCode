using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class LongestZigZagPathInABinaryTreeProblemTests
{
    [Fact]
    public void LongestZigZag_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [1, null, 1, 1, 1, null, null, 1, 1, null, 1, null, null, null, 1];

        TreeNode rootNode = numberArray.CreateTree();

        LongestZigZagPathInABinaryTreeProblem longestZigZagPathInABinaryTreeProblem = new LongestZigZagPathInABinaryTreeProblem();

        // Act
        int actual = longestZigZagPathInABinaryTreeProblem.LongestZigZag(rootNode);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void LongestZigZag_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [1, 1, 1, null, 1, null, null, 1, 1, null, 1];

        TreeNode rootNode = numberArray.CreateTree();

        LongestZigZagPathInABinaryTreeProblem longestZigZagPathInABinaryTreeProblem = new LongestZigZagPathInABinaryTreeProblem();

        // Act
        int actual = longestZigZagPathInABinaryTreeProblem.LongestZigZag(rootNode);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void LongestZigZag_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [1];

        TreeNode rootNode = numberArray.CreateTree();

        LongestZigZagPathInABinaryTreeProblem longestZigZagPathInABinaryTreeProblem = new LongestZigZagPathInABinaryTreeProblem();

        // Act
        int actual = longestZigZagPathInABinaryTreeProblem.LongestZigZag(rootNode);

        // Assert
        actual.Should().Be(0);
    }
}