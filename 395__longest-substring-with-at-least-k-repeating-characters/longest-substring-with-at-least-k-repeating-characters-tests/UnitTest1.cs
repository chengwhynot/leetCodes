namespace longest_substring_with_at_least_k_repeating_characters_tests
{
    using longest_substring_with_at_least_k_repeating_characters;

    [TestClass]
    public class UnitTest1
    {
        [DataRow("aaabb", 3, 3)]
        [DataRow("ababbc", 2, 5)]
        [TestMethod]
        public void TestMethod1(string s, int k, int exp)
        {
            Solution sut = new Solution();
            int act = sut.LongestSubstring(s, k);
            Assert.AreEqual(exp, act);
        }
    }
}