using System;

namespace CalculateMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programme running...\n");
            Console.Write("Which monument would you like to work with? \n1. Teotihuacan \n2. Taj Mahal \n3. Great Mosque of Mecca \nEnter 1, 2 or 3: ");
            string monChoice = Console.ReadLine();
            monChoice = monChoice.ToUpper();

            while (monChoice != "1" && monChoice != "2" && monChoice != "3")
            {
                Console.Write("You did not enter a valid option! \nWhich monument would you like to work with? \n 1. Teotihuacan \n2. Taj Mahal \n3. Great Mosque of Mecca \nEnter 1, 2 or 3: ");
                monChoice = Console.ReadLine();
                monChoice = monChoice.ToUpper();
            }

            switch (monChoice)
            {
                case "1":
                    CalculateTotalCostTeotihuacan();
                    break;
                case "2":
                    CalculateTotalCostTajMahal();
                    break;
                case "3":
                    CalculateTotalCostMosqueMecca();
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option! \nExitting programme..");
                    break;
            }

            Console.Read();
        }

        public static void CalculateTotalCostMosqueMecca()
        {
            Console.WriteLine("\n\n\nCalculating area of the Great Mosque of Mecca");
            double smallRect = Rectangle(180, 106);
            double bigRect = Rectangle(200, 284);
            double tri = Triangle(84, 264);
            double area = smallRect + bigRect + tri;
            double mosqueFlooringCost = area * 180;
            mosqueFlooringCost = Math.Round(mosqueFlooringCost, 2);
            Console.WriteLine($"The Great Mosque of Mecca is {area} meters squared. \nThe cost of flooring is 180 Pesos per square meter. \nThe total cost of flooring for the Great Mosque of Mecca is {mosqueFlooringCost} Pesos");

        }

        public static void CalculateTotalCostTajMahal()
        {
            Console.WriteLine("\n\n\nCalculating area of the Taj Mahal...");
            double tajRect = Rectangle(90.5, 90.5);
            double tajTri = Triangle(24, 24);
            double tajArea = tajRect - (tajTri * 4);
            double tajFlooringCost = tajArea * 180;
            tajFlooringCost = Math.Round(tajFlooringCost, 2);
            Console.WriteLine($"The Taj Mahal is {tajArea} meters squared in area. \nThe cost of flooring is 180 Pesos per square meter. \nThe total cost for flooring the Taj Mahal is {tajFlooringCost} Pesos.");
        }

        public static void CalculateTotalCostTeotihuacan()
        {
            Console.WriteLine("\n\n\nCalculating area of Teotihuacan...");

            double teoRect = Rectangle(2500, 1500);
            double teoCircle = Circle(375);
            teoCircle = teoCircle / 2;
            double teoTri = Triangle(750, 500);

            double teoArea = teoRect + teoCircle + teoTri;

            double flooringCost = teoArea * 180;
            flooringCost = Math.Round(flooringCost, 2);
            Console.WriteLine($"The Teotihuacan is {teoArea} meters squared in area. \nThe cost of flooring is 180 Mexican Pesos per square meter. \nThe total cost of flooring Teotihuacan is {flooringCost} Mexican Pesos");

        }
        public static double Rectangle(double l, double w)
        {
            double area = l * w;
            return area;
        }

        public static double Circle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }

        public static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }

    }
}
