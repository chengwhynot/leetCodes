using System;

namespace two_sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] r = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        r[0] = i;
                        r[1] = j;
                        return r;
                    }
                }
            }
            return r;
        }
    }
}
