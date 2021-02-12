using LCQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LCQueue_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new LCQueue.LCQueue();

            var actual = sut.Size();
            Assert.AreEqual(0, actual);

            sut.Push(52);
            actual = sut.Front();
            Assert.AreEqual(52, actual);

            sut.Push(22);
            actual = sut.Front();
            Assert.AreEqual(52, actual);

            actual = sut.Size();
            Assert.AreEqual(2, actual);

            sut.Pop();

            actual = sut.Front();
            Assert.AreEqual(22, actual);

            sut.Pop();
            actual = sut.Size();
            Assert.AreEqual(0, actual);
        }
    }
}
