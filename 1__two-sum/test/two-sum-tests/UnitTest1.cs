using Microsoft.VisualStudio.TestTools.UnitTesting;
using two_sum;

namespace two_sum_tests
{
    [TestClass]
    public class UnitTest1
    {

        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 2, 5, 5, 11 }, 10, new int[] { 2, 1 })]
        [TestMethod]
        public void TestMethod1(int[] nums, int target, int[] expected)
        {
            var sut = new Solution();
            var actual = sut.TwoSum(nums, target);
            System.Array.Sort(expected);
            System.Array.Sort(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
