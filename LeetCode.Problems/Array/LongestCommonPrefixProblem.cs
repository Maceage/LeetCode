namespace LeetCode.Problems.Array;

public class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longestPrefix = string.Empty;
        string prefix = string.Empty;

        string firstString = strs[0];

        foreach (var t in firstString)
        {
            prefix += t;

            bool allStartWith = true;

            foreach (string str in strs)
            {
                if (!str.StartsWith(prefix))
                {
                    allStartWith = false;
                    break;
                }
            }

            if (allStartWith == false)
            {
                longestPrefix = prefix.Remove(prefix.Length - 1);
                break;
            }
        }

        return longestPrefix;
    }
}