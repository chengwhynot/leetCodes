using best_time_to_buy_and_sell_stock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace best_time_to_buy_and_sell_stock_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(0, new int[] { })]
        [DataRow(0, new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        [DataRow(6, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [DataRow(5, new int[] { 7, 1, 5, 3, 6, 4 })]
        [DataRow(1, new int[] { 4, 5, 3, 4, 2, 3 })]
        [TestMethod]
        public void TestMethod1(int expected, int[] prices)
        {
            var sut = new Solution();
            var actual = sut.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
    }
}
