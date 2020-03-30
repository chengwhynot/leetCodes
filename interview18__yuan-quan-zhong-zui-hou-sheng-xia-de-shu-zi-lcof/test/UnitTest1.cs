using Microsoft.VisualStudio.TestTools.UnitTesting;
using yuan_quan_zhong_zui_hou_sheng_xia_de_shu_zi_lcof;

namespace yuan_quan_zhong_zui_hou_sheng_xia_de_shu_zi_lcof_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(5, 3, 3)]
        [DataRow(10, 17, 2)]
        public void TestMethod1(int n, int m, int expected)
        {
            var sut = new Solution();
            var actual = sut.LastRemaining(n, m);
            Assert.AreEqual(expected, actual);
        }
    }
}
