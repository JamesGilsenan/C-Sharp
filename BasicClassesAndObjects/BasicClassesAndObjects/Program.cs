using System;

namespace Basic_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest11OverloadingConstructors f = new Forest11OverloadingConstructors("Amazon", "Tropical");

            Console.WriteLine(f.Trees);
            f.Grow();
            Console.WriteLine(f.Trees);
            f.Grow();
            Console.WriteLine(f.Trees);
            f.Burn();
            Console.WriteLine(f.Trees);
            Console.WriteLine(f.age);

            Console.Read();
        }
    }
}
