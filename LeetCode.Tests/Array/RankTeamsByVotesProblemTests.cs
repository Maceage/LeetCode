using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class RankTeamsByVotesProblemTests
{
    [Fact]
    public void RankTeams_TestCase_1()
    {
        // Arrange
        RankTeamsByVotesProblem rankTeamsByVotesProblem = new RankTeamsByVotesProblem();

        string[] votes = ["ABC", "ACB", "ABC", "ACB", "ACB"];

        // Act
        string actual = rankTeamsByVotesProblem.RankTeams(votes);

        // Assert
        actual.Should().Be("ACB");
    }

    [Fact]
    public void RankTeams_TestCase_2()
    {
        // Arrange
        RankTeamsByVotesProblem rankTeamsByVotesProblem = new RankTeamsByVotesProblem();

        string[] votes = ["WXYZ", "XYZW"];

        // Act
        string actual = rankTeamsByVotesProblem.RankTeams(votes);

        // Assert
        actual.Should().Be("XWYZ");
    }

    [Fact]
    public void RankTeams_TestCase_3()
    {
        // Arrange
        RankTeamsByVotesProblem rankTeamsByVotesProblem = new RankTeamsByVotesProblem();

        string[] votes = ["ZMNAGUEDSJYLBOPHRQICWFXTVK"];

        // Act
        string actual = rankTeamsByVotesProblem.RankTeams(votes);

        // Assert
        actual.Should().Be("ZMNAGUEDSJYLBOPHRQICWFXTVK");
    }

    [Fact]
    public void RankTeams_TestCase_4()
    {
        // Arrange
        RankTeamsByVotesProblem rankTeamsByVotesProblem = new RankTeamsByVotesProblem();

        string[] votes = [
            "FVSHJIEMNGYPTQOURLWCZKAX",
            "AITFQORCEHPVJMXGKSLNZWUY",
            "OTERVXFZUMHNIYSCQAWGPKJL",
            "VMSERIJYLZNWCPQTOKFUHAXG",
            "VNHOZWKQCEFYPSGLAMXJIUTR",
            "ANPHQIJMXCWOSKTYGULFVERZ",
            "RFYUXJEWCKQOMGATHZVILNSP",
            "SCPYUMQJTVEXKRNLIOWGHAFZ",
            "VIKTSJCEYQGLOMPZWAHFXURN",
            "SVJICLXKHQZTFWNPYRGMEUAO",
            "JRCTHYKIGSXPOZLUQAVNEWFM",
            "NGMSWJITREHFZVQCUKXYAPOL",
            "WUXJOQKGNSYLHEZAFIPMRCVT",
            "PKYQIOLXFCRGHZNAMJVUTWES",
            "FERSGNMJVZXWAYLIKCPUQHTO",
            "HPLRIUQMTSGYJVAXWNOCZEKF",
            "JUVWPTEGCOFYSKXNRMHQALIZ",
            "MWPIAZCNSLEYRTHFKQXUOVGJ",
            "EZXLUNFVCMORSIWKTYHJAQPG",
            "HRQNLTKJFIEGMCSXAZPYOVUW",
            "LOHXVYGWRIJMCPSQENUAKTZF",
            "XKUTWPRGHOAQFLVYMJSNEIZC",
            "WTCRQMVKPHOSLGAXZUEFYNJI"];

        // Act
        string actual = rankTeamsByVotesProblem.RankTeams(votes);

        // Assert
        actual.Should().Be("VWFHSJARNPEMOXLTUKICZGYQ");
    }
}