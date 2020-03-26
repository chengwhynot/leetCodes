# 999. [���Ŀ��ò�����](https://leetcode-cn.com/problems/available-captures-for-rook/)

��һ�� 8 x 8 �������ϣ���һ����ɫ����rook����Ҳ�����пշ��飬��ɫ����bishop���ͺ�ɫ���䣨pawn�������Ƿֱ����ַ� ��R������.������B�� �� ��p�� ��������д�ַ���ʾ���壬Сд�ַ���ʾ���塣

�������������еĹ����ƶ�����ѡ���ĸ����������е�һ�����������������ϣ���Ȼ���Ǹ������ƶ���ֱ����ѡ��ֹͣ���������̵ı�Ե���ƶ���ͬһ����������÷�������ɫ�෴���䡣���⣬�������������ѷ�����ɫ�������ͬһ������

���س��ܹ���һ���ƶ��в��񵽵����������

## ����

�൱ֱ�ӱ�����û��һ�㻨��

```csharp
namespace available_captures_for_rook
{
    public class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            // �ҵ�R����
            // �������ĸ�����Ѱ����һ�����ڵķǿ�Ԫ���Ƿ�Ϊp�������+1

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

            //���ϣ�x--
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

            //���£�x++
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

            //����y--
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

            //���ң�y++
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

## ����

�������ݹ����ȽϷ�

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

## ���

ִ�н����ͨ��  
ִ����ʱ :100 ms, ������ C# �ύ�л�����85.71%���û�  
�ڴ����� :24.1 MB, ������ C# �ύ�л�����100.00%���û�  