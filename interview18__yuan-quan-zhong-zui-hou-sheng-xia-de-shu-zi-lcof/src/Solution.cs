using System;

namespace yuan_quan_zhong_zui_hou_sheng_xia_de_shu_zi_lcof
{
    public class Solution
    {
        public int LastRemaining(int n, int m)
        {
            int ans = 0;
            // 最后一轮剩下2个人，所以从2开始反推
            for (int i = 2; i <= n; i++)
            {
                ans = (ans + m) % i;
            }
            return ans;
        }
    }
}
