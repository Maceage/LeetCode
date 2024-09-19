namespace LeetCode.Problems;

public class IsSubsequenceProblem
{
    public bool IsSubsequence(string s, string t)
    {
        int sourceIndex = 0;
        int targetIndex = 0;

        while ((sourceIndex < s.Length) && (targetIndex < t.Length))
        {
            char sourceChar = s[sourceIndex];

            while (targetIndex < t.Length)
            {
                char targetChar = t[targetIndex];

                if (targetChar == sourceChar)
                {
                    sourceIndex++;
                    targetIndex++;
                    break;
                }

                targetIndex++;
            }
        }

        return (sourceIndex == s.Length);
    }
}