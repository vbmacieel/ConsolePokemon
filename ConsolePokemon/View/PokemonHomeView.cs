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
            Console.WriteLine("1 - Take care of your mascots");
            Console.WriteLine("2 - Adopt an mascot");
            Console.WriteLine("3 - Details of a pokemon");
            Console.WriteLine("4 - Exit");
        }

        public string AdoptionMenu()
        {
            Console.WriteLine("---------- ADOPT A MASCOT ----------");
            Console.WriteLine($"{UserName} which pokemon do you want to adopt?");
            string pokemonName = Console.ReadLine();
            return pokemonName;
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
