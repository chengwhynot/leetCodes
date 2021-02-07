using Microsoft.VisualStudio.TestTools.UnitTesting;
using remove_linked_list_elements;

namespace remove_linked_list_elements_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void convert_method_are_work_smooth()
        {
            var n = new int[] { 1, 2, 3 };
            var sut = new UnitTest1();
            var actual = sut.convert(n);
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            node1.next = node2;
            node2.next = node3;
            node3.next = null;
            compareNodes(node1, actual);
        }

        private void compareNodes(ListNode n1, ListNode n2)
        {
            Assert.AreEqual(n1.val, n2.val);
            while ((n1.next != null) && (n2.next != null))
            {
                Assert.AreEqual(n1.val, n2.val);
                n1 = n1.next;
                n2 = n2.next;
            }
        }

        [DataRow(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 7, new int[] { 1, 2, 6, 3, 4, 5, 6 })]
        [TestMethod]
        public void TestMethod1(int[] input, int removal, int[] expected)
        {
            var sut = new Solution();
            var actual = sut.RemoveElements(convert(input), removal);
            var expectedNodes = convert(expected);
            compareNodes(actual, expectedNodes);
        }

        private ListNode convert(int[] n)
        {
            var head = new ListNode(n[0]);
            var current = head;

            for (int i = 1; i < n.Length; i++)
            {
                var temp = new ListNode(n[i]);
                current.next = temp;
                current = temp;
            }
            return head;
        }
    }
}

