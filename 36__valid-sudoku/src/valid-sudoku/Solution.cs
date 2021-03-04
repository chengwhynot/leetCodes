using System;

namespace valid_sudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            if (board == null) return false;
            int[,] row = new int[9, 10];
            int[,] col = new int[9, 10];
            int[,] cub = new int[9, 10];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;
                    var number = board[i][j]-'0';
                    var cube = i / 3 + (j / 3) * 3;
                    if (row[i, number] > 0) return false;
                    if (col[j, number] > 0) return false;
                    if (cub[cube, number] > 0) return false;
                    row[i, number] = 1;
                    col[j, number] = 1;
                    cub[cube, number] = 1;
                }
            }
            return true;
        }
    }
}
