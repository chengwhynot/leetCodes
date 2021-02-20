using Microsoft.VisualStudio.TestTools.UnitTesting;
using single_number;

namespace single_number_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 4 }, 4)]
        [DataRow(new int[] { 2, 2, 1 }, 1)]
        [DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [TestMethod]
        public void TestMethod1(int[] nums, int expected)
        {
            var sut = new Solution();
            var actual = sut.SingleNumber(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}