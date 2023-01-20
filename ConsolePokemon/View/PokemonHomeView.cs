using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.View
{
    public static class PokemonHomeView
    {

        public static void MainMenu()
        {
            //Criar um nome top pro menu
            Console.WriteLine();
            Console.Write("Hello, what's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine($"{name} what do you want to do?");
            Console.WriteLine("1 - Adopt a mascot");
            Console.WriteLine("2 - See your adopted mascots");
            Console.WriteLine("3 - Exit");

            string answerString = Console.ReadLine();
            try
            {
                int userAnswer = int.Parse(answerString);
                switch (userAnswer)
                {
                    case 1:
                        //Criar nova chamada a api para mostrar todos os pokemons
                        break;
                    case 2:
                        PokemonService pokemonService = new PokemonService();
                        pokemonService.PokeApiGet("bulbasaur");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for try this app :D");
                        Environment.Exit(0);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to format {answerString}");
            }
        }

    }
}
