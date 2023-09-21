namespace SeriesLeetCode
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if(prices == null || prices.Length == 0) return 0;

            int maxProfit = 0;

            int minPrice = prices[0];
           
            foreach(int price in prices)
            {
                minPrice = Math.Min(minPrice, price);

                int potentialProfit = price - minPrice;

                maxProfit = Math.Max(maxProfit, potentialProfit);
            }

            return maxProfit;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] prices = { 2, 4, 1 };
            int result = solution.MaxProfit(prices);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

 * Example 2:
    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: In this case, no transactions are done and the max profit = 0.
 */