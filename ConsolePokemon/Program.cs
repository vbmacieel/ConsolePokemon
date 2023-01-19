using RestSharp;
using System.Text.Json;

namespace ConsolePokemon
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string pokemonName = "bulbasaur";
            PokeApiGet(pokemonName);
        }

        private static void PokeApiGet(string pokemonName)
        {
            string urlPokeApi = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(urlPokeApi, Method.Get);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = response.Content;
                var pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                Console.WriteLine(pokemon.ToString());
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}