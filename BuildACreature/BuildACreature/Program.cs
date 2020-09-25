using System;
using System.Text.RegularExpressions;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            int headNum = BuildACreature("head");
            int bodyNum = BuildACreature("body");
            int feetNum = BuildACreature("feet");

            SwitchCase(headNum, bodyNum, feetNum);
            
            //RandomMode();

            Console.Read();
        }

        static int BuildACreature(string bodyPart)
        {
            bool validOption = false;
            string pattern = "[1-4]";

            Console.WriteLine($"Choose a {bodyPart} to give your creature! \n1.Ghost \n2.Bug \n3.Monster \n4.Random");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
            {
                validOption = true;
            }

            while (!validOption)
            {
                Console.WriteLine("You did not enter a valid option for your creature's Head \nEnter 1,2,3,4");
                input = Console.ReadLine();
            }

            int partNum = TranslateToNumber(input);
            if (partNum == 4)
                partNum = RandomPart();

            return partNum;
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int randHead = randomNumber.Next(1, 4);
            int randBody = randomNumber.Next(1, 4);
            int randFeet = randomNumber.Next(1, 4);
            SwitchCase(randHead, randBody, randFeet);
        }

        static int RandomPart()
        {
            Random randomNumber = new Random();
            int rand = randomNumber.Next(1, 4);
            return rand;
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                default:
                    return 1;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("      _____");
            Console.WriteLine("  .-,;='';_),-.");
            Console.WriteLine("   \\_\\(),()/_/");
            Console.WriteLine(" 　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
