using Microsoft.VisualStudio.TestTools.UnitTesting;
using number_of_islands;

namespace number_of_islands_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var grid = new char[][] { };
            var expected = 0;
            var sut = new Solution();
            var actual = sut.NumIslands(grid);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var grid = new char[][] { 
                new char[] {'1','1','1','1','0' }, 
                new char[] {'1','1','0','1','0' }, 
                new char[] {'1','1','0','0','0' }, 
                new char[] {'0','0','0','0','0' } 
            };

            var expected = 1;
            var sut = new Solution();
            var actual = sut.NumIslands(grid);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var grid = new char[][] {
                new char[] {'1','1','0','0','0' },
                new char[] {'1','1','0','0','0' },
                new char[] {'0','0','1','0','0' },
                new char[] {'0','1','0','1','1' }
            };

            var expected = 4;
            var sut = new Solution();
            var actual = sut.NumIslands(grid);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var grid = new char[][] {
                new char[] {'1','0' },
                new char[] {'0','1' }
            };

            var expected = 2;
            var sut = new Solution();
            var actual = sut.NumIslands(grid);
            Assert.AreEqual(expected, actual);
        }
    }
}
