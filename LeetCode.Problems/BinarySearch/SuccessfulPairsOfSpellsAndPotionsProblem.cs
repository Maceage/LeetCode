namespace LeetCode.Problems.BinarySearch;

public class SuccessfulPairsOfSpellsAndPotionsProblem
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        return SuccessfulPairsSortingTwoPointers(spells, potions, success);
        return SuccessfulPairsSortingBinarySearch(spells, potions, success);
    }

    private static int[] SuccessfulPairsSortingTwoPointers(int[] spells, int[] potions, long success)
    {
        int numberOfSpells = spells.Length;
        int numberOfPotions = potions.Length;

        int[][] sortedSpells = new int[numberOfSpells][];

        for (int i = 0; i < numberOfSpells; i++)
        {
            sortedSpells[i] = [spells[i], i];
        }

        System.Array.Sort(sortedSpells, (a,b) => a[0].CompareTo(b[0]));
        System.Array.Sort(potions);

        int[] answer = new int[numberOfSpells];
        int potionIndex = numberOfPotions - 1;

        foreach (int[] sortedSpell in sortedSpells)
        {
            int spell = sortedSpell[0];
            int index = sortedSpell[1];

            while (potionIndex >= 0 && (long)spell * potions[potionIndex] >= success)
            {
                potionIndex -= 1;
            }

            answer[index] = numberOfPotions - (potionIndex + 1);
        }

        return answer;
    }

    private static int[] SuccessfulPairsSortingBinarySearch(int[] spells, int[] potions, long success)
    {
        int numberOfSpells = spells.Length;

        int[] pairs = new int[numberOfSpells];

        System.Array.Sort(potions);

        int numberOfPotions = potions.Length;
        int maxPotion = potions[numberOfPotions - 1];

        for (int i = 0; i < numberOfSpells; i++)
        {
            int spell = spells[i];

            // Minimum value of potion whose product with current spell will be at least success or more
            long minPotion = (long)Math.Ceiling((1.0 * success) / spell);

            // Check if we don't have any potion which can be used
            if (minPotion > maxPotion)
            {
                pairs[i] = 0;
                continue;
            }

            // We can use the found potion, and all potion in its right
            // (as the right potions are greater than the found potion)
            int index = LowerBound(potions, (int)minPotion);

            pairs[i] = numberOfPotions - index;
        }

        return pairs;
    }

    private static int LowerBound(int[] array, int key)
    {
        int low = 0;
        int high = array.Length;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] < key)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
}