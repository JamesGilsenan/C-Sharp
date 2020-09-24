using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Classes_and_Objects
{
    class Forest9Constructor
    {
        public int age;
        private string biome;

        //Defining a constructor here. A constructor automatically sets the values for properties. If no constructor is defined, one is automatically created
        public Forest9Constructor(string name, string biome)
        {
            Name = name;
            Biome = biome;
            Age = 0;
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
