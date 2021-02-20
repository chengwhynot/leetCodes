using System;

namespace contains_duplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable(nums.Length);
            foreach (var n in nums)
            {
                if (ht.ContainsKey(n))
                    return true;
                else
                    ht.Add(n, n);
            }
            return false;
        }
    }
}