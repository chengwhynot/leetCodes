using System;

namespace RemoveDuplicates
{
    public class Solution
    {
        //public int RemoveDuplicates(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    int i = 0;
        //    for (int j = 1; j < nums.Length; j++)
        //    {
        //        if (nums[j] != nums[i])
        //        {
        //            i++;
        //            nums[i] = nums[j];
        //        }
        //    }
        //    return i + 1;
        //}


        public int RemoveDuplicates(int[] nums)
        {
            int i, j, count;
            count = 0;
            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        int t = nums[j];
                        nums[j] = nums[i];
                        nums[i] = t;
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
