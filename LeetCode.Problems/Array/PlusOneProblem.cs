namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/plus-one/
/// </summary>
public class PlusOneProblem
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int digit = digits[i];

            if (digit == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;

                return digits;
            }
        }

        int[] newDigits = new int[digits.Length + 1];

        newDigits[0] = 1;

        return newDigits;
    }
}