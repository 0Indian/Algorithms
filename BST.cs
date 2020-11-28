using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class BST
    {
        public Node root;
        public class Node
        {
            public Node LeftChild { get; set; }

            public Node RightChild { get; set; }
            public int Data { get; set; }

            public Node(int data)
            {
                Data = data;
                LeftChild = RightChild = null;
            }       
        }
        
        public BST()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int data)
        {
            root = InsertNewNode(root, data);
        }
        public void Inorder()
        {
            InOrderTravsersal(root);
        }

        public Node SearchNode(Node root,int data)
        {
            if (root == null || root.Data == data) return root;

            if(data < root.Data)
            {
                return SearchNode(root.LeftChild, data);
            }

            return SearchNode(root.RightChild, data);
        }

        public Node InsertNewNode(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
            {
                root.LeftChild = InsertNewNode(root.LeftChild, data);
            }
            else if(data > root.Data)
            {
                root.RightChild = InsertNewNode(root.RightChild, data);
            }

            return root;
        }

        public void InOrderTravsersal(Node root)
        {
            if (root != null)
            {
                InOrderTravsersal(root.LeftChild);
                Console.WriteLine(root.Data);
                InOrderTravsersal(root.RightChild);
            }
        }

       
    }
}
