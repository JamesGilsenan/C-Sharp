using System;

namespace Supernatural_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil("Harry Potter");
            Mage mage = new Mage("Severous Snape", "Slytherin");
            Archmage archmage = new Archmage("Albus Dumbledore", "Unknown");

            Console.WriteLine(pupil.CastWindStorm());
            Console.WriteLine(mage.CastWindStorm());
            Console.WriteLine(mage.CastRainStorm());
            Console.WriteLine(archmage.CastWindStorm());
            Console.WriteLine(archmage.CastRainStorm());
            Console.WriteLine(archmage.CastLightningStorm());

            Console.Read();
        }
    }
}
