# 200. 岛屿数量

给定一个由 '1'（陆地）和 '0'（水）组成的的二维网格，计算岛屿的数量。一个岛被水包围，并且它是通过水平方向或垂直方向上相邻的陆地连接而成的。你可以假设网格的四个边均被水包围。

示例 1:

> 输入:

> 11110  
> 11010  
> 11000  
> 00000
>
> 输出: 1

示例 2:

> 输入:  

> 11000  
> 11000  
> 00100  
> 00011
> 
> 输出: 3

## 题解

```csharp
public class Solution {
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
                        grid = flushIsland(i, j, grid);
                    }
                }
            }

            return count;
        }

        static char[][] flushIsland(int i, int j, char[][] grid)
        {
            if (grid[i][j] == '1')
            {
                grid[i][j] = '0';

                if (i > 0)
                    flushIsland(i - 1, j, grid);
                if (i < grid.GetLength(0) - 1)
                    flushIsland(i + 1, j, grid);

                if (j > 0)
                    flushIsland(i, j - 1, grid);
                if (j < grid[i].Length - 1)
                    flushIsland(i, j + 1, grid);
            }

            return grid;
        }
}
```

执行用时：124 ms 战胜 97.73% 的csharp提交记录  
内存消耗：27.6 MB 战胜 15.38% 的csharp提交记录
