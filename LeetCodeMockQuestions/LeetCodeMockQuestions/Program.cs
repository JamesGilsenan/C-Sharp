using System;

namespace LeetCodeMockQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //For testing shiftChar
            string a = "abcde";
            string b = "deabc";

            //For testing MajorityElement
            int[] nums = { 3, 2, 3 };

            ListNode l1node4 = new ListNode(3, null);
            ListNode l1node3 = new ListNode(4, l1node4);
            ListNode l1node2 = new ListNode(2, l1node3);
            ListNode l1node1 = new ListNode(7, l1node2);
            ListNode l2node3 = new ListNode(6, null);
            ListNode l2node2 = new ListNode(5, l2node3);
            ListNode l2node1 = new ListNode(7, l2node2);

            ShiftCharQ shiftChar = new ShiftCharQ();
            MajorityElementQ majorityElement = new MajorityElementQ();
            AddTwoNumbersQ addTwoNumbers = new AddTwoNumbersQ();

            /*
            Console.WriteLine("String A will equal String B: " + shiftChar.ShiftCharQuestion(a, b));
            var list = majorityElement.MajorityElement(nums);
            Console.Write("[");
            foreach (int num in list)
                Console.Write(num + ", "); ;
            Console.Write("]");
            */
            addTwoNumbers.AddTwoNumbers(l1node1, l2node1);



            Console.Read();
        }  
    }
}
