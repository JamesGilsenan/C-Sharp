using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMockQuestions
{
    class AddTwoNumbersQ
    {
        //You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contain a single digit. 
        //Add the two numbers and return it as a linked list.
        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        //Follow up:
        //What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

        ListNode temp = new ListNode(0);

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l1Prev = l1;
            ListNode l2Prev = l2;

            reverseRecusively(l1);
            reverseRecusively(l2);

            DisplayList(l1);
            DisplayList(l2);

            return l1;
        }

        public ListNode reverseRecusively(ListNode node)
        {
            
            if (node.next == null)
                return node;
            reverseRecusively(node);
            temp = node.next;
            temp.next = node;
            node.next = null;

            return node;
        }

        public void DisplayList(ListNode node)
        {
            while (node != null)
            {
                if (node.next != null)
                    Console.WriteLine(node.val + " -> ");
                else
                    Console.WriteLine(node.val);
            }
        }
    }
}
