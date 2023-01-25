using ConsolePokemon.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePokemon.Model
{
    public class Mascot : Pokemon
    {
        public Hunger Hunger { get; set; }
        public Happiness Happiness { get; set; }

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

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {name}\n");
            sb.Append($"Height: {height}\n");
            sb.Append($"Weight: {weight}\n");
            sb.Append($"Hunger: {Hunger.ToString()}\n");
            sb.Append($"Happiness: {Happiness.ToString()}\n");
            return sb.ToString();
        }
    }
}
