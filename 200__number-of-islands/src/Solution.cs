using System;

namespace number_of_islands
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        FlushIsland(i, j, grid);
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// 相邻联结的节点如果是陆地，置为0，避免重复计算
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        static void FlushIsland(int i, int j, char[][] grid)
        {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid[i].Length)
            {
                return;
            }
            if (grid[i][j] == '1')
            {
                grid[i][j] = '0';

                FlushIsland(i - 1, j, grid);
                FlushIsland(i + 1, j, grid);
                FlushIsland(i, j - 1, grid);
                FlushIsland(i, j + 1, grid);
            }
            return;
        }
    }
}