using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class CircularLinkedList
    {
        Node head;
        public class Node
        {
            public int data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                this.data = data;
                Next = null;
            }
        }
        public void AddNewNodeEnd(int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            while (temp.Next!= null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = head;
        }
    }
}
