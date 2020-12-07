using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCoding
{
    //Day Four
    class Person
    {
        /*Write a Person class with an instance variable, age, and a constructor that takes an integer, initialAge, as a parameter. 
        The constructor must assign initialAge to age after confirming the argument passed as initialAge is not negative; if a negative argument is passed as initialAge,
        the constructor should set age to 0 and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:
            yearPasses() should increase the age instance variable by 1.
            amIOld() should perform the following conditional actions:
                If age < 13, print You are young..
                If age >= 13 and age < 18, print You are a teenager..
                Otherwise, print You are old..  */


        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0."); 
            }
            else
            {
                age = initialAge;
            }
        }
        public void AmIOld()
        {
            if (age < 13)
                Console.WriteLine("You are young.");
            else if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
        }

        public void YearPasses()
        {
            age++;
        }
    }
}
