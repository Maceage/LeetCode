namespace LeetCode.Problems.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/n-th-tribonacci-number
/// </summary>
public class NthTribonacciNumberProblem
{
    public int Tribonacci(int n)
    {
        return TribonacciSliding(n);
        return TribonacciArray(n);
    }

    private int TribonacciSliding(int n)
    {
        if (n < 3)
        {
            return n > 0 ? 1 : 0;
        }

        int a = 0;
        int b = 1;
        int c = 1;

        for (int i = 0; i < n - 2; ++i)
        {
            int tmp = a + b + c;

            a = b;
            b = c;
            c = tmp;
        }

        return c;
    }

    private int TribonacciArray(int n)
    {
        int[] numberArray = new int[n + 3];

        numberArray[0] = 0;
        numberArray[1] = 1;
        numberArray[2] = 1;

        for (int i = 3; i < numberArray.Length; i++)
        {
            int firstIndex = i - 3;
            int secondIndex = i - 2;
            int thirdIndex = i - 1;

            int first = numberArray[firstIndex];
            int second = numberArray[secondIndex];
            int third = numberArray[thirdIndex];

            numberArray[i] = first + second + third;
        }

        return numberArray[n];
    }
}