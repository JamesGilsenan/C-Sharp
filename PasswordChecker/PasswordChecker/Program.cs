using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicAndConditionals
{
    class Program
    {
        public static void Main(string[] args)
        {
            PasswordChecker checker = new PasswordChecker();
            TextAdventure game = new TextAdventure();
            //checker.Run();
            game.Run();
        }
    }
}
