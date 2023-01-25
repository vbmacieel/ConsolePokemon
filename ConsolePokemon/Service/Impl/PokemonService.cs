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

        public Pokemon GetPokemon(string pokemonName)
        {
            string urlGetPokemon = urlPokeApi + pokemonName;
            RestResponse response = GetResponse(urlGetPokemon);
            string json = response.Content;
            try
            {
                Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                return pokemon;
            }
            catch (Exception)
            {
                Console.WriteLine("Can't get this pokemon!\n");
            }
            return null;
        }

        private RestResponse GetResponse(string url) 
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(url, Method.Get);
            return client.Execute(request);

        }
    }
}
