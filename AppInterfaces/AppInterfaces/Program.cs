using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Display();
            tdl.Reset();
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", false);
            pm.Display();
            pm.Reset();
            pm.Display();
            

            Console.Read();
        }
    }
}