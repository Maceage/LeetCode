namespace LeetCode.Problems.Array;

public class MergeStringsAlternatelyProblem
{
    public string MergeAlternately(string word1, string word2)
    {
        string finalString = string.Empty;

        int i = 0;

        while (i <= word1.Length || i <= word2.Length)
        {
            if (i < word1.Length)
            {
                char leftChar = word1[i];

                finalString += leftChar;
            }

            if (i < word2.Length)
            {
                char rightChar = word2[i];

                finalString += rightChar;
            }

            i++;
        }

        return finalString;
    }
}