using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace valid_sudoku_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            var expected = true;

            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(displayName: "������Ӧ�÷��� true ")]
        public void TestMethod2()
        {
            var board = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            var expected = true;
            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(displayName: "��һ��cube���ظ����֣�Ӧ���� false ")]
        public void TestMethod3()
        {
            var board = new char[][]
            {
                new char[] { '9', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            var expected = false;
            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(displayName: "��һ�����ظ����֣�Ӧ���� false ")]
        public void TestMethod4()
        {
            var board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '5', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            var expected = false;
            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(displayName: "��һ�����ظ����֣�Ӧ���� false ")]
        public void TestMethod5()
        {
            var board = new char[][]
            {
                new char[] { '6', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '1', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            var expected = false;
            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(displayName: "null ���̣�Ӧ���� false ")]
        public void TestMethod6()
        {
            char[][] board = null;
            var expected = false;
            var sut = new valid_sudoku.Solution();
            var actual = sut.IsValidSudoku(board);
            Assert.AreEqual(expected, actual);
        }
    }
}
