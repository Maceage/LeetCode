namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/happy-number
/// </summary>
public class HappyNumberProblem
{
    public bool IsHappy(int n)
    {
        return IsHappyHardcodingOnlyCycle(n);
        return IsHappyFloydCycleFindingAlgorithm(n);
        return IsHappyOriginal(n);
    }

    private static bool IsHappyHardcodingOnlyCycle(int n)
    {
        HashSet<int> cycleMembers = [4, 16, 37, 58, 89, 145, 42, 20];

        while (n != 1 && !cycleMembers.Contains(n))
        {
            n = CalculateSumOfDigitSquares(n);
        }

        return n == 1;
    }

    private static bool IsHappyFloydCycleFindingAlgorithm(int n)
    {
        int slowRunner = n;
        int fastRunner = CalculateSumOfDigitSquares(n);

        while (fastRunner != 1 && slowRunner != fastRunner)
        {
            slowRunner = CalculateSumOfDigitSquares(slowRunner);
            fastRunner = CalculateSumOfDigitSquares(CalculateSumOfDigitSquares(fastRunner));
        }

        return fastRunner == 1;
    }

    private static bool IsHappyOriginal(int n)
    {
        bool isHappy = false;

        HashSet<int> previousSums = new HashSet<int>();

        int sum = CalculateSumOfDigitSquares(n);

        while (!previousSums.Contains(sum))
        {
            previousSums.Add(sum);

            sum = CalculateSumOfDigitSquares(sum);

            if (sum == 1)
            {
                isHappy = true;
                break;
            }
        }
        
        return isHappy;
    }

    private static int CalculateSumOfDigitSquares(int n)
    {
        int result = 0;

        while (n > 0)
        {
            int digit = n % 10;

            n = n / 10;

            int x = digit * digit;

            result += x;
        }

        return result;
    }
}