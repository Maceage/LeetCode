namespace LeetCode.Problems.Array;

public class ReverseStringProblem
{
    public void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            int x = s.Length - i - 1;

            if (x <= i)
            {
                break;
            }

            char leftChar = s[i];
            char rightChar = s[x];

            s[x] = leftChar;
            s[i] = rightChar;
        }
    }
}