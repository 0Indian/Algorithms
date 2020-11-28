using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    class DoublyLinkedList
    {
        public Node head { get; set; }
        public class Node
        {
            public int data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(int data)
            {
                this.data = data;
                Next = null;
                Previous = null;
            }
        }
        public void PrintList()
        {
            for (Node i = head; i != null; i = i.Next)
            {
                Console.WriteLine("The Values are : {0}", i.data);
            }
        }
    }
}
