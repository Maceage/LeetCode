using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class CountGoodNodesInBinaryTreeProblemTests
{
    [Fact]
    public void GoodNodes_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [3, 1, 4, 3, null, 1, 5];

        TreeNode rootNode = numberArray.CreateTree();

        CountGoodNodesInBinaryTreeProblem countGoodNodesInBinaryTreeProblem = new CountGoodNodesInBinaryTreeProblem();

        // Act
        int actual = countGoodNodesInBinaryTreeProblem.GoodNodes(rootNode);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void GoodNodes_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [3, 3, null, 4, 2];

        TreeNode rootNode = numberArray.CreateTree();

        CountGoodNodesInBinaryTreeProblem countGoodNodesInBinaryTreeProblem = new CountGoodNodesInBinaryTreeProblem();

        // Act
        int actual = countGoodNodesInBinaryTreeProblem.GoodNodes(rootNode);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void GoodNodes_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [1];

        TreeNode rootNode = numberArray.CreateTree();

        CountGoodNodesInBinaryTreeProblem countGoodNodesInBinaryTreeProblem = new CountGoodNodesInBinaryTreeProblem();

        // Act
        int actual = countGoodNodesInBinaryTreeProblem.GoodNodes(rootNode);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void GoodNodes_TestCase_4()
    {
        // Arrange
        int?[] numberArray = [2, null, 4, 10, 8, null, null, 4];

        TreeNode rootNode = numberArray.CreateTree();

        CountGoodNodesInBinaryTreeProblem countGoodNodesInBinaryTreeProblem = new CountGoodNodesInBinaryTreeProblem();

        // Act
        int actual = countGoodNodesInBinaryTreeProblem.GoodNodes(rootNode);

        // Assert
        actual.Should().Be(4);
    }
}