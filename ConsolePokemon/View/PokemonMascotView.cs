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
        public void MainMenu()
        {
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine($"What do you want to do with your mascot?");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Feed");
            Console.WriteLine("3 - See mascot status");
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
            mascot.ToString();
        }
    }
}
