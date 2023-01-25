using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.Model
{
    public class Mascot : Pokemon
    {
        public int Hunger { get; set; }
        public int Happiness { get; set; }

        public Mascot(string name, int height, int weight, List<Abilities> abilities) : 
            base(name, height, weight, abilities) 
        {
            Hunger = 0;
            Happiness = 0;
        }

        public Mascot()
        {
            Hunger = 0;
            Happiness = 0;
        }

        public void Feed()
        {
            Hunger++;
        }

        public void PlayWith()
        {
            Happiness++;
        }

        public void FeelHungry()
        {
            Hunger--;
        }

        public void GetBored()
        {
            Happiness--;
        }

        public static Mascot GetMascotFromPokemon(Pokemon pokemon) => 
            new Mascot(pokemon.name, pokemon.height, pokemon.weight, pokemon.abilities);

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {name}\n");
            sb.Append($"Height: {height}\n");
            sb.Append($"Weight: {weight}\n");
            sb.Append($"Hunger: {Hunger}\n");
            sb.Append($"Happiness: {Happiness}\n");
            return sb.ToString();
        }
    }
}
