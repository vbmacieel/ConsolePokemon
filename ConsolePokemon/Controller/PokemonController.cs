using ConsolePokemon.Model;
using ConsolePokemon.Service.Impl;
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
        private PokemonHomeView pokemonHomeView;
        private PokemonMascotView PokemonMascotView;
        private List<Pokemon> pokemonList;

        public PokemonController()
        {
            pokemonList= new List<Pokemon>(); 
        }

        public void Play()
        {
            string userOptions;
            int play = 1;
            pokemonHomeView = new PokemonHomeView();

            while (play == 1)
            {
                pokemonHomeView.MainMenu();
                string optionSelected = Console.ReadLine();

                switch (optionSelected)
                {
                    case "1":
                        Adoption();
                        break;
                    case "2":
                        string pokemonSelected = pokemonHomeView.DetailsMenu();
                        PokemonService pokemonService = new PokemonService();
                        try
                        {
                            pokemonService.GetPokemon(pokemonSelected.ToLower());
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

        private void Adoption()
        {
            pokemonHomeView.AdoptionMenu();
        }
    }
}
