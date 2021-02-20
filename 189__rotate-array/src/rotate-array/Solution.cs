using System;

namespace rotate_array
{
    public class Solution
    {
        public void Rotate1(int[] nums, int k)
        {
            if (nums.Length <= 1) return;
            if (k % nums.Length == 0) return;

            int[] lengthed_nums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                lengthed_nums[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = lengthed_nums[i];
            }
        }

        public void Rotate2(int[] nums, int k)
        {
            if (nums.Length <= 1) return;
            if (k % nums.Length == 0) return;

            while (k > 0)
            {
                k--;
                int last = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = last;
            }
        }
    }
}
