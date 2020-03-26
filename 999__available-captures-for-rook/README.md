# 999. [车的可用捕获量](https://leetcode-cn.com/problems/available-captures-for-rook/)

在一个 8 x 8 的棋盘上，有一个白色车（rook）。也可能有空方块，白色的象（bishop）和黑色的卒（pawn）。它们分别以字符 “R”，“.”，“B” 和 “p” 给出。大写字符表示白棋，小写字符表示黑棋。

车按国际象棋中的规则移动：它选择四个基本方向中的一个（北，东，西和南），然后朝那个方向移动，直到它选择停止、到达棋盘的边缘或移动到同一方格来捕获该方格上颜色相反的卒。另外，车不能与其他友方（白色）象进入同一个方格。

返回车能够在一次移动中捕获到的卒的数量。

## 代码

相当直接暴力，没有一点花活

```csharp
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
```

## 测试

测试数据构建比较烦

```csharp
namespace available_captures_for_rook_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var board= new char[][]{
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var sut = new Solution();
            var actual = sut.NumRookCaptures(board);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var board = new char[][]{
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var sut = new Solution();
            var actual = sut.NumRookCaptures(board);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var board = new char[][]{
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { 'p', 'p', '.', 'R', '.', 'p', 'B', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'B', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var sut = new Solution();
            var actual = sut.NumRookCaptures(board);
            Assert.AreEqual(3, actual);
        }
    }
}
```

## 结果

执行结果：通过  
执行用时 :100 ms, 在所有 C# 提交中击败了85.71%的用户  
内存消耗 :24.1 MB, 在所有 C# 提交中击败了100.00%的用户  