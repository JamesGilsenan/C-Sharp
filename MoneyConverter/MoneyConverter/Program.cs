using System;

namespace MoneyConverter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter the amount to convert to coins");
            string amount = Console.ReadLine();

            double convertedAmount = Convert.ToDouble(amount);
            convertedAmount = Math.Floor(convertedAmount);
            Console.WriteLine($"{convertedAmount} is equal to...");

            double fiftyValue = 50;
            double twentyValue = 20;
            double tenValue = 10;
            double fiveValue = 5;

            double fiftyCentCoins = convertedAmount / fiftyValue;
            fiftyCentCoins = Math.Floor(fiftyCentCoins);
            double fiftyRemainder = convertedAmount % fiftyValue;

            double twentyCentCoins = fiftyRemainder / twentyValue;
            twentyCentCoins = Math.Floor(twentyCentCoins);
            double twentyRemainder = fiftyRemainder % twentyValue;

            double tenCentCoins = twentyRemainder / tenValue;
            tenCentCoins = Math.Floor(tenCentCoins);
            double tenRemainder = twentyRemainder % tenValue;

            double fiveCentCoins = tenRemainder / fiveValue;
            fiveCentCoins = Math.Floor(fiveCentCoins);
            double oneCentCoins = tenRemainder % fiveValue;

            Console.WriteLine($"Fifty Cent Coins: {fiftyCentCoins}");
            Console.WriteLine($"Twenty Cent Coins: {twentyCentCoins}");
            Console.WriteLine($"Ten Cent Coins: {tenCentCoins}");
            Console.WriteLine($"Five Cent Coins: {fiveCentCoins}");
            Console.WriteLine($"One Coins: {oneCentCoins}");

            Console.Read();
        }
    }
}
