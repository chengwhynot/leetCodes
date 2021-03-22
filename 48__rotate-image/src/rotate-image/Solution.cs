using System;

namespace rotate_image
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            // 因为：matrix[row][col] ==> matrix[n-col][row]
            var n = matrix.GetLength(0);
            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = 0; j < (n + 1) / 2; ++j)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[n - j - 1][i];
                    matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                    matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                    matrix[j][n - i - 1] = temp;
                }
            }
        }
    }
}
