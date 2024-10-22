using FluentAssertions;
using LeetCode.Problems.Trie;

namespace LeetCode.Tests.Trie;

public class ImplementTrieProblemTests
{
    [Fact]
    public void ImplementTrie_TestCase_1()
    {
        // Arrange
        ImplementTrieProblem.Trie trie = new ImplementTrieProblem.Trie();

        // Act/Assert
        trie.Insert("apple");
        trie.Search("apple").Should().BeTrue();
        trie.Search("app").Should().BeFalse();
        trie.StartsWith("app").Should().BeTrue();
        
        trie.Insert("app");
        trie.Search("app").Should().BeTrue();
    }
}