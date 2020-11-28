//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Solution
//{
//    List<int> list = new List<int>();
//    public class ListNode
//    {
//        public int val;
//        public ListNode next;
//        public ListNode(int x) { val = x; }
//    }
//    public ListNode AddNodeToList(ListNode root, int value)
//    {
//        ListNode temp = root;
//        ListNode listNode = new ListNode(value);
//        while (temp.next != null)
//        {
//            temp = temp.next;
//        }
//        temp.next = listNode;
//        return root;
//    }
//    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//    {
//        double number1 = 0;
//        double number2 = 0;
//        int count = 0;
//        int tempNumber = 0;
//        ListNode temp = l1;
//        ListNode temp2 = l2;
//        ListNode temp3 = new ListNode(4);
//        int finalNumber = 0;

//        while (temp != null)
//        {
//            number1 += Math.Pow(10, count) * temp.val;
//            number2 += Math.Pow(10, count) * temp2.val;
//            temp = temp.next;
//            temp2 = temp2.next;
//            count++;
//        }
//        finalNumber = (int)number1 + (int)number2;
//        list = finalNumber.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

        
       
//        ListNode temp5 = new ListNode(0);        
//        bool isEmpty = true;
//        //separateDigits(finalNumber);
//        list.Reverse();
//        foreach(int label in list)
//        {
//            if (isEmpty)
//            {
//                temp5.val = label;
//                isEmpty = false;
//            }
//            else
//            {
//               temp5 =  AddNodeToList(temp5, label);
//            }           
//        }      
//        return temp5;
//    }
//}