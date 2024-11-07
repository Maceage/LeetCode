namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/longest-common-prefix
/// </summary>
public class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        return LongestCommonPrefixBinarySearch(strs);
        return LongestCommonPrefixDivideAndConquer(strs);
        return LongestCommonPrefixVerticalScanning(strs);
        return LongestCommonPrefixHorizontalScanning(strs);
        return LongestCommonPrefixOriginal(strs);
    }

    private static string LongestCommonPrefixBinarySearch(string[] strs)
    {
        if (strs == null | strs.Length == 0)
        {
            return string.Empty;
        }

        int minLen = int.MaxValue;

        foreach (string str in strs)
        {
            minLen = Math.Min(minLen, str.Length);
        }

        int low = 1;
        int high = minLen;

        while (low <= high)
        {
            int middle = (low + high) / 2;

            if (IsCommonPrefix(strs, middle))
            {
                low = middle + 1;
            }
            else
            {
                high = middle - 1;
            }
        }

        return strs[0].Substring(0, (low + high) / 2);
    }

    private static bool IsCommonPrefix(string[] strs, int len)
    {
        string str1 = strs[0].Substring(0, len);

        for (int i = 1; i < strs.Length; i++)
        {
            if (!strs[i].StartsWith(str1))
            {
                return false;
            }
        }

        return true;
    }

    private static string LongestCommonPrefixDivideAndConquer(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        return LongestCommonPrefixDivideAndConquer(strs, 0, strs.Length - 1);
    }

    private static string LongestCommonPrefixDivideAndConquer(string[] strs, int l, int r)
    {
        if (l == r)
        {
            return strs[l];
        }
        else
        {
            int mid = (l + r) / 2;

            string lcpLeft = LongestCommonPrefixDivideAndConquer(strs, l, mid);
            string lcpRight = LongestCommonPrefixDivideAndConquer(strs, mid + 1, r);

            return CommonPrefix(lcpLeft, lcpRight);
        }
    }

    private static string CommonPrefix(string left, string right)
    {
        int min = Math.Min(left.Length, right.Length);

        for (int i = 0; i < min; i++)
        {
            if (left[i] != right[i])
            {
                return left.Substring(0, i);
            }
        }

        return left.Substring(0, min);
    }

    private static string LongestCommonPrefixVerticalScanning(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }

    private static string LongestCommonPrefixHorizontalScanning(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix, StringComparison.Ordinal) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == string.Empty)
                {
                    return string.Empty;
                }
            }
        }

        return prefix;
    }

    private static string LongestCommonPrefixOriginal(string[] strs)
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

            longestPrefix = prefix;
        }

        return longestPrefix;
    }
}