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
            //DayTwo(12, 20, 8);
            //DayThree();
            //Person jack = new Person(7);
            //DayFour(jack);
            DayFive();
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

        static void DayThree()
        {
            /*Given an integer, , perform the following conditional actions:
            If  is odd, print Weird
            If  is even and in the inclusive range of 2 to 5, print Not Weird
            If  is even and in the inclusive range of 6 to 20, print Weird
            If  is even and greater than 20, print Not Weird */

            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
                Console.WriteLine("Weird");
            else if (N >= 2 && N <= 5 && N % 2 == 0)
                Console.WriteLine("Not Weird");
            else if (N >= 6 && N <= 20 && N % 2 == 0)
                Console.WriteLine("Weird");
            else if (N > 20 && N % 2 == 0)
                Console.WriteLine("Not Weird");


        }

        static void DayFour(Person person)
        {
            Console.WriteLine(person.age);
            person.YearPasses();
            Console.WriteLine(person.age);
            person.AmIOld();
        }

        static void DayFive()
        {
            /*Given an integer, n, print its first 10 multiples. Each multiple n x i (where 1 <= i <= 10) should be printed on a new line in the form: n x i = result. */
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }


    }
}
