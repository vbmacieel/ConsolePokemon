using ConsolePokemon.Controller;
using ConsolePokemon.Model;
using ConsolePokemon.View;
using RestSharp;
using System.Text.Json;

namespace ConsolePokemon
{
    public class Program
    {
        private static void Main(string[] args)
        {
            PokemonController controller = new PokemonController();
            controller.MainGame();
        }
    }
}