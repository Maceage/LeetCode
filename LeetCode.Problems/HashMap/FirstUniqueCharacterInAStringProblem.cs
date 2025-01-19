namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/first-unique-character-in-a-string
/// </summary>
public class FirstUniqueCharacterInAStringProblem
{
    public int FirstUniqueChar(string s)
    {
        if (s == null)
        {
            return -1;
        }

        int charIndex = -1;

        Dictionary<char, int> charactersDictionary = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!charactersDictionary.TryAdd(c, 1))
            {
                charactersDictionary[c]++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (charactersDictionary[c] == 1)
            {
                charIndex = i;
                break;
            }
        }

        return charIndex;
    }
}