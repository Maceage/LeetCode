namespace LeetCode.Problems.BitManipulation;

public class SingleNumberProblem
{
    public int SingleNumber(int[] nums)
    {
        return SingleNumberWithBitManipulation(nums);
        return SingleNumberWithMath(nums);
        return SingleNumberWithHashtable(nums);
        return SingleNumberWithLists(nums);
    }

    private static int SingleNumberWithBitManipulation(int[] nums)
    {
        int a = 0;

        foreach (int i in nums)
        {
            a ^= i;
        }

        return a;
    }

    private static int SingleNumberWithMath(int[] nums)
    {
        int sumOfSet = 0;
        int sumOfNums = 0;

        HashSet<int> set = new HashSet<int>();

        foreach (var n in nums)
        {
            if (set.Add(n))
            {
                sumOfSet += n;
            }

            sumOfNums += n;
        }

        return 2 * sumOfSet - sumOfNums;
    }

    private static int SingleNumberWithHashtable(int[] nums)
    {
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!numberCounts.TryAdd(num, 1))
            {
                numberCounts[num]++;
            }
        }

        foreach (int num in nums)
        {
            if (numberCounts[num] == 1)
            {
                return num;
            }
        }

        return 0;
    }

    private static int SingleNumberWithLists(int[] nums)
    {
        List<int> noDuplicatesList = new List<int>();

        foreach (int i in nums)
        {
            if (!noDuplicatesList.Contains(i))
            {
                noDuplicatesList.Add(i);
            }
            else
            {
                noDuplicatesList.Remove(i);
            }
        }

        return noDuplicatesList[0];
    }
}