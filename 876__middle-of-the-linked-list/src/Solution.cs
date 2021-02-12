using System;

namespace middle_of_the_linked_list
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var nextNode = head;
            var nextNextNode = head;
            while (nextNextNode != null && nextNextNode.next != null)
            {
                nextNode = nextNode.next;
                nextNextNode = nextNextNode.next.next;
            }
            return nextNode;
        }
    }
}
