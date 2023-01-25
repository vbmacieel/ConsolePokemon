using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.Model
{
    public class Pokemon
    {
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public List<Abilities> abilities { get; set; }

        public Pokemon(string name, int height, int weight, List<Abilities> abilities)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.abilities = abilities;
        }

        public Pokemon()
        {

        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {name}\n");
            sb.Append($"Height: {height}\n");
            sb.Append($"Weight: {weight}\n");
            sb.Append("Abilities\n");
            foreach (var ability in abilities)
            {
                sb.Append($"{ability.ability.name.ToUpper()}\n");
            }
            return sb.ToString();
        }
    }
}
