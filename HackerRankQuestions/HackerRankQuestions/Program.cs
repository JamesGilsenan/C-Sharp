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
            /*
            var sockArray = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20};
            int pairs = SockMerchant(9, sockArray);
            Console.WriteLine("Paris of Socks: " + pairs);
            */
            string path = "UDDDUDUU";
            int steps = 8;
            Console.WriteLine("Valleys walked through: " + CountingValleys(steps, path));

            Console.Read();
        }

        
        static void staircase(int n)
        {
            //WIP
            //Given n, the number of steps in a staircase, build the staircase. Use "#" as char to build the staircase.

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

        
        static int SockMerchant(int n, int[] ar)
        {
            //Given n, the number of socks in array ar, and an array of socks, return the number of pairs of socks.
            //soscks are represented by ints. If int_a == int_b, socks are a pair

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

        public static int CountingValleys(int steps, string path)
        {
            /*An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly  steps, for every step it was noted if it was an uphill, , or a downhill,  step. Hikes always start and end at sea level, and each step up or down represents a  unit change in altitude. We define the following terms:
            A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
            A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
            Given the sequence of up and down steps during a hike, find and print the number of valleys walked through. */

            int valleys = 0;
            int altitude = 0;
            foreach (char step in path)
            {
                if (step == 'U')
                {
                    altitude++;
                }
                //Check if i am at sealevel (0). If I am ANDnext step is 'D', I am walking down into a valley
                else if(step == 'D' && altitude == 0)
                {
                    valleys++;
                    altitude--;
                }
                else if (step == 'D')
                {
                    altitude--;
                }
                //Console.WriteLine("Altitude: " + altitude);
            }

            return valleys;
        }
    }
}
