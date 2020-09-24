using System;

namespace LogicAndConditionals
{
    class TextAdventure
    {
        public void Run()
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to your story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or No:");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            while (noiseChoice != "YES" && noiseChoice != "NO")
            {
                Console.Write("You did not enter a valid option! \nDo you investigate the strange noise? \nType YES or NO:");
                noiseChoice = Console.ReadLine();
                noiseChoice = noiseChoice.ToUpper();
            }

            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();

                while (doorChoice != "KNOCK" && doorChoice != "OPEN")
                {
                    Console.WriteLine("You did not enter a valid option! \nDo you KNOCK or do you OPEN the door? \nType KNOCK or OPEN");
                    doorChoice = Console.ReadLine();
                    doorChoice = doorChoice.ToUpper();
                }
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\nPoor people have it. Rich people need it. If you eat it you die. What is it?");
                    Console.WriteLine("Type your answer:");
                    string riddleAnswer = Console.ReadLine();
                    riddleAnswer = riddleAnswer.ToUpper();

                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine($"You hear the voice say \"You're very clever {name}! But not clever enough to know you shouldn't be investigating strange noises on your own\"...");
                        Console.WriteLine($"The door opens and NOTHING is there. You turn off the light and run back towards your room. You hear the voice call after you \n\"See you soon {name}\" You burst into your room and lock the door behind you. I don't think I'll be going near that room anythime soon. \nTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number between 1 and 3:");
                    string keyChoice = Console.ReadLine();

       
                    while (keyChoice != "1")
                    {
                        switch (keyChoice)
                        {
                            case "2":
                                Console.WriteLine("You choose the second key. You try the key but it doesn't fit the lock. Try a different key. \n Type 1 or 3");
                                keyChoice = Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("You choose the third key.  You try the key but it doesn't fit the lock. Try a different key. \n Type 1 or 2");
                                keyChoice = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("You did not enter a valid option! \nChoose between three keys. \nType a number between one and 1 and 3");
                                keyChoice = Console.ReadLine();
                                break;
                        }
                    }
                    Console.WriteLine("You choose the first key. You try the key and hear a click as the door unlocks. \nThe door opens and NOTHING is there. \nStrange... \nYou go back to bed and try to forget the strange noise you heard in the middle of the night. \nTHE END.");
                }
            }

            Console.Read();

        }
    }
}



