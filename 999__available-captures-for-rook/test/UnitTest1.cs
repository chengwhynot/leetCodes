using available_captures_for_rook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
