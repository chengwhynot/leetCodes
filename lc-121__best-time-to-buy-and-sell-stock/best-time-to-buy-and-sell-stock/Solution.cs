using System;

namespace best_time_to_buy_and_sell_stock
{
    public class Solution
    {
        /// <summary>
        /// 全局只能交易一次的算法
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxprofit)
                    {
                        maxprofit = profit;
                    }
                }
            }
            return maxprofit;
        }
    }
}
