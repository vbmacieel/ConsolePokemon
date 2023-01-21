using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.View
{
    public class PokemonHomeView
    {
        public string UserName { get; set; }

        public PokemonHomeView()
        {
            GreetingsMenu();
        }

        private void GreetingsMenu()
        {
            //Criar um nome top pro menu
            Console.WriteLine();
            Console.Write("Hello, what's your name? ");
            UserName = Console.ReadLine();
            Console.WriteLine();
        }

        public void MainMenu()
        {
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine($"{UserName} what do you want to do?");
            Console.WriteLine("1 - Adopt a mascot");
            Console.WriteLine("2 - Details of a pokemon");
            Console.WriteLine("3 - Exit");
        }

        public void AdoptionMenu()
        {
            Console.WriteLine("---------- ADOPT A MASCOT ----------");
            Console.WriteLine($"{UserName} which pokemon do you want to adopt?");
            Console.WriteLine("BULBASAUR");
            Console.WriteLine("IVYSAUR");
            Console.WriteLine("PIKACHU");
        }

        public string DetailsMenu()
        {
            Console.WriteLine("---------- DETAILS OF A POKEMON ----------");
            Console.WriteLine($"{UserName} choose a pokemon to see his details");
            Console.Write("Choose a pokemon name: ");
            string pokemonName = Console.ReadLine();
            return pokemonName;
        }

    }
}
