using reverse_integer;

namespace reverse_integer_tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(0,0)]
        [DataRow(123, 321)]
        [DataRow(int.MaxValue, 0)]
        [DataRow(int.MinValue, 0)]
        [DataRow(1463847412, 2147483641)]
        [TestMethod]
        public void TestMethod1(int x, int exptected)
        {
            var sut = new Solution();
            var act = sut.Reverse(x);
            Assert.AreEqual(exptected, act);
        }
    }
}