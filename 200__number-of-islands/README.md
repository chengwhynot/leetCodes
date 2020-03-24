# 200. ��������

����һ���� '1'��½�أ��� '0'��ˮ����ɵĵĶ�ά���񣬼��㵺���������һ������ˮ��Χ����������ͨ��ˮƽ�����ֱ���������ڵ�½�����Ӷ��ɵġ�����Լ���������ĸ��߾���ˮ��Χ��

ʾ�� 1:

> ����:
> 11110
> 11010
> 11000
> 00000
>
> ���: 1

ʾ�� 2:

> ����:
> 11000
> 11000
> 00100
> 00011
> 
> ���: 3

## ���

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

ִ����ʱ��124 ms սʤ 97.73% ��csharp�ύ��¼  
�ڴ����ģ�27.6 MB սʤ 15.38% ��csharp�ύ��¼