﻿using ConsolePokemon.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsolePokemon
{
    internal class PokemonService
    {
        public void PokeApiGet(string pokemonName)
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