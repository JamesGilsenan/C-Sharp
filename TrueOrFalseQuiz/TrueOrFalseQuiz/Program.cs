using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            string[] questions = { "The capital of Ireland is Dublin", "Mac gives you more freedom than PC", "Codecademy is helpful for learning", "You cannot see the difference between 120Hz and 60Hz" };

            bool[] answers = { true, false, true, false };

            RunQuiz(questions, answers);

            Console.Read();
        }

        public static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine($"Warning! There are {questions.Length} Questions and {answers.Length} answers.");
            }

            int askingIndex = 0;

            foreach (string q in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(q);
                Console.Write("True or False?");
                input = Console.ReadLine();
                input = input.ToLower();

                if (Boolean.TryParse(input, out inputBool))
                {
                    isBool = true;
                }
                else
                {
                    isBool = false;
                }

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (Boolean.TryParse(input, out inputBool))
                    {
                        isBool = true;
                    }
                    else
                    {
                        isBool = false;
                    }
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }

    }
}
