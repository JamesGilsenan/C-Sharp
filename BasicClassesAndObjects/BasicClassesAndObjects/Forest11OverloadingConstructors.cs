using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Classes_and_Objects
{
    class Forest11OverloadingConstructors
    {
        public int age;
        private string biome;

        public Forest11OverloadingConstructors(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
        }
        //Remember that this.Name refers to the current instance of a class. When we use this() like a method, it refers to another constructor in the current class.
        //In this example, the second constructor calls this() — which refers to the first Forest() constructor — AND it prints information to the console.
        public Forest11OverloadingConstructors(string name) : this(name, "Unknown")
        {
            Console.WriteLine("Warning. Name property not specified. Value defaulted to 'Unknown'");
        }

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }
}