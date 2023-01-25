using ConsolePokemon.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsolePokemon.Service.Impl
{
    public class PokemonService : IPokemonService
    {
        private string urlPokeApi = "https://pokeapi.co/api/v2/pokemon/";

        public void GetPokemon(string pokemonName)
        {
            string urlGetPokemon = urlPokeApi + pokemonName;
            RestResponse response = GetResponse(urlGetPokemon);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = response.Content;
                var pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                Console.WriteLine(pokemon.ToString());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        private RestResponse GetResponse(string url) 
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(url, Method.Get);
            return client.Execute(request);

        }
    }
}
