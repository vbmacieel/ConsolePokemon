using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.Service
{
    internal interface IPokemonService
    {
        void GetPokemon(string pokemonName);
    }
}
