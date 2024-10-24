namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/determine-if-two-strings-are-close
/// </summary>
public class DetermineIfTwoStringsAreCloseProblem
{
    public bool CloseStrings(string word1, string word2)
    {
        bool areClose = true;

        if (word1.Length == word2.Length)
        {
            Dictionary<char, int> word1CharCounts = GetWordCharCounts(word1);
            Dictionary<char, int> word2CharCounts = GetWordCharCounts(word2);
            var list2Keys = word2CharCounts.Keys.ToList();

            if (word1CharCounts.Count == word2CharCounts.Count)
            {
                for (var keyIndex = 0; keyIndex < list2Keys.Count; keyIndex++)
                {
                    var character2 = list2Keys[keyIndex];
                    int count2 = word2CharCounts[character2];

                    if (!word1CharCounts.TryGetValue(character2, out var count1))
                    {
                        areClose = false;
                        break;
                    }

                    if (count1 != count2)
                    {
                        areClose = false;

                        for (var futureIndex = keyIndex + 1; futureIndex < list2Keys.Count; futureIndex++)
                        {
                            int futCount2 = word2CharCounts[list2Keys[futureIndex]];

                            if (futCount2 == count1)
                            {
                                // Swap current with future
                                word2CharCounts[list2Keys[futureIndex]] = count2;
                                areClose = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                areClose = false;
            }
        }
        else
        {
            areClose = false;
        }

        return areClose;
    }

    private static Dictionary<char, int> GetWordCharCounts(string word1)
    {
        Dictionary<char, int> wordCharCounts = new Dictionary<char, int>();

        foreach (char c in word1)
        {
            if (!wordCharCounts.TryAdd(c, 1))
            {
                wordCharCounts[c]++;
            }
        }

        return wordCharCounts;
    }
}