using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMockQuestions
{
    class MajorityElementQ
    {
        //Given an int array of size n, return a list off all the elements in the array that appear more than n/3

        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> myList = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            double target = nums.Length / 3;
            //Console.WriteLine("Target: " + target);

            if (nums.Length < 3)
                return myList;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 1);
                else
                {
                    int value = dict[nums[i]];
                    dict[nums[i]] = value++;
                    if (!myList.Contains(nums[i]) && value + 1 > target)
                    {
                        myList.Add(nums[i]);
                    }
                }
            }
            /*
            Console.WriteLine("Printing Dictionary...");
            foreach (KeyValuePair<int, int> keyValuePair in dict)
            {
                Console.WriteLine(keyValuePair.Key + ": " + keyValuePair.Value);
            }
            */
            return myList;
        }
    }
}
