using Microsoft.VisualStudio.TestTools.UnitTesting;
using first_unique_character_in_a_string;

namespace first_unique_character_in_a_string_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("leetcode", 0)]
        [DataRow("loveleetcode", 2)]
        [DataRow("aabb", -1)]
        [TestMethod]
        public void TestMethod1(string s, int expected)
        {
            Solution sut = new Solution();
            var actual = sut.FirstUniqChar(s);
            Assert.AreEqual(expected: expected, actual: actual);
        }
    }
}
