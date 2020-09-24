using System;
using System.Text.RegularExpressions;

namespace LogicAndConditionals
{
    class PasswordChecker
    {
        public void Run()
        {
            int minLength = 8;
            string uppercasePattern = @"[A-Z]";
            string lowercasePattern = @"[a-z]";
            string digitsPattern = @"[0-9]";
            string specialCharsPattern = @"\W^\s";
            int score = 0;
            string predictableOne = "password";
            string predictableTwo = "1234";

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            //Regex r = new Regex(uppercasePatern);

            if (password.Length >= minLength)
            {
                score++;
            }

            if (Regex.IsMatch(password, uppercasePattern))
            {
                score++;
            }

            if (Regex.IsMatch(password, lowercasePattern))
            {
                score++;
            }
            if (Regex.IsMatch(password, digitsPattern))
            {
                score++;
            }
            if (Regex.IsMatch(password, specialCharsPattern))
            {
                score++;
            }
            if (password == predictableOne)
            {
                score = 0;
            }
            else if (password == predictableTwo)
            {
                score = 0;
            }

            switch (score)
            {
                case 4:
                    Console.WriteLine("Your Password Strength is Extremely Strong");
                    break;
                case 3:
                    Console.WriteLine("Your Password Strength is Strong");
                    break;
                case 2:
                    Console.WriteLine("Your Password Strength is Medium");
                    break;
                case 1:
                    Console.WriteLine("Your Password Strength is Weak");
                    break;
                default:
                    Console.WriteLine("Your Password is Unacceptable");
                    break;                   
            }

            Console.Read();

        }
    }
}
