using System;
using System.Collections;
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
            /*string path = "UDDDUDUU";
            int steps = 8;
            Console.WriteLine("Valleys walked through: " + CountingValleys(steps, path));*/

            /*int[] clouds = new int[] { 0, 0, 0, 0, 1, 0};
            Console.WriteLine("Jumps to last cloud: " + JumpingOnClouds(clouds));*/

            /*string s = "aba";
            int n = 10;
            Console.WriteLine("Answer: " + RepeatedString(s, n));*/

            //x = rows, y = columns. arr[5,4] = 4. arr[3,2] = 2
            /*int[,] arr = new int[6, 6] {
            { 1, 1, 1, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 1, 0, 0, 0 },
            { 0, 0, 2, 4, 4, 0 },
            { 0, 0, 0, 2, 0, 0 },
            { 0, 0, 1, 2, 4, 0 }
            };
            Console.WriteLine(HourGlassSum(arr));*/

            /*var a = new int[] { 1, 2, 3, 4, 5 };
            int d = 4;
            var shiftedArray = RotLeft(a, d);
            foreach (int num in shiftedArray)
            {
                Console.Write(num + " ");
            }*/

            /*var q = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            MinimumBribes(q);*/

            /*var arr = new int[] { 4, 3, 1, 2, };
            Console.WriteLine("Minimum Swaps: " + MinimumSwaps(arr));*/

            /*var magazine = new string[] { "give", "me", "one", "grand", "today", "night" };
            var note = new string[] { "give", "one", "grand", "today" };
            CheckMagazine(magazine, note);*/

            /*string s1 = "wouldyoulikefries";
            string s2 = "abcabcabcabcabcabc";
            string s3 = "hackerrankcommunity";
            string s4 = "cdecdecdecde";
            Console.WriteLine(TwoStrings(s1, s2));
            Console.WriteLine(TwoStrings(s3, s4));*/

            /*&string a = "cde";
            string b = "abc";
            Console.WriteLine("Deletions: " + MakeAnagram(a, b));*/

            /*string s = "AAABBB";
            Console.WriteLine("Deletions: " + AlternatingCharacters(s));*/

            /*var array = new List<int> { 2, 3, 1 };
            int k = 3;
            FindNumber(array, 3); */

            /*int l = 3, r = 9;
            OddNumbers(l, r);*/

            //var prices = new List<int> { 1, 2, 3, 4 };
            var prices = new List<int> { 4, 9, 2, 3 };
            Console.WriteLine("Total: " + CalculateAmount(prices));

            /*var ops = new List<string> { "push", "push", "push", "pop" };
            var x = new List<int> { 1, 2, 3, 1 };
            MaxMin(ops, x); */


            Console.Read();
        }


        static void Staircase(int n)
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
                else if (step == 'D' && altitude == 0)
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

        static int JumpingOnClouds(int[] c)
        {
            /*Emma is playing a new mobile game that starts with consecutively numbered clouds. Some of the clouds are thunderheads and others are cumulus. 
            She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2. She must avoid the thunderheads. 
             * Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. It is always possible to win the game.
            For each game, Emma will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided. */

            int jumps = 0;
            int currentCloud = 0;

            while (currentCloud < c.Length - 1)
            {
                if (currentCloud + 2 >= c.Length - 1)
                    return jumps += 1;
                if (c[currentCloud + 2] == 0)
                {
                    currentCloud += 2;
                    jumps++;
                }
                else if (c[currentCloud + 1] == 0)
                {
                    currentCloud++;
                    jumps++;
                }
            }
            return jumps;
        }

        static long RepeatedString(string s, long n)
        {
            /*Lilah has a string, , of lowercase English letters that she repeated infinitely many times.
            Given an integer, , find and print the number of letter a's in the first  letters of Lilah's infinite string.
            For example, if the string  and , the substring we consider is , the first  characters of her infinite string. There are  occurrences of a in the substring.*/

            char toFind = 'a';
            long size = s.Length;
            long multiple = n / size;
            long remainder = n - (size * multiple);
            int answer = 0;

            for (int i = 0; i < size; i++)
            {
                if (s[i] == toFind)
                {
                    answer++;
                }
            }

            multiple *= answer;

            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == toFind)
                {
                    multiple++;
                }
            }

            return multiple;
        }

        static int HourGlassSum(int[,] arr)
        {
            //Arrays
            /*There are  hourglasses in . An hourglass sum is the sum of an hourglass' values. 
             * Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. The array will always be 6 x 6. */


            //Store hour glass sums in array to be printed at the end
            //as i add each int hourglass sum to int[] sums array, use an int to track the largest sum so far. If the current sum is larger than the maxSum, set maxSum = current sum
            int maxSum = int.MinValue;
            var sums = new int[16];
            int limit = Convert.ToInt32(Math.Sqrt(arr.Length)) - 2;
            Console.Write(arr.Length);

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    sums[i] = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    Console.WriteLine("Hour Glass Sum: " + sums[i] + "\nMax Sum: " + maxSum);
                    if (sums[i] > maxSum)
                    {
                        maxSum = sums[i];
                    }
                }

            }

            return maxSum;
        }

        static int[] RotLeft(int[] a, int d)
        {
            //Arrays
            //A left rotation operation on an array shifts each of the array's elements 1 unit to the left. For example, 
            //if 2 left rotations are performed on array [1, 2, 3, 4, 5] then the array would become [3, 4, 5, 1, 2].
            //Given an array a of n integers and a number, d, perform d left rotations on the array. Return the updated array to be printed as a single line of space-separated integers.

            var b = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (i - d < 0)
                {
                    int index =
                    b[a.Length + (i - d)] = a[i];
                }
                else
                {
                    b[i - d] = a[i];
                }
            }
            return b;
        }

        static void MinimumBribes(int[] q)
        {
            //Arrays
            /*It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride! There are a number of people queued up, and each person wears a sticker indicating their initial position in the queue. Initial positions increment by  from  at the front of the line to  at the back.
            Any person in the queue can bribe the person directly in front of them to swap positions. If two people swap positions, they still wear the same sticker denoting their original places in line. One person can bribe at most two others. For example, if  and  bribes , the queue will look like this: .
            Fascinated by this chaotic queue, you decide you must know the minimum number of bribes that took place to get the queue into its current state!
            print an integer representing the minimum number of bribes necessary, or Too chaotic if the line configuration is not possible.*/

            int n = q.Length;
            int bribes = 0;

            for (int i = 0; i < n; i++)
            {
                int index = i + 1;
                //Console.WriteLine("i: " + index + " | q[i]: " + q[i]);
                //if a person q[i] has bribed 2 people, print "too chaotic" and exit method 
                if (q[i] - index > 2)
                {
                    //Console.WriteLine(bribes);
                    Console.WriteLine("Too chaotic");
                    return;
                }
                //use Math.max to ensure q[i]-2 wont't return a negative number. 
                //check if a person has moved ahead of another, if so increment int bribes
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        bribes++;
                    }
                }
            }
            Console.WriteLine("Bribes: " + bribes);
        }

        static int MinimumSwaps(int[] arr)
        {
            //Arrays
            /*You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any two elements. 
             * You need to find the minimum number of swaps required to sort the array in ascending order. */

            int swap = 0;
            int i = 0;

            while (i < arr.Length)
            {
                // If current element is 
                // not at the right position
                if (i + 1 != arr[i])
                {
                    //increment t until arr[t] = index we're looking for
                    while (arr[i] != i + 1)
                    {
                        int temp = 0;

                        // Swap current element with correct position of that element 
                        temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        swap++;
                    }
                }
                // Increment for next index when current element is at correct position 
                i++;
            }
            return swap;
        }

        static void CheckMagazine(string[] magazine, string[] note)
        {
            //Dicts & Hashmaps
            /*Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting. 
             * He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. 
             * The words in his note are case-sensitive and he must use only whole words available in the magazine. He cannot use substrings or concatenation to create the words he needs.
            Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.
            For example, the note is "Attack at dawn". The magazine contains only "attack at dawn". The magazine has all the right words, but there's a case mismatch. The answer is No.
            It must print Yes if the note can be formed using the magazine, or No. */

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (dict.ContainsKey(magazine[i]) == false)
                {
                    dict.Add(magazine[i], 1);
                }
                else
                {
                    dict[magazine[i]] += 1;
                }
            }
            /*foreach (KeyValuePair<string, int> keyValuePair in dict)
            {
                Console.WriteLine("Key: " + keyValuePair.Key + " | Pair: " + keyValuePair.Value);
            }*/

            for (int i = 0; i < note.Length; i++)
            {
                if (dict.ContainsKey(note[i]) == false || dict[note[i]] < 1)
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    dict[note[i]] -= 1;
                }
            }
            Console.WriteLine("Yes");
        }

        static string TwoStrings(string s1, string s2)
        {
            //Dicts & Hashmaps
            /*Given two strings, determine if they share a common substring. A substring may be as small as one character.
            For example, the words "a", "and", "art" share the common substring . The words "be" and "cat" do not share a substring. 
            It should return a string, either YES or NO based on whether the strings share a common substring. */

            var aChars = new HashSet<char>(s1.ToList());
            var bChars = s2.ToList();

            foreach (char letter in bChars)
            {
                if (aChars.Contains(letter))
                {
                    return "YES";
                }
            }
            return "NO";

        }

        static int MakeAnagram(string a, string b)
        {
            /*Given two strings, a and b, that may or may not be of the same length, determine the minimum number of character deletions required to make a and b anagrams. 
            * Any characters can be deleted from either of the strings.
            For example, if a = cde and b = dcf, we can delete e from string a and f from string b so that both remaining strings are cd and dc which are anagrams. */

            //Same letters && same frequency of letters
            //Use dict/hashtable because search, insertion and deletion are O(1) time complexity
            //Store both strings as dict<char, int>
            //Console.WriteLine(A);
            int deletions = 0;
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    dict.Add(a[i], 1);
                }
                else
                {
                    dict[a[i]] += 1;
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (dict.ContainsKey(b[i]) && dict[b[i]] > 0)
                {
                    dict[b[i]] -= 1;
                }
                else
                {
                    //char b[i] would have to be deleted
                    deletions++;
                }
            }
            return deletions + Math.Abs(a.Length - (b.Length - deletions));
        }

        static int AlternatingCharacters(string s)
        {
            /*You are given a string containing characters A and B only. Your task is to change it into a string such that there are no matching adjacent characters. 
            * To do this, you are allowed to delete zero or more characters in the string. Your task is to find the minimum number of required deletions.
            For example, given the string AABAAB, remove an A at positions 0 and 3 to make s = ABAB in 2 deletions. */

            /*var str = "My name @is ,Wan.;'; Wan";
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            } /*

            /*var str = "My name @is ,Wan.;'; Wan";
            str = new string((from c in str
                  where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                  select c
            ).ToArray()); */

            int deletions = 0;
            var set = new HashSet<char>(s);
            //if there is only 1 char in hashset, number of deletions will equal the length of string s minus 1
            if (set.Count == 1)
            {
                return s.Length - 1;
            }

            //if a deletion occurs, we skip that char, so our loop runs n = (length of string s - 1) - deletions
            for (int i = 0; i < s.Length - 1 - deletions; i++)
            {
                //Console.WriteLine("Index: " + i + " | s[i] " + s[i] + " | s[s[i+1+deletions]] " + s[i + 1 + deletions]);
                //i + deletions to skip comparison for deleted chars
                if (s[i + deletions] == s[i + deletions + 1])
                {
                    deletions++;
                    //Console.WriteLine("Deleting... " + deletions);
                    i--;
                }
            }
            return deletions;
        }

        public static string FindNumber(List<int> arr, int k)
        {
            var set = new HashSet<int>(arr);
            foreach (var num in set)
            {
                Console.WriteLine(num);
            }
            if (set.Contains(k))
            {
                return "Yes";
            }
            else
            {
                return "NO";
            }
        }

        public static List<int> OddNumbers(int l, int r)
        {
            var myArray = new List<int>();

            for (int i = 0; i <= r - l; i++)
            {
                int num = l + i;
                if (num % 2 == 1)
                {
                    myArray.Add(num);
                }
            }
            foreach (var num in myArray)
            {
                Console.WriteLine(num);
            }
            return myArray;
        }

        /*
        public static long CalculateAmount(List<int> prices)
        {
            //given list of prices. First item is not discounted. Every item after has a discount of lowest discount on prev prices.
            long totalPrice = 0;
            int lowestPrice = prices[0];

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }

            for (int i = 1; i < prices.Count; i++)
            {
                int discountedPrice = Math.Max(0, prices[i] - lowestPrice);
                totalPrice += discountedPrice;

                Console.WriteLine("DP: " + discountedPrice + "LP: " + lowestPrice);

                if (discountedPrice < lowestPrice)
                {
                    lowestPrice = discountedPrice;
                }

                Console.WriteLine("DP: " + discountedPrice);
            }

            return totalPrice + prices[0];
            //ans = 10
        }

        public static List<long> MaxMin(List<string> operations, List<int> x)
        {
            var elements = new List<int>();
            var products = new List<long>();

            foreach(var num in x)
            {
                Console.WriteLine(num);
            }
            elements.Add(x[0]);

            for (int i = 1; i < operations.Count; i++)
            {
                if (operations[i] == "push" && x[i] < elements[0])
                {
                    elements.Insert(0, x[i]);
                }
                else if (operations[i] == "push" && x[i] > elements[0])
                {
                    elements.Add(x[i]);
                }
                else
                {
                    elements.Remove(x[i]);
                }
                products.Add((elements[0] * (elements[elements.Count - 1])));

                Console.WriteLine(products[i-1]);
            }
            return products;
            //ans = 1, 2, 3, 6
        }
        */
    }
}
