namespace LeetCode.Problems.SlidingWindow;

/// <summary>
/// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length
/// </summary>
public class MaximumNumberOfVowelsInASubstringOfGivenLengthProblem
{
    private const string Vowels = "aeiou";

    public int MaxVowels(string s, int k)
    {
        int totalVowels = 0;

        for (int i = 0; i < k; i++)
        {
            char currentChar = s[i];

            if (Vowels.Contains(currentChar))
            {
                totalVowels++;
            }
        }

        int maxVowels = totalVowels;

        for (int i = k; i <= s.Length - 1; i++)
        {
            char currentChar = s[i];
            char previousChar = s[i - k];

            bool isCurrentCharVowel = Vowels.Contains(currentChar);
            bool isPreviousCharVowel = Vowels.Contains(previousChar);

            if ((totalVowels > 0) && isPreviousCharVowel)
            {
                totalVowels--;
            }

            if (isCurrentCharVowel)
            {
                totalVowels++;
            }

            if (maxVowels == k)
            {
                break;
            }

            maxVowels = Math.Max(maxVowels, totalVowels);
        }

        return maxVowels;
    }
}