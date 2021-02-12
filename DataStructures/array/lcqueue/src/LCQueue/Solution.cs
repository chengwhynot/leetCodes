using System;
using System.Collections;

namespace LCQueue
{
    public class LCQueue
    {
        Node head;
        Node tail;

        public LCQueue()
        {
            head = new Node();
            tail = new Node();
            head.Next = tail;
            tail.Pre = head;
        }

        public void Push(int x)
        {
            Node n = new Node(x);
            tail.Pre.Next = n;
            n.Pre = tail.Pre;
            n.Next = tail;
            tail.Pre = n;
        }

        public void Pop()
        {
            if (head.Next.Next != null)
                head.Next = head.Next.Next;
            head.Next.Pre = head;
        }

        public int Size()
        {
            int size = 0;
            var cur = head;
            while (cur.Next != null)
            {
                size++;
                cur = cur.Next;
            }
            return size - 1;
        }

        public int Front()
        {
            return head.Next.Value;
        }

        class Node
        {
            public Node Pre;
            public Node Next;
            public int Value;

            public Node()
            {

            }

            public Node(int value)
            {
                this.Value = value;
            }

            public Node(Node pre, Node next, int value)
            {
                this.Pre = pre;
                this.Next = next;
                this.Value = value;
            }
        }
    }
}