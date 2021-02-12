using System;

namespace best_time_to_buy_and_sell_stock_ii
{
    public class Solution
    {
        /// <summary>
        /// 可以多次买卖，贪婪算法实现
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    profit += (prices[i + 1] - prices[i]);
                }
            }
            return profit;
        }
    }
}
