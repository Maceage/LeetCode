using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class FlattenAMultilevelDoublyLinkedListProblemTests
{
    [Fact]
    public void Flatten_TestCase_1()
    {
        // Arrange
        int?[] head = [1, 2, 3, 4, 5, 6, null, null, null, 7, 8, 9, 10, null, null, 11, 12];

        Node headNode = head.CreateMultilevelDoublyLinkedList();

        FlattenAMultilevelDoublyLinkedListProblem flattenAMultilevelDoublyLinkedListProblem = new FlattenAMultilevelDoublyLinkedListProblem();

        // Act
        headNode = flattenAMultilevelDoublyLinkedListProblem.Flatten(headNode);

        // Assert
        headNode.AssertDoublyLinkedList([1, 2, 3, 7, 8, 11, 12, 9, 10, 4, 5, 6]);
    }

    [Fact]
    public void Flatten_TestCase_2()
    {
        // Arrange
        int?[] head = [1, 2, null, 3];

        Node headNode = head.CreateMultilevelDoublyLinkedList();

        FlattenAMultilevelDoublyLinkedListProblem flattenAMultilevelDoublyLinkedListProblem = new FlattenAMultilevelDoublyLinkedListProblem();

        // Act
        headNode = flattenAMultilevelDoublyLinkedListProblem.Flatten(headNode);

        // Assert
        headNode.AssertDoublyLinkedList([1, 3, 2]);
    }

    [Fact]
    public void Flatten_TestCase_3()
    {
        // Arrange
        int?[] head = [];

        Node headNode = head.CreateMultilevelDoublyLinkedList();

        FlattenAMultilevelDoublyLinkedListProblem flattenAMultilevelDoublyLinkedListProblem = new FlattenAMultilevelDoublyLinkedListProblem();

        // Act
        headNode = flattenAMultilevelDoublyLinkedListProblem.Flatten(headNode);

        // Assert
        headNode.AssertDoublyLinkedList([]);
    }
}