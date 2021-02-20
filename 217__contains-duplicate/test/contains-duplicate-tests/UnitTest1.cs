using Microsoft.VisualStudio.TestTools.UnitTesting;
using contains_duplicate;

namespace contains_duplicate_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 1, 2, 3, 1 }, true)]
        [DataRow(new int[] { 1, 2, 3 }, false)]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { }, false)]
        [TestMethod]
        public void TestMethod1(int[] nums, bool expected)
        {
            var sut = new Solution();
            var actual = sut.ContainsDuplicate(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
