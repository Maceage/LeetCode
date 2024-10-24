namespace LeetCode.Problems.MonotonicStack;

/// <summary>
/// https://leetcode.com/problems/daily-temperatures
/// </summary>
public class DailyTemperaturesProblem
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        return DailyTemperaturesArrayOptimisedSpace(temperatures);
        return DailyTemperaturesMonotonicStack(temperatures);
        return DailyTemperaturesBruteForce(temperatures);
    }

    private static int[] DailyTemperaturesArrayOptimisedSpace(int[] temperatures)
    {
        int n = temperatures.Length;
        int hottest = 0;
        int[] answer = new int[n];

        for (int currentDay = n - 1; currentDay >= 0; currentDay--)
        {
            int currentTemp = temperatures[currentDay];

            if (currentTemp >= hottest)
            {
                hottest = currentTemp;
                continue;
            }

            int days = 1;

            while (temperatures[currentDay + days] <= currentTemp)
            {
                days += answer[currentDay + days];
            }

            answer[currentDay] = days;
        }

        return answer;
    }

    private static int[] DailyTemperaturesMonotonicStack(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] answer = new int[n];

        Stack<int> stack = new Stack<int>();

        for (int currentDay = 0; currentDay < n; currentDay++)
        {
            int currentTemp = temperatures[currentDay];

            while ((stack.Count > 0) && (temperatures[stack.Peek()] < currentTemp))
            {
                int previousDay = stack.Pop();

                answer[previousDay] = currentDay - previousDay;
            }

            stack.Push(currentDay);
        }

        return answer;
    }

    private static int[] DailyTemperaturesBruteForce(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] answer = new int[n];

        for (int day = 0; day < n; day++)
        {
            for (int futureDay = day + 1; futureDay < n; futureDay++)
            {
                if (temperatures[futureDay] > temperatures[day])
                {
                    answer[day] = futureDay - day;
                    break;
                }
            }
        }

        return answer;
    }
}