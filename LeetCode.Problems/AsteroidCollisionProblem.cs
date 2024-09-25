namespace LeetCode.Problems;

public class AsteroidCollisionProblem
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        foreach (int asteroid in asteroids)
        {
            bool shouldAdd = true;

            while ((stack.Count != 0) && (stack.Peek() > 0 && asteroid < 0))
            {
                int previousPositive = Math.Abs(stack.Peek());
                int currentPositive = Math.Abs(asteroid);

                if (previousPositive < currentPositive)
                {
                    stack.Pop();
                    continue;
                }

                if (previousPositive == currentPositive)
                {
                    stack.Pop();
                }

                shouldAdd = false;
                break;
            }

            if (shouldAdd)
            {
                stack.Push(asteroid);
            }
        }

        List<int> result = stack.ToList();

        result.Reverse();

        return result.ToArray();
    }
}