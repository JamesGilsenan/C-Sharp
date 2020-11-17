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

            ShiftCharQ shiftChar = new ShiftCharQ();
            MajorityElementQ majorityElement = new MajorityElementQ();

            Console.WriteLine("String A will equal String B: " + shiftChar.ShiftCharQuestion(a, b));
            var list = majorityElement.MajorityElement(nums);
            Console.Write("[");
            foreach (int num in list)
                Console.Write(num + ", "); ;
            Console.Write("]");



            Console.Read();
        }  
    }
}
