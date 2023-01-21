using ConsolePokemon.Service;
using ConsolePokemon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.Controller
{
    public class PokemonController
    {
        public static void Play()
        {
            string userOptions;
            int play = 1;
            PokemonHomeView pokemonView = new PokemonHomeView();

            while (play == 1)
            {
                pokemonView.MainMenu();
                string optionSelected = Console.ReadLine();

                switch (optionSelected)
                {
                    case "1":
                        pokemonView.AdoptionMenu();
                        break;
                    case "2":
                        string pokemonSelected = pokemonView.DetailsMenu();
                        PokemonService pokemonService = new PokemonService();
                        try
                        {
                            pokemonService.PokeApiGet(pokemonSelected.ToLower());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Pokemon not found, select othe name!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Bye bye :D");
                        play = 0;
                        break;
                    default:
                        Console.WriteLine("Select other option pls :D");
                        break;
                }
            }
        }
    }
}
