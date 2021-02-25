using Microsoft.VisualStudio.TestTools.UnitTesting;
using move_zeros;

namespace move_zeros_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 0, 4, 3, 0, 2 }, new int[] { 4, 3, 2, 0, 0 })]
        [TestMethod]
        public void TestMethod1(int[] nums, int[] expected)
        {
            var sut = new Solution();
            sut.MoveZeroes(nums);
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}
