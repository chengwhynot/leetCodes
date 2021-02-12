using Microsoft.VisualStudio.TestTools.UnitTesting;
using x_of_a_kind_in_a_deck_of_cards;

namespace x_of_a_kind_in_a_deck_of_cards_test
{
    [TestClass]
    public class UnitTest1
    {
        /*
        ʾ�� 1��
            
        ���룺[1,2,3,4,4,3,2,1]
        �����true
        ���ͣ����еķ����� [1,1]��[2,2]��[3,3]��[4,4]
        
        ʾ�� 2��

        ���룺[1,1,1,2,2,2,3,3]
        �����false
        ���ͣ�û������Ҫ��ķ��顣
        ʾ�� 3��

        ���룺[1]
        �����false
        ���ͣ�û������Ҫ��ķ��顣
        ʾ�� 4��

        ���룺[1,1]
        �����true
        ���ͣ����еķ����� [1,1]
        ʾ�� 5��

        ���룺[1,1,2,2,2,2]
        �����true
        ���ͣ����еķ����� [1,1]��[2,2]��[2,2]
        */
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, true)]
        [DataRow(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 }, false)]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { 1, 1 }, true)]
        [DataRow(new int[] { 1, 1, 2, 2, 2, 2 }, true)]
        [DataRow(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }, true)]
        [DataRow(new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, true)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 1, 2, 2, 3, 4 }, false)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7 }, true)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 3, 4 }, false)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 6, 6, 7, 7, 8, 8 }, true)]
        public void TestMethod1(int[] deck, bool expected)
        {
            var sut = new Solution();
            var actual = sut.HasGroupsSizeX(deck);
            Assert.AreEqual(expected, actual);
        }
    }
}
