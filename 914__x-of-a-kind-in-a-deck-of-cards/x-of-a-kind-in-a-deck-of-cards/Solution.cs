using System;
using System.Collections.Generic;

namespace x_of_a_kind_in_a_deck_of_cards
{
    public class Solution
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            // 计数
            int[] counter = new int[10000];
            foreach (int num in deck)
            {
                counter[num]++;
            }
            // 迭代求多个数的最大公约数
            int x = 0;
            foreach (int cnt in counter)
            {
                if (cnt > 0)
                {
                    x = gcd(x, cnt);
                    if (x == 1)
                    { // 如果某步中gcd是1，直接返回false
                        return false;
                    }
                }
            }
            return x >= 2;
        }

        int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
