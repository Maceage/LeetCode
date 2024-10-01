using FluentAssertions;
using LeetCode.Problems.Queue;

namespace LeetCode.Tests.Queue;

public class Dota2SenateProblemTests
{
    [Fact]
    public void PredictPartyVictory_TestCase_1()
    {
        // Arrange
        string senate = "RD";

        Dota2SenateProblem dota2SenateProblem = new Dota2SenateProblem();

        // Act
        string actual = dota2SenateProblem.PredictPartyVictory(senate);

        // Assert
        actual.Should().Be("Radiant");
    }

    [Fact]
    public void PredictPartyVictory_TestCase_2()
    {
        // Arrange
        string senate = "RDD";

        Dota2SenateProblem dota2SenateProblem = new Dota2SenateProblem();

        // Act
        string actual = dota2SenateProblem.PredictPartyVictory(senate);

        // Assert
        actual.Should().Be("Dire");
    }

    [Fact]
    public void PredictPartyVictory_TestCase_3()
    {
        // Arrange
        string senate = "RDDRDRD";

        Dota2SenateProblem dota2SenateProblem = new Dota2SenateProblem();

        // Act
        string actual = dota2SenateProblem.PredictPartyVictory(senate);

        // Assert
        actual.Should().Be("Dire");
    }

    [Fact]
    public void PredictPartyVictory_TestCase_4()
    {
        // Arrange
        string senate = "DRDRDRDDR";

        Dota2SenateProblem dota2SenateProblem = new Dota2SenateProblem();

        // Act
        string actual = dota2SenateProblem.PredictPartyVictory(senate);

        // Assert
        actual.Should().Be("Dire");
    }
}