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
        private readonly PokemonHomeView pokemonHomeView;
        private readonly PokemonMascotView PokemonMascotView;
        private readonly PokemonService pokemonService;
        private readonly List<Mascot> mascots;

        public PokemonController()
        {
            mascots = new List<Mascot>();
            pokemonService = new PokemonService();
            pokemonHomeView = new PokemonHomeView();
            PokemonMascotView = new PokemonMascotView();
        }

        public void MainGame()
        {
            int play = 1;
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
                        string mascotName = pokemonHomeView.AdoptionMenu();
                        Pokemon pokemonAdoption = pokemonService.GetPokemon(mascotName);
                        if (pokemonAdoption != null)
                        {
                            Mascot mascot = Mascot.GetMascotFromPokemon(pokemonAdoption);
                            mascots.Add(mascot);
                            Console.WriteLine("MASCOT ADOPTED :D");
                        }
                        break;
                    case "3":
                        string pokemonSelected = pokemonHomeView.DetailsMenu();
                        Pokemon pokemon = pokemonService.GetPokemon(pokemonSelected);
                        if (pokemon != null)
                        {
                            Console.WriteLine(pokemon.ToString());
                        }
                        break;
                    case "4":
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
            if (mascots.Count() == 0)
            {
                Console.WriteLine("You dont have an mascot to take care, adopt one first\n");
                return;
            }

            string mascotNameSelected = PokemonMascotView.SelectMascotToPlay(mascots);
            Mascot mascotSelected = FindMascotToInteract(mascotNameSelected);
            int play = 1;
            int hungerCounter = 0;
            int happinessCounter = 0;
            while (play == 1)
            {
                PokemonMascotView.MainMenu(mascotNameSelected);
                string optionSelected = Console.ReadLine();
                switch (optionSelected)
                {
                    case "1":
                        PokemonMascotView.Play(mascotNameSelected);
                        mascotSelected.PlayWith();
                        hungerCounter++;
                        break;
                    case "2":
                        PokemonMascotView.Feed(mascotNameSelected);
                        mascotSelected.Feed();
                        happinessCounter++;
                        break;
                    case "3":
                        PokemonMascotView.SeeStatus(mascotSelected); 
                        break;
                    case "4":
                        Console.WriteLine("Bye Bye :D");
                        play = 0;
                        break;
                    default : 
                        Console.WriteLine("Select a valid option please :>");
                        break;
                }

                if (hungerCounter == 3)
                {
                    mascotSelected.FeelHungry();
                    hungerCounter = 0;
                }

                if (happinessCounter == 3)
                {
                    mascotSelected.GetBored();
                    hungerCounter = 0;
                }
            }
        }

        private Mascot FindMascotToInteract(string mascotName)
        {
            foreach (Mascot mascot in mascots)
            {
                if (mascotName == mascot.name)
                {
                    return mascot;
                }
            }
            Console.WriteLine("Mascot not found!");
            return null;
        }
    }
}
