using System.Text;

namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/rank-teams-by-votes/
/// </summary>
public class RankTeamsByVotesProblem
{
    private class TeamNode
    {
        public char Team { get; set; }
        public int[] Votes { get; set; }

        private string GetVotes()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (int vote in Votes)
            {
                stringBuilder.Append($"{vote},");
            }

            return stringBuilder.ToString().TrimEnd(',');
        }

        public override string ToString()
        {
            return $"Team: {Team}, Votes: {GetVotes()}";
        }
    }

    private readonly TeamNode[] _teamNodes = new TeamNode[26];

    public string RankTeams(string[] votes)
    {
        if (votes.Length <= 0)
        {
            return string.Empty;
        }

        int votePositions = votes[0].Length;

        for (int i = 0; i <= 25; i++)
        {
            char teamChar = (char)('A' + i);

            _teamNodes[i] = new TeamNode
            {
                Team = teamChar,
                Votes = new int[votePositions]
            };
        }

        foreach (string vote in votes)
        {
            int currentVote = 0;

            foreach (var teamChar in vote)
            {
                int charIndex = teamChar - 'A';

                _teamNodes[charIndex].Votes[currentVote]++;

                currentVote++;
            }
        }

        System.Array.Sort(_teamNodes, (a, b) =>
        {
            for (int i = 0; i < a.Votes.Length; i++)
            {
                if (a.Votes[i] != b.Votes[i])
                {
                    return b.Votes[i] - a.Votes[i];
                }
            }

            return a.Team - b.Team;
        });

        StringBuilder stringBuilder = new StringBuilder();

        foreach (TeamNode teamNode in _teamNodes)
        {
            bool hasVotes = false;

            foreach (var vote in teamNode.Votes)
            {
                if (vote > 0)
                {
                    hasVotes = true;
                }
            }

            if (hasVotes)
            {
                stringBuilder.Append(teamNode.Team);
            }
        }

        return stringBuilder.ToString();
    }
}