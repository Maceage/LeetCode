using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class BinaryTreeRightSideViewProblemTests
{
    [Fact]
    public void RightSideView_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [1, 2, 3, null, 5, null, 4];

        TreeNode rootNode = numberArray.CreateTree();

        int[] expected = [1, 3, 4];

        BinaryTreeRightSideViewProblem binaryTreeRightSideViewProblem = new BinaryTreeRightSideViewProblem();

        // Act
        IList<int> actual = binaryTreeRightSideViewProblem.RightSideView(rootNode);

        // Assert
        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [Fact]
    public void RightSideView_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [1, null, 3];

        TreeNode rootNode = numberArray.CreateTree();

        int[] expected = [1, 3];

        BinaryTreeRightSideViewProblem binaryTreeRightSideViewProblem = new BinaryTreeRightSideViewProblem();

        // Act
        IList<int> actual = binaryTreeRightSideViewProblem.RightSideView(rootNode);

        // Assert
        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [Fact]
    public void RightSideView_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [];

        TreeNode rootNode = numberArray.CreateTree();

        int[] expected = [];

        BinaryTreeRightSideViewProblem binaryTreeRightSideViewProblem = new BinaryTreeRightSideViewProblem();

        // Act
        IList<int> actual = binaryTreeRightSideViewProblem.RightSideView(rootNode);

        // Assert
        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [Fact]
    public void RightSideView_TestCase_4()
    {
        // Arrange
        int?[] numberArray = [1, 2, 3, 4];

        TreeNode rootNode = numberArray.CreateTree();

        int[] expected = [1, 3, 4];

        BinaryTreeRightSideViewProblem binaryTreeRightSideViewProblem = new BinaryTreeRightSideViewProblem();

        // Act
        IList<int> actual = binaryTreeRightSideViewProblem.RightSideView(rootNode);

        // Assert
        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
}