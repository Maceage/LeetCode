using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class PalindromeLinkedListProblemTests
{
    [Fact]
    public void IsPalindrome_TestCase_1()
    {
        // Arrange
        int[] head = [1, 2, 2, 1];

        ListNode headNode = head.CreateLinkedList();

        PalindromeLinkedListProblem palindromeLinkedListProblem = new PalindromeLinkedListProblem();

        // Act/Assert
        palindromeLinkedListProblem.IsPalindrome(headNode).Should().BeTrue();
    }

    [Fact]
    public void IsPalindrome_TestCase_2()
    {
        // Arrange
        int[] head = [1, 2];

        ListNode headNode = head.CreateLinkedList();

        PalindromeLinkedListProblem palindromeLinkedListProblem = new PalindromeLinkedListProblem();

        // Act/Assert
        palindromeLinkedListProblem.IsPalindrome(headNode).Should().BeFalse();
    }
}