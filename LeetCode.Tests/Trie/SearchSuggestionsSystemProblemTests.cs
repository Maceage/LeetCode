using FluentAssertions;
using LeetCode.Problems.Trie;

namespace LeetCode.Tests.Trie;

public class SearchSuggestionsSystemProblemTests
{
    [Fact]
    public void SuggestedProducts_TestCase_1()
    {
        // Arrange
        string[] products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"];
        string searchWord = "mouse";

        string[][] expected = [
            ["mobile", "moneypot", "monitor"],
            ["mobile", "moneypot", "monitor"],
            ["mouse", "mousepad"],
            ["mouse", "mousepad"],
            ["mouse", "mousepad"]
        ];

        SearchSuggestionsSystemProblem searchSuggestionsSystemProblem = new SearchSuggestionsSystemProblem();

        // Act
        IList<IList<string>> actual = searchSuggestionsSystemProblem.SuggestedProducts(products, searchWord);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SuggestedProducts_TestCase_2()
    {
        // Arrange
        string[] products = ["havana"];
        string searchWord = "havana";

        string[][] expected = [
            ["havana"],
            ["havana"],
            ["havana"],
            ["havana"],
            ["havana"],
            ["havana"]
        ];

        SearchSuggestionsSystemProblem searchSuggestionsSystemProblem = new SearchSuggestionsSystemProblem();

        // Act
        IList<IList<string>> actual = searchSuggestionsSystemProblem.SuggestedProducts(products, searchWord);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}