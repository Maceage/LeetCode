namespace LeetCode.Problems.BinarySearch;

public class KokoEatingBananasProblem
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        //return MinEatingSpeedBruteForce(piles, h);
        return MinEatingSpeedBinarySearch(piles, h);
    }

    private static int MinEatingSpeedBinarySearch(int[] piles, int h)
    {
        int left = 1;
        int right = 1;

        foreach (int pile in piles)
        {
            right = Math.Max(right, pile);
        }

        while (left < right)
        {
            int middle = (left + right) / 2;
            double hourSpent = 0;

            foreach (int pile in piles)
            {
                hourSpent += Math.Ceiling((double)pile / middle);
            }

            if (hourSpent <= h)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return right;
    }

    private static int MinEatingSpeedBruteForce(int[] piles, int h)
    {
        int speed = 1;

        while (true)
        {
            double hourSpent = 0;

            foreach (int pile in piles)
            {
                hourSpent += Math.Ceiling((double)pile / speed);

                if (hourSpent > h)
                {
                    break;
                }
            }

            if (hourSpent <= h)
            {
                return speed;
            }

            speed += 1;
        }
    }
}