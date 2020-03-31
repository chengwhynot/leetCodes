using Microsoft.VisualStudio.TestTools.UnitTesting;
using sort_an_array;

namespace sort_an_array_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] { 5, 2, 3, 1 }, new int[] { 1, 2, 3, 5 })]
        [DataRow(new int[] { 5, 1, 1, 2, 0, 0 }, new int[] { 0, 0, 1, 1, 2, 5 })]
        public void TestMethod1(int[] nums, int[] expected)
        {
            var sut = new Solution();
            var actual = sut.SortArray(nums);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
