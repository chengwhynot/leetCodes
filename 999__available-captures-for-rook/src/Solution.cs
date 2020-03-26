using System;

namespace available_captures_for_rook
{
    public class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            // 找到R坐标
            // 依次往四个方向寻找下一个相邻的非空元素是否为p。如果是+1

            int Rx = 0;
            int Ry = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        Rx = i;
                        Ry = j;
                    }
                }
            }

            int res = 0;

            //往上，x--
            for (int i = Rx - 1; i > 0; i--)
            {
                if (board[i][Ry] == 'B')
                    break;

                if (board[i][Ry] == 'p')
                {
                    res = res + 1;
                    break;
                }
            }

            //往下，x++
            for (int i = Rx + 1; i < 8; i++)
            {
                if (board[i][Ry] == 'B')
                    break;

                if (board[i][Ry] == 'p')
                {
                    res = res + 1;
                    break;
                }
            }

            //往左，y--
            for (int i = Ry - 1; i > 0; i--)
            {
                if (board[Rx][i] == 'B')
                    break;

                if (board[Rx][i] == 'p')
                {
                    res = res + 1;
                    break;
                }
            }

            //往右，y++
            for (int i = Ry + 1; i < 8; i++)
            {
                if (board[Rx][i] == 'B')
                    break;

                if (board[Rx][i] == 'p')
                {
                    res = res + 1;
                    break;
                }
            }

            return res;
        }
    }
}
