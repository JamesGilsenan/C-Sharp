using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMockQuestions
{

    class ShiftCharQ
    {
        //The leftmost char in string A is always shifted to the end of the string
        //Given string A and string B, check if string A will ever equal string B after all shifts are carried out
        public bool ShiftCharQuestion(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            if (a.Equals(b))
                return true;

            for (int i = 0; i < a.Length; i++)
            {
                string leftmost = a.Substring(0, 1);
                string substring = a.Substring(1);
                a = substring + leftmost;

                if (a.Equals(b))
                    return true;

                //Console.WriteLine(a);
            }
            return false;
        }
    }
}
