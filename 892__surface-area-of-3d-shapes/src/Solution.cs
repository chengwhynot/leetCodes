using System;

namespace surface_area_of_3d_shapes
{
    public class Solution
    {
        public int SurfaceArea(int[][] grid)
        {
            if (grid == null || grid.GetLength(0) == 0 || grid[0].Length == 0)
                return 0;

            // 遍历每一个坐标，累计有多少个立方体 m。
            // 计算一共有多少个贴上的立方体 n，包括：
            // 与右边、下边的邻居有多少个相邻立方体 。
            // 以及每个单元格上，纵轴z上有多少个贴上的立方体。
            // 每一个相邻立方体，需要减去2个重合表面。
            // 即：表面积 = 6*m - 2*n

            int x = grid.GetLength(0);
            int y = grid[0].Length;
            int m = 0;
            int n = 0;

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    m += grid[i][j];
                    if (i + 1 < grid[0].Length) //x轴上，有多少个和右边贴上的立方体
                    {
                        n += Math.Min(grid[i][j], grid[i + 1][j]);
                    }
                    if (j + 1 < grid[i].Length) //y轴上，有多少个和右边贴上的立方体
                    {
                        n += Math.Min(grid[i][j], grid[i][j + 1]);
                    }
                    if(grid[i][j] >1) //z轴上，有多少个贴上的立方体
                    {
                        n += grid[i][j] -1;
                    }
                }
            }
            return 6 * m - 2 * n;
        }
    }
}
