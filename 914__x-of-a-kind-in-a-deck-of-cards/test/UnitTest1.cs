using Microsoft.VisualStudio.TestTools.UnitTesting;
using x_of_a_kind_in_a_deck_of_cards;

namespace x_of_a_kind_in_a_deck_of_cards_test
{
    [TestClass]
    public class UnitTest1
    {
        /*
        示例 1：
            
        输入：[1,2,3,4,4,3,2,1]
        输出：true
        解释：可行的分组是 [1,1]，[2,2]，[3,3]，[4,4]
        
        示例 2：

        输入：[1,1,1,2,2,2,3,3]
        输出：false
        解释：没有满足要求的分组。
        示例 3：

        输入：[1]
        输出：false
        解释：没有满足要求的分组。
        示例 4：

        输入：[1,1]
        输出：true
        解释：可行的分组是 [1,1]
        示例 5：

        输入：[1,1,2,2,2,2]
        输出：true
        解释：可行的分组是 [1,1]，[2,2]，[2,2]
        */
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, true)]
        [DataRow(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 }, false)]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { 1, 1 }, true)]
        [DataRow(new int[] { 1, 1, 2, 2, 2, 2 }, true)]
        [DataRow(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }, true)]
        [DataRow(new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, true)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 1, 2, 2, 3, 4 }, false)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7 }, true)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 3, 4 }, false)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 6, 6, 7, 7, 8, 8 }, true)]
        public void TestMethod1(int[] deck, bool expected)
        {
            var sut = new Solution();
            var actual = sut.HasGroupsSizeX(deck);
            Assert.AreEqual(expected, actual);
        }
    }
}
