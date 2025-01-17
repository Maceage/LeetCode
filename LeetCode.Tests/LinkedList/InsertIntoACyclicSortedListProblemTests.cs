using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class InsertIntoACyclicSortedListProblemTests
{
    [Fact]
    public void Insert_TestCase_1()
    {
        // Arrange
        int[] head = [3, 4, 1];
        int insertVal = 2;

        ListNode headNode = head.CreateLinkedListWithCycle(0);

        InsertIntoACyclicSortedListProblem insertIntoACyclicSortedListProblem = new InsertIntoACyclicSortedListProblem();

        // Act
        ListNode actual = insertIntoACyclicSortedListProblem.Insert(headNode, insertVal);

        // Assert
        actual.AssertLinkedList([3, 4, 1, 2]);
    }

    [Fact]
    public void Insert_TestCase_2()
    {
        // Arrange
        int[] head = [];
        int insertVal = 1;

        ListNode headNode = head.CreateLinkedListWithCycle(0);

        InsertIntoACyclicSortedListProblem insertIntoACyclicSortedListProblem = new InsertIntoACyclicSortedListProblem();

        // Act
        ListNode actual = insertIntoACyclicSortedListProblem.Insert(headNode, insertVal);

        // Assert
        actual.AssertLinkedList([1]);
    }

    [Fact]
    public void Insert_TestCase_3()
    {
        // Arrange
        int[] head = [1];
        int insertVal = 0;

        ListNode headNode = head.CreateLinkedListWithCycle(0);

        InsertIntoACyclicSortedListProblem insertIntoACyclicSortedListProblem = new InsertIntoACyclicSortedListProblem();

        // Act
        ListNode actual = insertIntoACyclicSortedListProblem.Insert(headNode, insertVal);

        // Assert
        actual.AssertLinkedList([1, 0]);
    }
}