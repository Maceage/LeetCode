namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
/// </summary>
public class FindTheIndexOfTheFirstOccurenceInAStringProblem
{
    private const int RADIX_1 = 26;
    private const int MOD_1 = 1000000033;
    private const int RADIX_2 = 27;
    private const int MOD_2 = 2147483647;

    public int StrStr(string haystack, string needle)
    {
        return StrStrKnuthMorrisPrattAlgorithm(haystack, needle);
        return StrStrRabinKarpAlgorithmDoubleHash(haystack, needle);
        return StrStrRabinKarpAlgorithmSingleHash(haystack, needle);
        return StrStrSlidingWindow(haystack, needle);
        return StrStrOriginal(haystack, needle);
    }

    private static int StrStrKnuthMorrisPrattAlgorithm(string haystack, string needle)
    {
        int m = needle.Length;
        int n = haystack.Length;

        if (n < m)
        {
            return -1;
        }

        int[] longestBorder = new int[m];
        int prev = 0;
        int i = 1;

        while (i < m)
        {
            if (needle[i] == needle[prev])
            {
                prev += 1;
                longestBorder[i] = prev;
                i += 1;
            }
            else
            {
                if (prev == 0)
                {
                    longestBorder[i] = 0;
                    i += 1;
                }
                else
                {
                    prev = longestBorder[prev - 1];
                }
            }
        }

        int haystackPointer = 0;
        int needlePointer = 0;

        while (haystackPointer < n)
        {
            if (haystack[haystackPointer] == needle[needlePointer])
            {
                needlePointer += 1;
                haystackPointer += 1;

                if (needlePointer == m)
                {
                    return haystackPointer - m;
                }
            }
            else
            {
                if (needlePointer == 0)
                {
                    haystackPointer += 1;
                }
                else
                {
                    needlePointer = longestBorder[needlePointer - 1];
                }
            }
        }

        return -1;
    }

    private static int StrStrRabinKarpAlgorithmDoubleHash(string haystack, string needle)
    {
        int m = needle.Length;
        int n = haystack.Length;

        if (n < m)
        {
            return -1;
        }

        long MAX_WEIGHT_1 = 1;
        long MAX_WEIGHT_2 = 1;

        for (int i = 0; i < m; i++)
        {
            MAX_WEIGHT_1 = (MAX_WEIGHT_1 * RADIX_1) % MOD_1;
            MAX_WEIGHT_2 = (MAX_WEIGHT_2 * RADIX_2) % MOD_2;
        }

        long[] hashNeedle = HashPair(needle, m);
        long[] hashHay = new long[2];

        for (int windowStart = 0; windowStart <= n- m; windowStart++)
        {
            if (windowStart == 0)
            {
                hashHay = HashPair(haystack, m);
            }
            else
            {
                hashHay[0] = ((hashHay[0] * RADIX_1) % MOD_1 -
                              ((haystack[windowStart - 1] - 'a') * MAX_WEIGHT_1) %
                              MOD_1 +
                              (haystack[windowStart + m - 1] - 'a') + MOD_1) %
                             MOD_1;

                hashHay[1] = ((hashHay[1] * RADIX_2) % MOD_2 -
                              ((haystack[windowStart - 1] - 'a') * MAX_WEIGHT_2) %
                              MOD_2 +
                              (haystack[windowStart + m - 1] - 'a') + MOD_2) %
                             MOD_2;
            }

            if (hashNeedle[0] == hashHay[0] && hashNeedle[1] == hashHay[1])
            {
                return windowStart;
            }
        }

        return -1;
    }

    private static long[] HashPair(string str, int m)
    {
        long hash1 = 0;
        long hash2 = 0;

        long factor1 = 1;
        long factor2 = 1;

        for (int i = m - 1; i >= 0 ; i--)
        {
            hash1 += ((str[i] - 'a') * (factor1)) % MOD_1;
            factor1 = (factor1 * RADIX_1) % MOD_1;
            hash2 += ((str[i] - 'a') * (factor2)) % MOD_2;
            factor2 = (factor2 * RADIX_2) % MOD_2;
        }

        return [hash1 % MOD_1, hash2 % MOD_2];
    }

    private static int StrStrRabinKarpAlgorithmSingleHash(string haystack, string needle)
    {
        int m = needle.Length;
        int n = haystack.Length;

        if (n < m)
        {
            return -1;
        }

        const int RADIX = 26;
        const int MOD = 1000000033;
        long MAX_WEIGHT = 1;

        for (int i = 0; i < m; ++i)
        {
            MAX_WEIGHT = (MAX_WEIGHT * RADIX) % MOD;
        }

        long hashNeedle = HashValue(needle, RADIX, MOD, m);
        long hashHay = HashValue(haystack, RADIX, MOD, m);

        for (int windowStart = 0; windowStart < n - m; ++windowStart)
        {
            if (windowStart != 0)
            {
                hashHay = ((hashHay * RADIX) % MOD -
                           (haystack[windowStart - 1] - 'a') * MAX_WEIGHT % MOD) +
                           (haystack[windowStart + m - 1] - 'a') + MOD %
                           MOD;
            }

            if (hashNeedle == hashHay)
            {
                for (int i = 0; i < m; ++i)
                {
                    if (needle[i] != haystack[i + windowStart])
                    {
                        break;
                    }

                    if (i == m - 1)
                    {
                        return windowStart;
                    }
                }
            }
        }

        return -1;
    }

    private static long HashValue(string needle, int radix, int mod, int m)
    {
        long ans = 0;
        long factor = 1;

        for (int i = m - 1; i >= 0; --i)
        {
            ans = (ans + (needle[i] - 'a') * factor % mod + mod) % mod;
            factor = (factor * radix) % mod;
        }

        return ans;
    }

    private static int StrStrSlidingWindow(string haystack, string needle)
    {
        int m = needle.Length;
        int n = haystack.Length;

        for (int windowStart = 0; windowStart <= n - m; windowStart++)
        {
            for (int i = 0; i < m; i++)
            {
                if (needle[i] != haystack[windowStart + i])
                {
                    break;
                }

                if (i == m - 1)
                {
                    return windowStart;
                }
            }
        }

        return -1;
    }

    private static int StrStrOriginal(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        if (needle.Length <= 0)
        {
            return -1;
        }

        int startIndex = -1;
        int needleIndex = needle.Length - 1;

        // Iterate through haystack and find first occurence of last needle character
        for (int i = 0; i < haystack.Length; i++)
        {
            char haystackChar = haystack[i];
            char needleChar = needle[needleIndex];

            // Iterate backwards in haystack and check each character against needle
            if (haystackChar == needleChar)
            {
                int haystackIndex = i;

                for (int j = needleIndex; j >= 0; j--)
                {
                    if (haystackIndex < 0)
                    {
                        startIndex = -1;
                        break;
                    }

                    char h = haystack[haystackIndex];
                    char n = needle[j];

                    if (h == n)
                    {
                        haystackIndex--;
                    }
                    else if (h != n)
                    {
                        startIndex = -1;
                        break;
                    }

                    if (j == 0)
                    {
                        startIndex = i - (needle.Length - 1);
                        break;
                    }
                }
            }

            // Start index has been changed so needle found
            if (startIndex > -1)
            {
                break;
            }
        }

        return startIndex;
    }
}