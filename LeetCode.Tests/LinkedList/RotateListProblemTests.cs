using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class RotateListProblemTests
{
    [Fact]
    public void RotateRight_TestCase_1()
    {
        // Arrange
        int[] head = [1, 2, 3, 4, 5];
        int k = 2;

        ListNode headNode = head.CreateLinkedList();

        RotateListProblem rotateListProblem = new RotateListProblem();

        // Act
        ListNode actual = rotateListProblem.RotateRight(headNode, k);

        // Assert
        actual.AssertLinkedList([4, 5, 1, 2, 3]);
    }

    [Fact]
    public void RotateRight_TestCase_2()
    {
        // Arrange
        int[] head = [0, 1, 2];
        int k = 4;

        ListNode headNode = head.CreateLinkedList();

        RotateListProblem rotateListProblem = new RotateListProblem();

        // Act
        ListNode actual = rotateListProblem.RotateRight(headNode, k);

        // Assert
        actual.AssertLinkedList([2, 0, 1]);
    }
}