using ConsolePokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.View
{
    public class PokemonMascotView
    {
        public void MainMenu(string mascotName)
        {
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine($"What do you want to do with {mascotName}?");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Feed");
            Console.WriteLine($"3 - See {mascotName} status");
            Console.WriteLine("4 - Leave mascot menu");
        }

        public string SelectMascotToPlay(List<Mascot> mascots)
        {
            Console.WriteLine("---------- FIRST SELECT A MASCOT ----------");
            Console.WriteLine("Select a mascot to interact with: ");
            foreach (Mascot mascot in mascots)
            {
                Console.WriteLine(mascot.name);
            }
            string mascotName = Console.ReadLine();
            return mascotName;
        }

        public void Play(string pokemonName)
        {
            Console.WriteLine($"Playing with {pokemonName}");
            Console.WriteLine("Having fun :DD");
        }

        public void Feed(string pokemonName)
        {
            Console.WriteLine($"Feeding {pokemonName}");
        }

        public void SeeStatus(Mascot mascot)
        {
            Console.WriteLine("---------- MASCOT STATUS ----------");
            Console.WriteLine(mascot.ToString());
        }
    }
}
