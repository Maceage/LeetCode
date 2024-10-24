namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/greatest-common-divisor-of-strings/
/// </summary>
public class GreatestCommonDivisorOfStringsProblem
{
    public string GcdOfStrings(string string1, string string2)
    {
        return GcdOfStringsGreatestCommonDivisor(string1, string2);
        return GcdOfStringsBruteForce(string1, string2);
    }

    private static string GcdOfStringsGreatestCommonDivisor(string string1, string string2)
    {
        if (!(string1 + string2).Equals(string2 + string1))
        {
            return string.Empty;
        }

        int gcdLength = GcdLength(string1.Length, string2.Length);

        return string1.Substring(0, gcdLength);
    }

    private static int GcdLength(int x, int y)
    {
        if (y == 0)
        {
            return x;
        }
        else
        {
            return GcdLength(y, x % y);
        }
    }

    private static string GcdOfStringsBruteForce(string string1, string string2)
    {
        string gcd = string.Empty;

        int length1 = string1.Length;
        int length2 = string2.Length;

        for (int i = Math.Min(length1, length2); i >= 1; --i)
        {
            if (IsValid(string1, string2, i))
            {
                gcd = string1.Substring(0, i);
                break;
            }
        }

        return gcd;
    }

    private static bool IsValid(string string1, string string2, int k)
    {
        bool isValid = false;

        int length1 = string1.Length;
        int length2 = string2.Length;

        if ((length1 % k <= 0) && (length2 % k <= 0))
        {
            string baseString = string1.Substring(0, k);

            bool isString1Empty = string.IsNullOrEmpty(string1.Replace(baseString, string.Empty));
            bool isString2Empty = string.IsNullOrEmpty(string2.Replace(baseString, string.Empty));

            isValid = (isString1Empty && isString2Empty);
        }

        return isValid;
    }
}