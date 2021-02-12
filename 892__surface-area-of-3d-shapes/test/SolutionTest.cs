using Microsoft.VisualStudio.TestTools.UnitTesting;
using surface_area_of_3d_shapes;

namespace surface_area_of_3d_shapes_tests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void null_grid_should_return_0()
        {
            var sut = new Solution();
            var actual = sut.SurfaceArea(null);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void empty_grid_should_return_0()
        {
            var sut = new Solution();
            var actual = sut.SurfaceArea(new int[][] { });
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void grid_1_by_1_cubes_2_should_return_2()
        {
            var grid = new int[][] { new int[] { 2 } };

            var sut = new Solution();
            var actual = sut.SurfaceArea(grid);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void grid_2_by_2_cubes_10_should_return_34()
        {
            var grid = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

            var sut = new Solution();
            var actual = sut.SurfaceArea(grid);
            Assert.AreEqual(34, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var grid = new int[][] { new int[] { 1, 0 }, new int[] { 0, 2 } };

            var sut = new Solution();
            var actual = sut.SurfaceArea(grid);
            Assert.AreEqual(16, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var grid = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };

            var sut = new Solution();
            var actual = sut.SurfaceArea(grid);
            Assert.AreEqual(32, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var grid = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 1, 2 }, new int[] { 2, 2, 2 } };

            var sut = new Solution();
            var actual = sut.SurfaceArea(grid);
            Assert.AreEqual(46, actual);
        }
    }
}
