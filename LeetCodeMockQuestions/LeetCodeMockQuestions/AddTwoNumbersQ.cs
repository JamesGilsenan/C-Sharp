using System;

namespace LeetCodeMockQuestions
{
    class AddTwoNumbersQ
    {
        //You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contain a single digit. 
        //Add the two numbers and return it as a linked list.
        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        //Follow up:
        //What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //DisplayList(l1);
            //DisplayList(l2);
            l1 = ReverseIteratively(l1);
            l2 = ReverseIteratively(l2);
            //DisplayList(l1);
            //DisplayList(l2);

            int carry = 0;
            ListNode dummyHead = new ListNode();
            ListNode prev = dummyHead;

            //include condition for carry == 1 incase last addition result is > 9. Need to create new node to carry the one
            while (l1 != null || l2 != null || carry == 1)
            {
                // ? is ternary or conditional operator. Short version of if else conditions. E.G. condition ? statement 1 : statement 2 
                int sum = ((l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry);
                //int will always round down
                carry = sum / 10;
                prev.next = new ListNode(sum % 10);
                prev = prev.next;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            //DisplayList(dummyHead.next);
            dummyHead.next = ReverseIteratively(dummyHead.next);
            DisplayList(dummyHead.next);

            return dummyHead.next;
        }

        public ListNode ReverseIteratively(ListNode node)
        {
            ListNode curr = node;
            ListNode prev = null;
            ListNode temp = null;

            while (curr.next != null)
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            curr.next = prev;
            return curr;
        }

        public void DisplayList(ListNode node)
        {
            while (node != null)
            {
                if (node.next != null)
                    Console.Write(node.val + " -> ");
                else
                    Console.Write(node.val);
                node = node.next;
            }
            Console.Write("\n");
        }
    }
}
