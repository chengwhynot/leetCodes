using System;

namespace intersection_of_two_arrays_ii
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                Intersect(nums2, nums1);
            var h = new System.Collections.Generic.Dictionary<int, int>(nums1.Length);
            foreach (var item in nums1)
            {
                if (!h.ContainsKey(item))
                    h.Add(item, 1);
                else
                    h[item] = h[item] + 1;
            }
            int k = 0;
            int[] intersections = new int[nums1.Length];

            for (int i = 0; i < nums2.Length; i++)
            {
                if (h.ContainsKey(nums2[i]) && (h[nums2[i]] > 0))
                {
                    intersections[k++] = nums2[i];
                    h[nums2[i]] = h[nums2[i]] - 1;
                }
            }
            int[] r = new int[k];
            Array.Copy(intersections, r, k);
            return r;
        }

        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            var h1 = new System.Collections.Hashtable(nums1.Length);
            var h2 = new System.Collections.Hashtable(nums2.Length);
            foreach (var item in nums1)
            {
                if (!h1.ContainsKey(item))
                    h1.Add(item, 1);
                else
                    h1[item] = (int)h1[item] + 1;
            }

            foreach (var item in nums2)
            {
                if (!h2.ContainsKey(item))
                    h2.Add(item, 1);
                else
                    h2[item] = (int)h2[item] + 1;
            }
            var r = new System.Collections.ArrayList();
            foreach (var i in h1.Keys)
            {
                if (h2.Contains(i))
                {
                    var min = Math.Min((int)h1[i], (int)h2[i]);
                    for (int idx = 0; idx < min; idx++)
                    {
                        r.Add(i);
                    }
                }
            }
            int[] result = new int[r.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (int)r[i];
            }
            return result;
        }
    }
}
