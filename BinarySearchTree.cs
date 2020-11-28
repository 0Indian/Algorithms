using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class BinarySearchTree
    {
        public Node root;
        public class Node
        {
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public int data { get; set; }
        }
        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void InsertNode(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.data)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            return;
                        }

                    }

                }

            }
        }
        /// <summary>
        /// Recurssive Inorder Traversal
        /// </summary>
        /// <param name="root"></param>
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.LeftChild);
                Console.WriteLine("the Inorder Value is {0}", root.data);
                Inorder(root.RightChild);
            }
        }
        /// <summary>
        /// Recurssive PreOrder Traversal
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine("the Preorder  Value is {0}", root.data);
                PreOrder(root.LeftChild);
                PreOrder(root.RightChild);
            }
  
        }
        /// <summary>
        /// Iterative Preorder Traversal
        /// </summary>
        /// <param name="root"></param>
        public void IterativePreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count != 0)
            {
                Node topNode = nodes.Peek();
                Console.WriteLine("The element is : {0}", topNode.data);
                nodes.Pop();

                if (topNode.RightChild != null)
                {
                    nodes.Push(topNode.RightChild);
                }
                if(topNode.LeftChild != null)
                {
                    nodes.Push(topNode.LeftChild);
                }
            }
        }

        /// <summary>
        /// Iterative Inorder Traversal
        /// </summary>
        /// <param name="root"></param>
        public void IterativeInorderTraversal(Node root)
        {
            if(root == null)
            {
                return;
            }

            Stack<Node> nodes = new Stack<Node>();
            Node current = root;

        while(current != null || nodes.Count > 0)
            {
                while (current != null)
                {
                    nodes.Push(current);
                    current = current.LeftChild;
                }
                current = nodes.Pop();
                Console.WriteLine("Inorder Traversal Node is {0}", current.data);
                current = current.RightChild;
            }          
        }




        /// <summary>
        /// Recurssive PostOrder Traversal
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.LeftChild);
                PostOrder(root.RightChild);
                Console.WriteLine("the Postorder Value is {0}", root.data);
            }
        }
    }
}
