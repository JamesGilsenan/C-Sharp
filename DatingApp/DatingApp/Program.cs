using System;
using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakilla", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[] { "Running", "Reading" });
            Console.WriteLine(sam.ViewProfile());
        }
    }
}