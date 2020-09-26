using System;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            Console.Write("Your Password is : ");
            foreach (char letter in Password)
                if (Hidden == false)
                    Console.Write(letter);
                else
                    Console.Write("*");
            Console.WriteLine("\n");
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}