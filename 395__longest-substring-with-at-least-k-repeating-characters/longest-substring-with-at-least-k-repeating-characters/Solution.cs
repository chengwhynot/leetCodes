namespace longest_substring_with_at_least_k_repeating_characters
{
    public class Solution
    {
        /// <summary>
        /// 统计字符串中每一个字符重复的次数
        /// 然后遍历s，用第一个重复次数小于k的字符分割为左右两个子字符串
        /// 重复调用这个函数，入参分别为左、右子字符串，返回值为左右子结果的最大值
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LongestSubstring(string s, int k)
        {
            int res = 0;
            if (s.Length == 0)
                return res;

            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 1);
                }
                else
                {
                    map[c]++;
                }
            }
            int idx = -1;
            foreach (var m in map)
            {
                if( (int)m.Value < k)
                {
                    idx = s.IndexOf(m.Key);
                }
            }
            if (idx == -1) return s.Length;

            var left = s.Substring(0, idx);
            var right = s.Substring(idx + 1);
            res = Math.Max(LongestSubstring(left, k), LongestSubstring(right, k));
            return res;
        }
    }
}