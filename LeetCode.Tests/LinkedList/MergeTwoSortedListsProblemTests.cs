using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class MergeTwoSortedListsProblemTests
{
    [Fact]
    public void MergeTwoLists_TestCase_1()
    {
        // Arrange
        int[] list1 = [1, 2, 4];
        int[] list2 = [1, 3, 4];

        ListNode headList1 = list1.CreateLinkedList();
        ListNode headList2 = list2.CreateLinkedList();

        MergeTwoSortedListsProblem mergeTwoSortedListsProblem = new MergeTwoSortedListsProblem();

        // Act
        ListNode actual = mergeTwoSortedListsProblem.MergeTwoLists(headList1, headList2);

        // Assert
        actual.AssertLinkedList([1, 1, 2, 3, 4, 4]);
    }

    [Fact]
    public void MergeTwoLists_TestCase_2()
    {
        // Arrange
        int[] list1 = [];
        int[] list2 = [];

        ListNode headList1 = list1.CreateLinkedList();
        ListNode headList2 = list2.CreateLinkedList();

        MergeTwoSortedListsProblem mergeTwoSortedListsProblem = new MergeTwoSortedListsProblem();

        // Act
        ListNode actual = mergeTwoSortedListsProblem.MergeTwoLists(headList1, headList2);

        // Assert
        actual.AssertLinkedList([]);
    }

    [Fact]
    public void MergeTwoLists_TestCase_3()
    {
        // Arrange
        int[] list1 = [];
        int[] list2 = [0];

        ListNode headList1 = list1.CreateLinkedList();
        ListNode headList2 = list2.CreateLinkedList();

        MergeTwoSortedListsProblem mergeTwoSortedListsProblem = new MergeTwoSortedListsProblem();

        // Act
        ListNode actual = mergeTwoSortedListsProblem.MergeTwoLists(headList1, headList2);

        // Assert
        actual.AssertLinkedList([0]);
    }

    [Fact]
    public void MergeTwoLists_TestCase_4()
    {
        // Arrange
        int[] list1 = [1];
        int[] list2 = [];

        ListNode headList1 = list1.CreateLinkedList();
        ListNode headList2 = list2.CreateLinkedList();

        MergeTwoSortedListsProblem mergeTwoSortedListsProblem = new MergeTwoSortedListsProblem();

        // Act
        ListNode actual = mergeTwoSortedListsProblem.MergeTwoLists(headList1, headList2);

        // Assert
        actual.AssertLinkedList([1]);
    }
}