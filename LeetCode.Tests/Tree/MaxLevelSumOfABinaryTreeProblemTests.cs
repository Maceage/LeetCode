using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class MaxLevelSumOfABinaryTreeProblemTests
{
    [Fact]
    public void MaxLevelSum_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [1, 7, 0, 7, -8, null, null];

        TreeNode rootNode = numberArray.CreateTree();

        MaxLevelSumOfABinaryTreeProblem maxLevelSumOfABinaryTreeProblem = new MaxLevelSumOfABinaryTreeProblem();

        // Act
        int actual = maxLevelSumOfABinaryTreeProblem.MaxLevelSum(rootNode);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxLevelSum_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [989, null, 10250, 98693, -89388, null, null, null, -32127];

        TreeNode rootNode = numberArray.CreateTree();

        MaxLevelSumOfABinaryTreeProblem maxLevelSumOfABinaryTreeProblem = new MaxLevelSumOfABinaryTreeProblem();

        // Act
        int actual = maxLevelSumOfABinaryTreeProblem.MaxLevelSum(rootNode);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxLevelSum_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [-100, -200, -300, -20, -5, -10, null];

        TreeNode rootNode = numberArray.CreateTree();

        MaxLevelSumOfABinaryTreeProblem maxLevelSumOfABinaryTreeProblem = new MaxLevelSumOfABinaryTreeProblem();

        // Act
        int actual = maxLevelSumOfABinaryTreeProblem.MaxLevelSum(rootNode);

        // Assert
        actual.Should().Be(3);
    }
}