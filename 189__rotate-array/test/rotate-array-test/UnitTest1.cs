using Microsoft.VisualStudio.TestTools.UnitTesting;
using rotate_array;

namespace rotate_array_test
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [DataRow(new int[] { 1 }, 1, new int[] { 1 })]
        [DataRow(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { }, 1, new int[] { })]
        [DataRow(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 })]
        [DataRow(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        [TestMethod]
        public void TestMethod1(int[] nums, int k, int[] expected)
        {
            var sut = new Solution();
            sut.Rotate1(nums, k);
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}
