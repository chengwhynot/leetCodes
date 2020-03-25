using find_words_that_can_be_formed_by_characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /*
         * 输入：words = ["cat","bt","hat","tree"], chars = "atach"
         * 输出：6
         * 解释： 
         * 可以形成字符串 "cat" 和 "hat"，所以答案是 3 + 3 = 6。
        
         * 输入：words = ["hello","world","leetcode"], chars = "welldonehoneyr"
         * 输出：10
         * 解释：
         * 可以形成字符串 "hello" 和 "world"，所以答案是 5 + 5 = 10。
         */

        [TestMethod]
        [DataRow(new string[] { "hello", "world", "leetcode" }, "", 0)]
        [DataRow(new string[] { "hello", "world", "leetcode" }, "welldonehoneyr", 10)]
        [DataRow(new string[] { "cat", "bt", "hat", "tree" }, "atach", 6)]
        [DataRow(new string[] { }, "", 0)]
        [DataRow(new string[] { }, "starwar", 0)]
        public void TestMethod3(string[] words, string chars, int expected)
        {
            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }
    }
}
