using Microsoft.VisualStudio.TestTools.UnitTesting;
using middle_of_the_linked_list;
using System.Collections.Generic;

namespace middle_of_the_linked_list_tests
{
    [TestClass]
    public class UnitTest1
    {
        private ListNode ConvertNodes(int[] array)
        {
            var nodes = new List<ListNode>();

            for (int i = 0; i < array.Length; i++)
            {
                var n = new ListNode(array[i]);
                nodes.Add(n);
            }
            nodes.Add(null);

            for (int i = 0; i < array.Length; i++)
            {
                nodes[i].next = nodes[i + 1];
            }
            return nodes[0];
        }

        [TestMethod]
        public void TestMethod1()
        {
            var node = ConvertNodes(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(node.next.val, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = ConvertNodes(new int[] { 1, 2, 3, 4, 5 });
            var sut = new Solution();
            var expected = node.next.next;
            var actual = sut.MiddleNode(node);
            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var node = ConvertNodes(new int[] { 1, 2, 3, 4, 5, 6});
            var sut = new Solution();
            var actual = sut.MiddleNode(node);
            Assert.AreEqual(4, actual.val);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var node = ConvertNodes(new int[] { 1 });
            var sut = new Solution();
            var actual = sut.MiddleNode(node);
            Assert.AreEqual(1, actual.val);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var node = ConvertNodes(new int[] {  });
            var sut = new Solution();
            var actual = sut.MiddleNode(node);
            Assert.AreEqual(null, null);
        }
    }
}
