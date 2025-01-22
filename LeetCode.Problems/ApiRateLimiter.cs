namespace LeetCode.Problems;

public class ApiRateLimiter(int timeWindow, int numberOfRequests)
{
    private readonly Dictionary<int, CustomerRequest> _customerRequestCount = new();

    public bool RateLimit(int customerId, DateTime requestDateTime)
    {
        bool shouldRateLimit = false;

        if (_customerRequestCount.TryGetValue(customerId, out var customerRequest))
        {
            int requestCount = customerRequest.RequestCount;
            DateTime firstRequestDateTime = customerRequest.FirstRequestDateTime;

            TimeSpan timeDifference = requestDateTime - firstRequestDateTime;

            if ((requestCount > numberOfRequests) && (timeDifference.Seconds > timeWindow))
            {
                customerRequest.RequestCount = 1;
                customerRequest.FirstRequestDateTime = requestDateTime;
            }
            else if ((requestCount >= numberOfRequests) && (timeDifference.Seconds < timeWindow))
            {
                shouldRateLimit = true;
            }
            else
            {
                customerRequest.RequestCount++;
            }
        }
        else
        {
            customerRequest = new CustomerRequest
            {
                FirstRequestDateTime = requestDateTime,
                RequestCount = 1
            };

            _customerRequestCount.Add(customerId, customerRequest);
        }

        return shouldRateLimit;
    }

    private class CustomerRequest
    {
        public DateTime FirstRequestDateTime { get; set; }
        public int RequestCount { get; set; }
    }
}