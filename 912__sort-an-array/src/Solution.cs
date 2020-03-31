using System;

namespace sort_an_array
{
    public class Solution
    {
        //public int[] SortArray(int[] nums)
        //{
        //    Array.Sort(nums);
        //    return nums;
        //}

        public int[] SortArray(int[] nums)
        {
            // 非比较排序，计数排序。
            var min = -50000;
            var max = 50000;
            foreach (var n in nums)
            {
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }

            var counter = new int[max - min + 1];
            foreach (var n in nums)
            {
                counter[n - min]++;
            }

            var res = new int[nums.Length];
            var idx = 0;
            for (int num = min; num <= max; num++)
            {
                while (counter[num-min] > 0)
                {
                    counter[num - min]--;
                    res[idx++] = num;
                }
            }
            return res;
        }
    }
}
