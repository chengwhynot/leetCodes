using compress_string_lcci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace compress_string_lcci_test
{
    [TestClass]
    public class CompressStringTests
    {
        [TestMethod]
        [DataRow("aabcccccaa", "a2b1c5a2")]
        [DataRow("abbccd", "abbccd")]
        [DataRow("bb", "bb")]
        public void TestMethod(string S, string expected)
        {
            var sut = new Solution();
            var actual = sut.CompressString(S);
            Assert.AreEqual(expected, actual);
        }
    }
}
