namespace best_time_to_buy_and_sell_stock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = solution.MaxProfit(prices);
            Console.WriteLine($"Максимальная прибыль: {maxProfit}"); 
        }
    }
}