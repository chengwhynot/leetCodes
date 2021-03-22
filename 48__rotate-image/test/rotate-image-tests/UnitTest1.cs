using Microsoft.VisualStudio.TestTools.UnitTesting;
using rotate_image;

namespace rotate_image_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var image = new int[][]
{
                new int[] { 1,2,3},
                new int[] { 4,5,6},
                new int[] { 7,8,9}
};
            var expected = new int[][]
{
                new int[] { 7,4,1},
                new int[] { 8,5,2},
                new int[] { 9,6,3}
};

            var sut = new Solution();
            sut.Rotate(image);
            CollectionAssert.AreEquivalent(expected, image);
        }
    }
}
