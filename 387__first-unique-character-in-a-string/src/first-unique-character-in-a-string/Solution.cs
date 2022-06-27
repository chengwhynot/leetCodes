using System;

namespace first_unique_character_in_a_string
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            System.Collections.Generic.Dictionary<char, int> dict = new System.Collections.Generic.Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = -1;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
