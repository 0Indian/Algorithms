using System;
using System.Collections.Generic;
using System.Text;

namespace ADD
{
    


    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            double num1 = returnNumber(l1);

            double num2 = returnNumber(l2);


            double numFinal = num1 + num2;
            List<int> num= SplittingNumbers(numFinal);
            ListNode listNode = l1;           
          
            ListNode root = CreateNode(null,num[0]);
            for(int i = 1;i< num.Count; i++)
            {
                root = CreateNode(root, num[i]);
            }
            

            return root;

        }
        List<int> SplittingNumbers(double splittedNumber)
        {
            List<int> list = new List<int>();
            while (splittedNumber >= 10)
            {
                list.Add((int)Math.Floor(splittedNumber % 10));
                splittedNumber = splittedNumber / 10;
            }
            list.Add((int)splittedNumber);
            return list;
        }
        ListNode CreateNode(ListNode root , int val)
        {
            if(root == null)
            {
                return new ListNode(val);
            }
            ListNode temp = root;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            ListNode node = new ListNode(val);            
            temp.next = node;            
            return root;
        }

        double returnNumber(ListNode list)
        {
            double number1 = 0;
            int i = 0;
            int Count = 0;
            ListNode temp = list;           
            while (temp!= null)
            {
                number1 = number1 + temp.val * Math.Pow(10, i);
                temp = temp.next;
                i++;
            }
            //int final = (int)number1;
            return number1;
        }
    }
}