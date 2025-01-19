namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/logger-rate-limiter
/// </summary>
public class LoggerRateLimiterProblem
{
    public class Logger
    {
        private readonly Dictionary<string, int> _messagesDictionary = new();

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            bool shouldPrint = false;

            if (!_messagesDictionary.TryAdd(message, timestamp))
            {
                int lastTimeStamp = _messagesDictionary[message];

                int calculatedTimestamp = lastTimeStamp + 10;

                if (timestamp >= calculatedTimestamp)
                {
                    _messagesDictionary.Remove(message);

                    _messagesDictionary.Add(message, timestamp);

                    shouldPrint = true;
                }
            }
            else
            {
                shouldPrint = true;
            }

            return shouldPrint;
        }
    }
}