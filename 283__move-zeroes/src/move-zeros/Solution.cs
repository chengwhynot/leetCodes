using System;

namespace move_zeros
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null)
                return;
            int i = 0;
            int j = 0;
            while (j < nums.Length)
            {
                if (nums[j] != 0)
                {
                    int tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                    i++;
                }
                j++;
            }
        }
    }
}
