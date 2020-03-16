using compress_string_lcci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace compress_string_lcci_test
{
    [TestClass()]
    public class CompressStringTests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            var S = "aabcccccaa";
            var expected = "a2b1c5a2";

            var sut = new Solution();
            var actual = sut.CompressString(S);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            var S = "abbccd";
            var expected = "abbccd";

            var sut = new Solution();
            var actual = sut.CompressString(S);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            var S = "bb";
            var expected = "bb";

            var sut = new Solution();
            var actual = sut.CompressString(S);
            Assert.AreEqual(expected, actual);
        }
    }
}
