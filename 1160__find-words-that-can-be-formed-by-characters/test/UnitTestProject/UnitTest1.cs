using find_words_that_can_be_formed_by_characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /*
         * ���룺words = ["cat","bt","hat","tree"], chars = "atach"
         * �����6
         * ���ͣ� 
         * �����γ��ַ��� "cat" �� "hat"�����Դ��� 3 + 3 = 6��
        
         * ���룺words = ["hello","world","leetcode"], chars = "welldonehoneyr"
         * �����10
         * ���ͣ�
         * �����γ��ַ��� "hello" �� "world"�����Դ��� 5 + 5 = 10��
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
