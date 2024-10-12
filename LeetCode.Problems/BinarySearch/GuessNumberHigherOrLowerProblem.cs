namespace LeetCode.Problems.BinarySearch;

public class GuessNumberHigherOrLowerProblem
{
    public int PickedNumber { get; set; }

    public int GuessNumber(int n)
    {
        return GuessNumberTernarySearch(n);
        return GuessNumberBinarySearch(n);
        return GuessNumberBruteForce(n);
    }

    private int GuessNumberTernarySearch(int n)
    {
        int low = 1;
        int high = n;

        while (low <= high)
        {
            int mid1 = low + (high - low) / 3;
            int mid2 = high - (high - low) / 3;

            int result1 = guess(mid1);
            int result2 = guess(mid2);

            if (result1 == 0)
            {
                return mid1;
            }

            if (result2 == 0)
            {
                return mid2;
            }

            if (result1 < 0)
            {
                high = mid1 - 1;
            }
            else if (result2 > 0)
            {
                low = mid2 + 1;
            }
            else
            {
                low = mid1 + 1;
                high = mid2 - 1;
            }
        }

        return -1;
    }

    private int GuessNumberBinarySearch(int n)
    {
        int number = -1;

        int low = 1;
        int high = n;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int result = guess(mid);

            if (result == 0)
            {
                number = mid;
                break;
            }

            if (result < 0)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return number;
    }

    private int GuessNumberBruteForce(int n)
    {
        for (int i = 1; i < n; i++)
        {
            if (guess(i) == 0)
            {
                return i;
            }
        }

        return n;
    }

    private int guess(int i)
    {
        int result = 0;

        if (i > PickedNumber)
        {
            result = -1;
        }

        if (i < PickedNumber)
        {
            result = 1;
        }

        if (i == PickedNumber)
        {
            result = 0;
        }

        return result;
    }
}