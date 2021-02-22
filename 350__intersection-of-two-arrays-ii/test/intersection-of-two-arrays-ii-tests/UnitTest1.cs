using Microsoft.VisualStudio.TestTools.UnitTesting;
using intersection_of_two_arrays_ii;

namespace intersection_of_two_arrays_ii_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 1, 2, 1, 2 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        [DataRow(new int[] { 4, 9, 5 }, new int[] { 9, 4, 8, 4 }, new int[] { 4, 9 })]
        [TestMethod]
        public void TestMethod1(int[] nums1, int[] nums2, int[] expected)
        {
            var sut = new Solution();
            var actual = sut.Intersect(nums1, nums2);
            System.Array.Sort(expected);
            System.Array.Sort(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
