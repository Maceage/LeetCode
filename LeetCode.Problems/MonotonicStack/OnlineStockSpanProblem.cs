namespace LeetCode.Problems.MonotonicStack;

public class OnlineStockSpanProblem
{
    public class StockSpanner
    {
        private readonly Stack<int[]> _stockPrices = new();

        public int Next(int price)
        {
            int stockSpan = 1;

            while (_stockPrices.Count > 0 && _stockPrices.Peek()[0] <= price)
            {
                stockSpan += _stockPrices.Pop()[1];
            }

            _stockPrices.Push([price, stockSpan]);

            return stockSpan;
        }
    }
}