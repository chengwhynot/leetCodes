using find_words_that_can_be_formed_by_characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass()]
    public class UnitTest1
    {
        /*
         * 输入：words = ["cat","bt","hat","tree"], chars = "atach"
         * 输出：6
         * 解释： 
         * 可以形成字符串 "cat" 和 "hat"，所以答案是 3 + 3 = 6。
        */
        [TestMethod()]
        public void TestMethod1()
        {
            var words = new string[] { "cat", "bt", "hat", "tree" };
            var chars = "atach";
            var expected = 6;

            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }

        /*
         * 输入：words = ["hello","world","leetcode"], chars = "welldonehoneyr"
         * 输出：10
         * 解释：
         * 可以形成字符串 "hello" 和 "world"，所以答案是 5 + 5 = 10。
         */
        [TestMethod()]
        public void TestMethod2()
        {
            var words = new string[] { "hello", "world", "leetcode" };
            var chars = "welldonehoneyr";
            var expected = 10;

            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            var words = new string[] { "hello", "world", "leetcode" };
            var chars = "";
            var expected = 0;

            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            var words = new string[] { };
            var chars = "";
            var expected = 0;

            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod5()
        {
            var words = new string[] { };
            var chars = "starwar";
            var expected = 0;

            Solution sut = new Solution();
            var actual = sut.CountCharacters(words, chars);
            Assert.AreEqual(expected, actual);
        }
    }
}
