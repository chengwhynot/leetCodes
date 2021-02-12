using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace minimum_increment_to_make_array_unique.tests
{
    [TestClass()]
    public class minimum_increment_to_make_array_unique_tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            var A = new int[] { 1, 2, 2 };
            var expected = 1;
            var sut = new Solution();
            var actual = sut.minIncrementForUnique(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            var A = new int[] { 3, 2, 1, 2, 1, 7 };
            var expected = 6;
            var sut = new Solution();
            var actual = sut.minIncrementForUnique(A);
            Assert.AreEqual(expected, actual);
        }
    }
}
