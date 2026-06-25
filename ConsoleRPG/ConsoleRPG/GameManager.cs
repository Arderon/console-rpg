using System;
using System.Collections.Generic;

namespace ConsoleRPG
{
    public class GameManager
    {
        public string Name { get; private set; } = "";

        public void StartGame()
        {
            Console.WriteLine("New game started. A new beginnig...");
            CreateCharacter();
        }

        public void CreateCharacter()
        {
            ChooseName();
            Console.WriteLine($"I Arsen The Creator of ConsoleRPG declare that you are now {Name}");
        }

        private void ChooseName()
        {
            Console.WriteLine("Choose a name for your character: ");
            string? name = "";
            while (string.IsNullOrEmpty(name))
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name can`t be empty!");
                    Console.WriteLine("Name: ");
                }
            }

            Name = name;
        }
    }
}
