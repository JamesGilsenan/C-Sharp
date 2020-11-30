using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayZero();
            //DayOne(12, 4.0, "is the best place to learn and practice coding");
            DayTwo(12, 20, 8);
            Console.Read();
        }

        static void DayZero()
        {
            var input = Console.ReadLine();

            Console.WriteLine("Hello World");

            Console.WriteLine(input);
        }

        static void DayOne(int i, double d, string s)
        {
            // Declare second integer, double, and String variables.
            int myInt = 0;
            double myDouble = 0.0;
            string myString = "";

            // Read and save an integer, double, and String to your variables.
            myInt = Convert.ToInt32(Console.ReadLine());
            myDouble = Convert.ToDouble(Console.ReadLine());
            myString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine("Int Sum = " + (myInt + i));

            // Print the sum of the double variables on a new line.
            string result = string.Format("{0:0.0}", myDouble + d);
            Console.WriteLine("Double Sum = " + result);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine("String Concaternation = " + s + myString);
        }

       static void DayTwo(double meal_cost, int tip_percent, int tax_percent)
        {
            /*Given the meal price(base cost of a meal), tip percent(the percentage of the meal price being added as tip), 
             * and tax percent(the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.
             * Print the total meal cost, where totalCost is the rounded integer result of the entire bill (mealCost with added tax and tip). */

            double totalCost = meal_cost + ((meal_cost / 100) * tip_percent) + ((meal_cost/100) * tax_percent);
            Console.WriteLine(Math.Round(totalCost));
        }
    }
}
