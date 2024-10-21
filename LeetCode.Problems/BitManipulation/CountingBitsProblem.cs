namespace LeetCode.Problems.BitManipulation;

public class CountingBitsProblem
{
    public int[] CountBits(int n)
    {
        return CountBitsDynamicProgrammingAndLastSetBit(n);
        return CountBitsDynamicProgrammingAndLeastSignificantBit(n);
        return CountBitsDynamicProgrammingAndMostSignificantBit(n);
        return CountBitsPopCount(n);
        return CountBitsOriginal(n);
    }

    private static int[] CountBitsDynamicProgrammingAndLastSetBit(int n)
    {
        int[] ans = new int[n + 1];

        for (int x = 1; x <= n; ++x)
        {
            ans[x] = ans[x & (x - 1)] + 1;
        }

        return ans;
    }

    private static int[] CountBitsDynamicProgrammingAndLeastSignificantBit(int n)
    {
        int[] ans = new int[n + 1];

        for (int i = 0; i <= n; ++i)
        {
            // x / 2 is x >> 1 and x % 2 is x & 1
            ans[i] = ans[i >> 1] + (i & 1);
        }

        return ans;
    }

    private static int[] CountBitsDynamicProgrammingAndMostSignificantBit(int n)
    {
        int[] ans = new int[n + 1];
        int x = 0;
        int b = 1;

        // [0, b) is calculated
        while (b <= n)
        {
            // Generate [b, 2b) or [b, n) from [0, b)
            while (x < b && x + b <= n)
            {
                ans[x + b] = ans[x] + 1;
                ++x;
            }

            x = 0;      // Reset x
            b <<= 1;    // b = 2b
        }

        return ans; ;
    }

    private static int[] CountBitsPopCount(int n)
    {
        int[] ans = new int[n + 1];

        for (int i = 0; i <= n; ++i)
        {
            ans[i] = PopCount(i);
        }

        return ans;
    }

    private static int PopCount(int x)
    {
        int count;

        for (count = 0; x != 0; ++count)
        {
            x &= x - 1; // Zeroing out the least significant nonzero bit
        }

        return count;
    }

    private static int[] CountBitsOriginal(int n)
    {
        int[] result = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            string binaryDigits = Convert.ToString(i, 2);

            int numberOfOnes = binaryDigits.Count(b => b == '1');

            result[i] = numberOfOnes;
        }

        return result;
    }
}