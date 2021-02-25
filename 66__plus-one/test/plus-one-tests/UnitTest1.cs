using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace plus_one_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [DataRow(new int[] { 0 }, new int[] { 1 })]
        [DataRow(new int[] { 9 }, new int[] { 1, 0 })]
        [DataRow(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
        [TestMethod]
        public void TestMethod1(int[] nums, int[] expected)
        {
            var sut = new plus_one.Solution();
            var actual = sut.PlusOne(nums);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
