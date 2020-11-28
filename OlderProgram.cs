using ADD;
using System;
using System.Collections.Generic;
using System.Text;
using static Prep.LinkedList;

namespace Prep
{
    public static class Program
    {
        public static void Main()
        {
            //int[] unrotatedArray = { 1, 2, 3, 4, 5 };
            //int[] rotatedArray = ArrayProblems.RotateLeft(unrotatedArray, 2, unrotatedArray.Length);
            //int[] singleLeftRotation = ArrayProblems.CyclicRotation(unrotatedArray, unrotatedArray.Length);
            //foreach (int element in singleLeftRotation)
            //{
            //    Console.WriteLine(element);
            //}

            //Stack stack = new Stack(5);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.PrintStack();
            //stack.Pop();
            //stack.PrintStack();

            //Queue queue = new Queue(5);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.PrintQueue();
            //queue.Dequeue();
            //queue.PrintQueue();

            /* Singly Linked List */
            //LinkedList linkedList = new LinkedList();
            //linkedList.head = new Node(1);
            //Node secondNode = new Node(2);
            //Node thirdNode = new Node(3);

            //linkedList.head.Next = secondNode;

            //secondNode.Next = thirdNode;

            //thirdNode.Next = null;
            //linkedList.InsertionAttheStartOfList(new Node(4));
            //linkedList.PrintList();
            //linkedList.InsertionAttheEndOfList(new Node(5));
            //linkedList.PrintList();
            //linkedList.InsertionAfterAGivenNode(4,6);
            //linkedList.InsertionAfterAGivenNode(5, 6);
            //linkedList.PrintList();
            //linkedList.RemovingDuplicatesFromSortedList();
            //Console.WriteLine("list with no duplicates");
            //linkedList.PrintList();

            //linkedList.SwapNodes(6, 2);
            //linkedList.PrintList();
            //Console.WriteLine("{0}",linkedList.CheckIfPalindrome());
            //linkedList.DeletionOfANode(4);
            //linkedList.PrintList();
            //linkedList.DeletionOfANode(6);
            //linkedList.PrintList();
            //Console.WriteLine("Is loop Present:{0}",linkedList.DetectLoop());
            //linkedList.MakeLoop();
            //Console.WriteLine("Is loop Present:{0}", linkedList.DetectLoopThroughDoublePointer());
            //Console.WriteLine("Length of loop is:{0}", linkedList.GetLengthOfLoop());


            /* Doubly Linked List */
            //DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            //doublyLinkedList.head = new DoublyLinkedList.Node(1);
            //DoublyLinkedList.Node secondNode = new DoublyLinkedList.Node(2);
            //DoublyLinkedList.Node thirdNode = new DoublyLinkedList.Node(3);

            //doublyLinkedList.head.Next = secondNode;
            //doublyLinkedList.head.Previous = null;

            //secondNode.Next = thirdNode;
            //secondNode.Previous = doublyLinkedList.head;

            //thirdNode.Previous = secondNode;
            //thirdNode.Next = null;
            //doublyLinkedList.PrintList();

            //BinarySearchTree binarySearchTree = new BinarySearchTree();
            //binarySearchTree.InsertNode(25);
            //binarySearchTree.InsertNode(45);
            //binarySearchTree.InsertNode(15);
            //binarySearchTree.InsertNode(67);
            //binarySearchTree.InsertNode(43);
            //binarySearchTree.InsertNode(80);
            //binarySearchTree.InsertNode(33);
            //binarySearchTree.InsertNode(67);
            //binarySearchTree.InsertNode(99);
            //binarySearchTree.InsertNode(91);         
            //BinarySearchTree.Node root = binarySearchTree.ReturnRoot();
            //binarySearchTree.IterativePreOrder(root);
            //binarySearchTree.IterativeInorderTraversal(root);
            //binarySearchTree.Inorder(root);
            //binarySearchTree.PreOrder(root);
            //binarySearchTree.PostOrder(root);

            //BinarySearch binarySearch = new BinarySearch();
            //int[] array = new int[10] { 2, 5, 1, 45, 23, 32, 9, 3, 8, 0 };
            //bool swapped;
            //for(int i = 0;i < array.Length -1 ; i++)
            //{
            //    swapped = false;
            //    for(int j = 0;j < array.Length -i -1; j++)
            //    {
            //        if(array[j+1] < array[j])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j+1];
            //            array[j+1] = temp;
            //            swapped = true;
            //        }
            //    }
            //    if(swapped == false)
            //    {
            //        break;
            //    }
            //}
            //binarySearch.Search(45, array, 0, 10);
            //BST bST = new BST();
            //bST.Insert(50);
            //bST.Insert(30);
            //bST.Insert(20);
            //bST.Insert(40);
            //bST.Insert(70);
            //bST.Insert(60);
            //bST.Insert(80);
            //bST.Inorder();
            //BST.Node searchedNode = bST.SearchNode(bST.ReturnRoot(), 70);

            ///RecurssiveFactorial
            //RecurssiveFactorialProblem recurssiveFactorial = new RecurssiveFactorialProblem();
            //Console.WriteLine("The Factorial of {0} is {1}",5,recurssiveFactorial.Factorial(5));

            //Solution.ListNode listNodeFirst = new Solution.ListNode(5);
            //Solution.ListNode listNodeFirst1 = new Solution.ListNode(6);
            //Solution.ListNode listNodeFirst2 = new Solution.ListNode(4);
            //Solution.ListNode listNodeSecond = new Solution.ListNode(1);
            //Solution.ListNode listNodeSecond1 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond2 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond3 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond4 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond5 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond6 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond7 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond9 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond10 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond11 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond12 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond13 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond14 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond15 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond16 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond17 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond18 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond19 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond20 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond21 = new Solution.ListNode(0);
            //Solution.ListNode listNodeSecond22 = new Solution.ListNode(0);

            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond8 = new Solution.ListNode(0);
            ////Solution.ListNode listNodeSecond9 = new Solution.ListNode(1);

            //listNodeFirst.next = listNodeFirst1;
            //listNodeFirst1.next = listNodeFirst2;
            //listNodeSecond.next = listNodeSecond1;
            //listNodeSecond1.next = listNodeSecond2;
            //listNodeSecond2.next = listNodeSecond3;
            //listNodeSecond3.next = listNodeSecond4;
            //listNodeSecond4.next = listNodeSecond5;
            //listNodeSecond5.next = listNodeSecond6;
            //listNodeSecond6.next = listNodeSecond7;
            //listNodeSecond7.next = listNodeSecond8;
            //listNodeSecond8.next = listNodeSecond9;
            //Solution solution = new Solution();
            //Solution.ListNode resultNode = solution.AddTwoNumbers(listNodeSecond, listNodeFirst);


            //Console.Write("\n\n Recursion : Display the individual digits of a given number :\n");
            //Console.Write("------------------------------------------------------------------\n");
            //Console.Write(" Input any number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" The digits in the number {0} are : ", num);
            //RecExercise4.separateDigits(num);
            //Console.Write("\n\n");

            NQueens nQqeens = new NQueens();
            nQqeens.SolveNQueens(2);
        }
}
}
