namespace LeetCode.Problems.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/domino-and-tromino-tiling
/// </summary>
public class DominoAndTrominoTilingProblem
{
    private const int MOD = 1_000_000_007;

    private static readonly long[][] SQUARE_MATRIX =
    [
        [1, 1, 2],
        [1, 0, 0],
        [0, 1, 1]
    ];

    private const int SIZE = 3;

    private static readonly Dictionary<int, long[][]> _cache = new();

    private static readonly Dictionary<int, long> _fCache = new();
    private static readonly Dictionary<int, long> _pCache = new();

    public int NumTilings(int n)
    {
        return NumTilingsMathOptimisation(n);
        return NumTilingsMatrixExponentiationTimeOptimizationSpaceTimeTradeOff(n);
        return NumTilingsMatrixExponentiation(n);
        return NumTilingsDynamicProgrammingBottomUpSpaceOptimisation(n);
        return NumTilingsDynamicProgrammingBottomUp(n);
        return NumTilingsDynamicProgrammingTopDown(n);
    }

    private static int NumTilingsMathOptimisation(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        long fCurrent = 5L;
        long fPrevious = 2;
        long fBeforePrevious = 1;

        for (int k = 4; k < n + 1; ++k)
        {
            long temp = fPrevious;

            fPrevious = fCurrent;

            fCurrent = (2 * fCurrent + fBeforePrevious) % MOD;

            fBeforePrevious = temp;
        }

        return (int)(fCurrent % MOD);
    }

    private static int NumTilingsMatrixExponentiationTimeOptimizationSpaceTimeTradeOff(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        long[] ans = MatrixExpoCached(n - 2)[0];

        return (int)((ans[0] * 2 + ans[1] * 1 + ans[2] * 1) % MOD);
    }

    private static long[][] MatrixExpoCached(int n)
    {
        if (_cache.TryGetValue(n, out var cached))
        {
            return cached;
        }

        long[][] cur;

        if (n == 1)
        {
            cur = SQUARE_MATRIX;
        }
        else if (n % 2 == 1)
        {
            cur = MatrixProduct(MatrixExpoCached(n - 1), SQUARE_MATRIX);
        }
        else
        {
            cur = MatrixProduct(MatrixExpoCached(n / 2), MatrixExpoCached(n / 2));
        }

        _cache.Add(n, cur);

        return cur;
    }

    private static int NumTilingsMatrixExponentiation(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        return MatrixExpo(n - 2);
    }

    private static int MatrixExpo(int n)
    {
        long[][] cur = SQUARE_MATRIX;

        for (int i = 1; i < n; i++)
        {
            cur = MatrixProduct(cur, SQUARE_MATRIX);
        }

        // The answer will be cur[0][0] * f(2) + cur[0][1] * f(1) + cur[0][2] * p(2) 
        return (int)((cur[0][0] * 2 + cur[0][1] * 1 + cur[0][2] * 1) % MOD);
    }

    private static long[][] MatrixProduct(long[][] m1, long[][] m2)
    {
        // Return product of 2 square matrices
        // Result matrix `ans` will also be a 3x3 square matrix
        long[][] ans = new long[SIZE][];

        for (int row = 0; row < SIZE; ++row)
        {
            for (int col = 0; col < SIZE; ++col)
            {
                long curSum = 0;

                for (int k = 0; k < SIZE; ++k)
                {
                    curSum = (curSum + m1[row][k] * m2[k][col]) % MOD;
                }
            }
        }

        return ans;
    }

    private static int NumTilingsDynamicProgrammingBottomUpSpaceOptimisation(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        long fPrevious = 1L;
        long fCurrent = 2L;
        long pCurrent = 1L;

        for (int i = 3; i < n + 1; ++i)
        {
            long temp = fCurrent;

            fCurrent = (fCurrent + fPrevious + 2 * pCurrent) % MOD;

            pCurrent = (pCurrent + fPrevious) % MOD;

            fPrevious = temp;
        }

        return (int)fCurrent;
    }

    private static int NumTilingsDynamicProgrammingBottomUp(int n)
    {
        // Handle base case scenarios
        if (n <= 2)
        {
            return n;
        }

        // f[i]: number of ways to 'fully cover a board' of width k
        long[] f = new long[n + 1];

        // p[i]: number of ways to 'partially cover a board' of width k
        long[] p = new long[n + 1];

        // Initialise f and p with results for base case scenarios
        f[1] = 1L;
        f[2] = 2L;
        p[2] = 1L;

        for (int i = 3; i < n + 1; ++i)
        {
            f[i] = (f[i - 1] + f[i - 2] + 2 * p[i - 1]) % MOD;
            p[i] = (p[i - 1] + f[i - 2]) % MOD;
        }

        return (int)f[n];
    }

    private int NumTilingsDynamicProgrammingTopDown(int n)
    {
        return (int)f(n);
    }

    private long p(int n)
    {
        if (_pCache.TryGetValue(n, out var pValue))
        {
            return pValue;
        }

        long val;

        if (n == 2)
        {
            val = 1L;
        }
        else
        {
            val = (p(n - 1) + f(n - 2)) % MOD;
        }

        _pCache.Add(n, val);

        return val;
    }

    private long f(int n)
    {
        if (_fCache.TryGetValue(n, out var fValue))
        {
            return fValue;
        }

        long val;

        if (n == 1)
        {
            val = 1L;
        }
        else if (n == 2)
        {
            val = 2L;
        }
        else
        {
            val = (f(n - 1) + f(n - 2) + 2 * p(n - 1)) % MOD;
        }

        _fCache.Add(n, val);

        return val;
    }
}