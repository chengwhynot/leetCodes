using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicates;

namespace RemoveDuplicatesTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2 })]
        [DataRow(new int[] { 1, 1, 2, 2, 3 }, 3, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [DataRow(new int[] { }, 0, new int[] { })]
        [TestMethod]
        public void TestMethod1(int[] nums, int exp_len, int[] exp_nums)
        {
            var sut = new Solution();
            var actual = sut.RemoveDuplicates(nums);
            var actual_nums = SubNums(actual, nums);

            Assert.AreEqual(exp_len, actual);
            compareNums(exp_len, exp_nums, actual_nums);
            //Assert.AreEqual(exp_nums, actual_nums);
        }

        private int[] SubNums(int len, int[] nums)
        {
            int[] sub_nums = new int[len];
            for (int i = 0; i < len; i++)
            {
                sub_nums[i] = nums[i];
            }
            return sub_nums;
        }

        private void compareNums(int len, int[] expected, int[] actual)
        {
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
