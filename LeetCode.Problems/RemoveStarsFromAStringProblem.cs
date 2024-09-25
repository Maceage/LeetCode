using System.Text;

namespace LeetCode.Problems;

public class RemoveStarsFromAStringProblem
{
    public string RemoveStars(string s)
    {
        Stack<char> characters = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '*')
            {
                characters.Pop();
            }
            else
            {
                characters.Push(c);
            }
        }

        StringBuilder stringBuilder = new StringBuilder(characters.Count);

        while (characters.TryPop(out var character))
        {
            stringBuilder.Append(character);
        }

        return new string(stringBuilder.ToString().Reverse().ToArray());
    }
}