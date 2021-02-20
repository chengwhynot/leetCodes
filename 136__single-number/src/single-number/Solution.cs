using System;

namespace single_number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int r = 0;

            foreach (var item in nums)
            {
                r ^= item;
            }
            return r;
        }
            public int SingleNumber2(int[] nums)
        {
            System.Collections.Hashtable hash = new System.Collections.Hashtable(nums.Length);
            foreach (var n in nums)
            {
                if (hash.Contains(n))
                    hash.Remove(n);
                else
                    hash.Add(n, 1);
            }
            foreach (var key in hash.Keys)
            {
                return (int)key;
            }
            return 0;
        }
    }
}
