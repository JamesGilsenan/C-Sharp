using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //staircase(4);

            var sockArray = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20};
            int pairs = sockMerchant(9, sockArray);
            Console.WriteLine("Paris of Socks: " + pairs);

            Console.Read();
        }

        //WIP
        //Given n, the number of steps in a staircase, build the staircase. Use "#" as char to build the staircase.
        static void staircase(int n)
        {
            string space = " ";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(space);
                }
                Console.Write("#");
                Console.Write("\n");
            }
        }

        //Given n, the number of socks in array ar, and an array of socks, return the number of pairs of socks.
        //soscks are represented by ints. If int_a == int_b, socks are a pair
        static int sockMerchant(int n, int[] ar)
        {
            //The call to contains() be O(1) for a HashSet versus O(n) for a List, and you won't store duplicates. 
            int pairs = 0;
            var colours = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                if (!colours.Contains(ar[i]))
                {
                    colours.Add(ar[i]);
                }
                else
                {
                    pairs++;
                    colours.Remove(ar[i]);
                }
            }

            return pairs;
        }

        static void HashSetExample()
        {
            //Example of hashSet removing duplicate strings
            string[] arr1 = { "Table", "Chair", "Pen", "Clip", "Table" };
            Console.WriteLine(string.Join(",", arr1));

            // HashSet
            var h = new HashSet<string>(arr1);

            // eliminates duplicate words
            string[] arr2 = h.ToArray();
            Console.WriteLine(string.Join(",", arr2));
        }
    }
}
